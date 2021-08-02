using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETS2Trax {
    public partial class LibraryTab : UserControl {
        private const string musicDirName = @"music\";
        private const string profileDirName = @"profiles\";
        private const string shelfDirName = @"Shelf\";
        private const string separator = "\\";

        private Game game;
        private HashSet<string> tracks = new HashSet<string>();
        // List<string> tracks = new List<string>();

        public string DataDirPath { get; private set; } = "";
        public string InsertedCd { get; set; } = "";
        public string SelectedCd { get; set; } = "";

        public LibraryTab() {
            InitializeComponent();
        }

        public void InitializeForGame(Game game) {
            this.game = game;
            selectButton.Enabled = false;
            insertButton.Enabled = false;
            addSongButton.Enabled = false;
            removeSongButton.Enabled = false;
        }

        private void loadTracksSelectedCd() {
            if (!string.IsNullOrEmpty(SelectedCd)) {
                tracks.Clear();
                trackListBox.Items.Clear();
                tracks.UnionWith(Directory.GetFiles(DataDirPath + shelfDirName + SelectedCd).Select(Path.GetFileName));
                trackListBox.BeginUpdate();
                trackListBox.Items.AddRange(tracks.ToArray());
                trackListBox.EndUpdate();
                setTrackButtons(true);
            }
        }

        private void unloadTracksSelectedCd() {
            setTrackButtons(false);
            tracks.Clear();
            trackListBox.Items.Clear();
            SelectedCd = "";
            UpdateSelectedCdDetails();
        }

        private void UpdateSelectedCdDetails() {
            if (!string.IsNullOrEmpty(SelectedCd)) {
                cdNameText.Text = SelectedCd;
                createdAtText.Text = Directory.GetCreationTime(DataDirPath + shelfDirName + SelectedCd).ToString();
                songsCountText.Text = Directory.GetFiles(DataDirPath + shelfDirName + SelectedCd).Length.ToString();
            } else {
                cdNameText.Text = "N/A";
                createdAtText.Text = "N/A";
                songsCountText.Text = "N/A";
            }
        }

        private void UpdateInsertedCdDetails() {
            insertedCdLabel.Text = string.Format("Inserted CD: {0}",
                        string.IsNullOrEmpty(InsertedCd) ? "N/A" : InsertedCd);
        }

        private void setTrackButtons(bool state) {
            insertButton.Enabled =
            addSongButton.Enabled = state;
            removeSongButton.Enabled = state;
        }

        private string queryCurrentCd() {
            if (!string.IsNullOrEmpty(DataDirPath)) {
                string[] datFile = Directory.GetFiles(DataDirPath + musicDirName, "*.sgdat");
                if (datFile.Length == 1) {
                    return datFile[0].Replace(DataDirPath + musicDirName, null);
                } else if (datFile.Length > 1) {
                    // More than one dat file hmm...
                    MessageBox.Show(
                    string.Format("Music directory contains currupted data, can not proceed", game.ToString()),
                    "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
                return "";
            }
            return "";
        }

        private void loadButton_Click(object sender, EventArgs e) {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog() {
                Description = string.Format("Select your {0} data directory", game.ToString()),
                RootFolder = Environment.SpecialFolder.MyDocuments,
                ShowNewFolderButton = false,
                UseDescriptionForTitle = true
            };
            DialogResult dialogResult = folderBrowserDialog.ShowDialog();
            if (dialogResult == DialogResult.OK) {
                // Cheap check to see if it's a valid game data directory
                if (Directory.Exists(folderBrowserDialog.SelectedPath + separator + profileDirName)) {
                    // Success
                    DataDirPath = folderBrowserDialog.SelectedPath + separator;
                    statusLabel.Text = string.Format("Selected Directory: {0}", DataDirPath);
                    InsertedCd = queryCurrentCd().Replace(".sgdat", null);
                    UpdateInsertedCdDetails();
                    loadTracksSelectedCd();
                    Directory.CreateDirectory(DataDirPath + shelfDirName);
                    loadButton.Enabled = false;
                    selectButton.Enabled = true;
                } else {
                    MessageBox.Show(
                        string.Format("Please select a valid {0} data directory", game.ToString()),
                        "Please select a valid directory",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else {
                if (string.IsNullOrEmpty(DataDirPath))
                    MessageBox.Show(
                        string.Format("Please select your {0} data directory", game.ToString()),
                        "Please select a directory",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void selectButton_Click(object sender, EventArgs e) {
            unloadTracksSelectedCd();
            CdSelector cdSelector = new CdSelector(DataDirPath + shelfDirName);
            // I wish I could've given some more time to .NET :0 nevermind
            cdSelector.ShowDialog();
            if (cdSelector.Result == DialogResult.OK) {
                // Success
                SelectedCd = cdSelector.SelectedCd;
                UpdateSelectedCdDetails();
                loadTracksSelectedCd();
            } else { }
            cdSelector.Dispose();
        }

        private void insertButton_Click(object sender, EventArgs e) {
            progressBar.Visible = true;
            setTrackButtons(false);
            selectButton.Enabled = false;
            HashSet<string> f = new HashSet<string>(Directory.GetFiles(DataDirPath + musicDirName));

            DeleteFilesAsync(new HashSet<string>(Directory.GetFiles(DataDirPath + musicDirName)))
                .GetAwaiter().OnCompleted(() => {
                    progressBar.Visible = false;
                    setTrackButtons(true);
                    selectButton.Enabled = true;
                    loadTracksSelectedCd();
                    UpdateSelectedCdDetails();
                }
            );
            // Copy Tracks
            HashSet<string> toAdd = new HashSet<string>(Directory.GetFiles(DataDirPath + shelfDirName + SelectedCd));
            CopyFilesAsync(toAdd, DataDirPath + musicDirName).GetAwaiter().OnCompleted(() => {
                progressBar.Visible = false;
                setTrackButtons(true);
                selectButton.Enabled = true;
                loadTracksSelectedCd();
                UpdateSelectedCdDetails();
            });
            StreamWriter writer = File.CreateText(DataDirPath + musicDirName +
                SelectedCd.Replace(separator, ".sgdat"));
            writer.WriteLine("[CD NAME]: " + SelectedCd.Replace(separator, null));
            writer.WriteLine("[TRACKS COUNT]: " + tracks.Count);
            writer.Flush();
            writer.Close();
            MessageBox.Show(
                   "Selected CD was inserted",
                   "Success",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            InsertedCd = queryCurrentCd().Replace(".sgdat", null);
            UpdateInsertedCdDetails();
        }

        private void addSongButton_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog() {
                CheckFileExists = true,
                DereferenceLinks = true,
                Multiselect = true,
                Filter = "Music (*.mp3)|*.mp3",
                Title = "Select Tracks to Add"
            };
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK) {
                progressBar.Visible = true;
                setTrackButtons(false);
                selectButton.Enabled = false;
                HashSet<string> files = new HashSet<string>(openFileDialog.FileNames);
                tracks.UnionWith(files);
                CopyFilesAsync(files, DataDirPath + shelfDirName + SelectedCd).GetAwaiter().OnCompleted(() => {
                    progressBar.Visible = false;
                    setTrackButtons(true);
                    selectButton.Enabled = true;
                    loadTracksSelectedCd();
                    UpdateSelectedCdDetails();
                });
            }
        }

        private void removeSongButton_Click(object sender, EventArgs e) {
            var selectedTrack = trackListBox.SelectedItem;
            if (selectedTrack != null) {
                File.Delete(DataDirPath + shelfDirName + SelectedCd + selectedTrack.ToString());
                loadTracksSelectedCd();
                UpdateSelectedCdDetails();
            } else {
                MessageBox.Show(
                   "Please select the track you want to remove from list",
                   "Please select a track",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task CopyFilesAsync(HashSet<string> files, string folder) {
            // users won't mind, or will they?
            await Task.Run(() => {
                foreach (string filePath in files) {
                    File.Copy(filePath, folder + Path.GetFileName(filePath));
                }
            });
        }

        private async Task DeleteFilesAsync(HashSet<string> files) {
            await Task.Run(() => {
                foreach (string filePath in files) {
                    File.Delete(filePath);
                }
            });
        }
    }
}
