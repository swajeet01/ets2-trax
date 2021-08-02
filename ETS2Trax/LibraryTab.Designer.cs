
namespace ETS2Trax {
    partial class LibraryTab {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.buttonGroup = new System.Windows.Forms.GroupBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.addSongButton = new System.Windows.Forms.Button();
            this.selectButton = new System.Windows.Forms.Button();
            this.removeSongButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.detailsBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.createdAtText = new System.Windows.Forms.Label();
            this.createdAtLabel = new System.Windows.Forms.Label();
            this.songsCountText = new System.Windows.Forms.Label();
            this.songsCountLabel = new System.Windows.Forms.Label();
            this.sizeText = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.cdNameText = new System.Windows.Forms.Label();
            this.cdNameLable = new System.Windows.Forms.Label();
            this.songsListGroup = new System.Windows.Forms.GroupBox();
            this.trackListBox = new System.Windows.Forms.ListBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.insertedCdLabel = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.buttonGroup.SuspendLayout();
            this.detailsBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.songsListGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGroup
            // 
            this.buttonGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonGroup.Controls.Add(this.loadButton);
            this.buttonGroup.Controls.Add(this.addSongButton);
            this.buttonGroup.Controls.Add(this.selectButton);
            this.buttonGroup.Controls.Add(this.removeSongButton);
            this.buttonGroup.Controls.Add(this.insertButton);
            this.buttonGroup.Location = new System.Drawing.Point(0, 0);
            this.buttonGroup.Margin = new System.Windows.Forms.Padding(50, 50, 3, 3);
            this.buttonGroup.Name = "buttonGroup";
            this.buttonGroup.Padding = new System.Windows.Forms.Padding(10);
            this.buttonGroup.Size = new System.Drawing.Size(116, 266);
            this.buttonGroup.TabIndex = 0;
            this.buttonGroup.TabStop = false;
            // 
            // loadButton
            // 
            this.loadButton.AutoSize = true;
            this.loadButton.Location = new System.Drawing.Point(13, 31);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(90, 25);
            this.loadButton.TabIndex = 4;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // addSongButton
            // 
            this.addSongButton.AutoSize = true;
            this.addSongButton.Location = new System.Drawing.Point(13, 195);
            this.addSongButton.Name = "addSongButton";
            this.addSongButton.Size = new System.Drawing.Size(90, 25);
            this.addSongButton.TabIndex = 2;
            this.addSongButton.Text = "Add Track";
            this.addSongButton.UseVisualStyleBackColor = true;
            this.addSongButton.Click += new System.EventHandler(this.addSongButton_Click);
            // 
            // selectButton
            // 
            this.selectButton.AutoSize = true;
            this.selectButton.Location = new System.Drawing.Point(13, 62);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(90, 25);
            this.selectButton.TabIndex = 0;
            this.selectButton.Text = "Select CD";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // removeSongButton
            // 
            this.removeSongButton.AutoSize = true;
            this.removeSongButton.Location = new System.Drawing.Point(13, 226);
            this.removeSongButton.Name = "removeSongButton";
            this.removeSongButton.Size = new System.Drawing.Size(90, 25);
            this.removeSongButton.TabIndex = 3;
            this.removeSongButton.Text = "Remove Track";
            this.removeSongButton.UseVisualStyleBackColor = true;
            this.removeSongButton.Click += new System.EventHandler(this.removeSongButton_Click);
            // 
            // insertButton
            // 
            this.insertButton.AutoSize = true;
            this.insertButton.Location = new System.Drawing.Point(13, 93);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(90, 25);
            this.insertButton.TabIndex = 1;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // detailsBox
            // 
            this.detailsBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.detailsBox.Controls.Add(this.tableLayoutPanel1);
            this.detailsBox.Location = new System.Drawing.Point(134, 0);
            this.detailsBox.Margin = new System.Windows.Forms.Padding(50, 50, 3, 3);
            this.detailsBox.Name = "detailsBox";
            this.detailsBox.Padding = new System.Windows.Forms.Padding(10);
            this.detailsBox.Size = new System.Drawing.Size(226, 266);
            this.detailsBox.TabIndex = 4;
            this.detailsBox.TabStop = false;
            this.detailsBox.Text = "Selected CD";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.createdAtText, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.createdAtLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.songsCountText, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.songsCountLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.sizeText, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.sizeLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cdNameText, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cdNameLable, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 26);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // createdAtText
            // 
            this.createdAtText.AutoSize = true;
            this.createdAtText.Location = new System.Drawing.Point(103, 60);
            this.createdAtText.Name = "createdAtText";
            this.createdAtText.Size = new System.Drawing.Size(29, 15);
            this.createdAtText.TabIndex = 7;
            this.createdAtText.Text = "N/A";
            // 
            // createdAtLabel
            // 
            this.createdAtLabel.AutoSize = true;
            this.createdAtLabel.Location = new System.Drawing.Point(3, 60);
            this.createdAtLabel.Name = "createdAtLabel";
            this.createdAtLabel.Size = new System.Drawing.Size(74, 15);
            this.createdAtLabel.TabIndex = 6;
            this.createdAtLabel.Text = "Modified On";
            // 
            // songsCountText
            // 
            this.songsCountText.AutoSize = true;
            this.songsCountText.Location = new System.Drawing.Point(103, 40);
            this.songsCountText.Name = "songsCountText";
            this.songsCountText.Size = new System.Drawing.Size(29, 15);
            this.songsCountText.TabIndex = 5;
            this.songsCountText.Text = "N/A";
            // 
            // songsCountLabel
            // 
            this.songsCountLabel.AutoSize = true;
            this.songsCountLabel.Location = new System.Drawing.Point(3, 40);
            this.songsCountLabel.Name = "songsCountLabel";
            this.songsCountLabel.Size = new System.Drawing.Size(75, 15);
            this.songsCountLabel.TabIndex = 4;
            this.songsCountLabel.Text = "Tracks Count";
            // 
            // sizeText
            // 
            this.sizeText.AutoSize = true;
            this.sizeText.Location = new System.Drawing.Point(103, 20);
            this.sizeText.Name = "sizeText";
            this.sizeText.Size = new System.Drawing.Size(29, 15);
            this.sizeText.TabIndex = 3;
            this.sizeText.Text = "N/A";
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(3, 20);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(27, 15);
            this.sizeLabel.TabIndex = 2;
            this.sizeLabel.Text = "Size";
            // 
            // cdNameText
            // 
            this.cdNameText.AutoSize = true;
            this.cdNameText.Location = new System.Drawing.Point(103, 0);
            this.cdNameText.Name = "cdNameText";
            this.cdNameText.Size = new System.Drawing.Size(29, 15);
            this.cdNameText.TabIndex = 1;
            this.cdNameText.Text = "N/A";
            // 
            // cdNameLable
            // 
            this.cdNameLable.AutoSize = true;
            this.cdNameLable.Location = new System.Drawing.Point(3, 0);
            this.cdNameLable.Name = "cdNameLable";
            this.cdNameLable.Size = new System.Drawing.Size(58, 15);
            this.cdNameLable.TabIndex = 0;
            this.cdNameLable.Text = "CD Name";
            // 
            // songsListGroup
            // 
            this.songsListGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.songsListGroup.Controls.Add(this.trackListBox);
            this.songsListGroup.Location = new System.Drawing.Point(381, 0);
            this.songsListGroup.Margin = new System.Windows.Forms.Padding(50, 50, 3, 3);
            this.songsListGroup.Name = "songsListGroup";
            this.songsListGroup.Padding = new System.Windows.Forms.Padding(10);
            this.songsListGroup.Size = new System.Drawing.Size(252, 266);
            this.songsListGroup.TabIndex = 5;
            this.songsListGroup.TabStop = false;
            this.songsListGroup.Text = "Tracks";
            // 
            // trackListBox
            // 
            this.trackListBox.FormattingEnabled = true;
            this.trackListBox.ItemHeight = 15;
            this.trackListBox.Location = new System.Drawing.Point(13, 21);
            this.trackListBox.Name = "trackListBox";
            this.trackListBox.Size = new System.Drawing.Size(226, 229);
            this.trackListBox.TabIndex = 1;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(3, 269);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(127, 15);
            this.statusLabel.TabIndex = 6;
            this.statusLabel.Text = "Selected Directory N/A";
            // 
            // insertedCdLabel
            // 
            this.insertedCdLabel.AutoSize = true;
            this.insertedCdLabel.Location = new System.Drawing.Point(3, 284);
            this.insertedCdLabel.Name = "insertedCdLabel";
            this.insertedCdLabel.Size = new System.Drawing.Size(93, 15);
            this.insertedCdLabel.TabIndex = 7;
            this.insertedCdLabel.Text = "Inserted CD N/A";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(0, 303);
            this.progressBar.MarqueeAnimationSpeed = 10;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(360, 23);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 8;
            this.progressBar.Visible = false;
            // 
            // LibraryTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.insertedCdLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.songsListGroup);
            this.Controls.Add(this.detailsBox);
            this.Controls.Add(this.buttonGroup);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "LibraryTab";
            this.Size = new System.Drawing.Size(636, 501);
            this.buttonGroup.ResumeLayout(false);
            this.buttonGroup.PerformLayout();
            this.detailsBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.songsListGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox buttonGroup;
        private System.Windows.Forms.Button removeSongButton;
        private System.Windows.Forms.Button addSongButton;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.GroupBox detailsBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label createdAtText;
        private System.Windows.Forms.Label createdAtLabel;
        private System.Windows.Forms.Label songsCountText;
        private System.Windows.Forms.Label songsCountLabel;
        private System.Windows.Forms.Label sizeText;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Label cdNameText;
        private System.Windows.Forms.Label cdNameLable;
        private System.Windows.Forms.GroupBox songsListGroup;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.ListBox trackListBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label insertedCdLabel;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}
