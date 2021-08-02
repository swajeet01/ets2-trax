using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace ETS2Trax {

    // Dah: A BIG WORKARAOUND, DON'T WRITE SUCH CODE
    public partial class CdSelector : Form {

        public string ShelfPath { get; private set; }

        private const string separator = "\\";
        private HashSet<string> cdList = new HashSet<string>();
        public string SelectedCd { get; private set; }
        public DialogResult Result { get; private set; } = DialogResult.Cancel;

        public CdSelector(string shelfPath) {
            InitializeComponent();
            ShelfPath = shelfPath;
            if (!string.IsNullOrEmpty(ShelfPath)) {
                cdList.Clear();
                cdList.UnionWith(Directory.GetDirectories(ShelfPath).Select(Path.GetFileName));
                listBox.Items.Clear();
                listBox.BeginUpdate();
                listBox.Items.AddRange(cdList.ToArray());
                listBox.EndUpdate();
            }
        }

        private void selectButton_Click(object sender, System.EventArgs e) {
            if (string.IsNullOrEmpty(textBox.Text)) {
                if (listBox.SelectedItem == null) {
                    MessageBox.Show(
                        string.Format("Please select a CD or create one", textBox.Text),
                        "No CD selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } else {
                    SelectedCd = listBox.SelectedItem.ToString() + separator;
                    Result = DialogResult.OK;
                    this.Close();
                }

            } else {
                if (cdList.Contains(textBox.Text)) {
                    SelectedCd = textBox.Text + separator;
                    Result = DialogResult.OK;
                    this.Close();
                } else {
                    MessageBox.Show(
                        string.Format("CD {0} does not exists", textBox.Text),
                        "CD not found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void createButton_Click(object sender, System.EventArgs e) {
            if (string.IsNullOrEmpty(textBox.Text)) {
                MessageBox.Show(
                        string.Format("Please enter a CD name"),
                        "No name entered", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else {
                if (cdList.Contains(textBox.Text)) {
                    MessageBox.Show(
                        string.Format("There is already a CD with name {0}", textBox.Text),
                        "Duplicate names", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } else {
                    Directory.CreateDirectory(ShelfPath + textBox.Text);
                    SelectedCd = textBox.Text + separator;
                    Result = DialogResult.OK;
                    MessageBox.Show(string.Format("New CD {0} created", textBox.Text),
                        "Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void deleteButton_Click(object sender, System.EventArgs e) {
            if (string.IsNullOrEmpty(textBox.Text)) {
                MessageBox.Show(
                        string.Format("Please enter or select a CD name to delete"),
                        "No name entered", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else {
                if (cdList.Contains(textBox.Text)) {
                    Directory.Delete(ShelfPath + textBox.Text);
                    cdList.Clear();
                    listBox.Items.Clear();
                    cdList.UnionWith(Directory.GetDirectories(ShelfPath).Select(Path.GetFileName));
                    listBox.BeginUpdate();
                    listBox.Items.AddRange(cdList.ToArray());
                    listBox.EndUpdate();
                    MessageBox.Show(string.Format("CD {0} deleted", textBox.Text),
                        "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else {
                    MessageBox.Show(
                        string.Format("No CD with name {0}", textBox.Text),
                        "CD not found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void listBox_SelectedIndexChanged(object sender, System.EventArgs e) {
            if (listBox.SelectedItem != null) {
                textBox.Text = listBox.SelectedItem.ToString();
            }
        }
    }
}
