
namespace ETS2Trax {
    partial class TMBForm {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.gamesTabControler = new System.Windows.Forms.TabControl();
            this.ets2Page = new System.Windows.Forms.TabPage();
            this.ets2LibraryTab = new ETS2Trax.LibraryTab();
            this.atsPage = new System.Windows.Forms.TabPage();
            this.atsLibraryTab = new ETS2Trax.LibraryTab();
            this.gamesTabControler.SuspendLayout();
            this.ets2Page.SuspendLayout();
            this.atsPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // gamesTabControler
            // 
            this.gamesTabControler.Controls.Add(this.ets2Page);
            this.gamesTabControler.Controls.Add(this.atsPage);
            this.gamesTabControler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gamesTabControler.Location = new System.Drawing.Point(0, 0);
            this.gamesTabControler.Name = "gamesTabControler";
            this.gamesTabControler.SelectedIndex = 0;
            this.gamesTabControler.Size = new System.Drawing.Size(780, 557);
            this.gamesTabControler.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.gamesTabControler.TabIndex = 0;
            // 
            // ets2Page
            // 
            this.ets2Page.Controls.Add(this.ets2LibraryTab);
            this.ets2Page.Location = new System.Drawing.Point(4, 24);
            this.ets2Page.Name = "ets2Page";
            this.ets2Page.Padding = new System.Windows.Forms.Padding(3);
            this.ets2Page.Size = new System.Drawing.Size(772, 529);
            this.ets2Page.TabIndex = 0;
            this.ets2Page.Text = "ETS2";
            this.ets2Page.UseVisualStyleBackColor = true;
            // 
            // ets2LibraryTab
            // 
            this.ets2LibraryTab.InsertedCd = "";
            this.ets2LibraryTab.Location = new System.Drawing.Point(68, 111);
            this.ets2LibraryTab.Margin = new System.Windows.Forms.Padding(10);
            this.ets2LibraryTab.Name = "ets2LibraryTab";
            this.ets2LibraryTab.SelectedCd = "";
            this.ets2LibraryTab.Size = new System.Drawing.Size(636, 365);
            this.ets2LibraryTab.TabIndex = 0;
            // 
            // atsPage
            // 
            this.atsPage.Controls.Add(this.atsLibraryTab);
            this.atsPage.Location = new System.Drawing.Point(4, 24);
            this.atsPage.Name = "atsPage";
            this.atsPage.Padding = new System.Windows.Forms.Padding(3);
            this.atsPage.Size = new System.Drawing.Size(772, 529);
            this.atsPage.TabIndex = 1;
            this.atsPage.Text = "ATS";
            this.atsPage.UseVisualStyleBackColor = true;
            // 
            // atsLibraryTab
            // 
            this.atsLibraryTab.InsertedCd = "";
            this.atsLibraryTab.Location = new System.Drawing.Point(68, 111);
            this.atsLibraryTab.Margin = new System.Windows.Forms.Padding(10);
            this.atsLibraryTab.Name = "atsLibraryTab";
            this.atsLibraryTab.SelectedCd = "";
            this.atsLibraryTab.Size = new System.Drawing.Size(636, 372);
            this.atsLibraryTab.TabIndex = 1;
            // 
            // TMBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(780, 557);
            this.Controls.Add(this.gamesTabControler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TMBForm";
            this.Text = "TMB";
            this.gamesTabControler.ResumeLayout(false);
            this.ets2Page.ResumeLayout(false);
            this.atsPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl gamesTabControler;
        private System.Windows.Forms.TabPage ets2Page;
        private System.Windows.Forms.TabPage atsPage;
        private LibraryTab ets2LibraryTab;
        private LibraryTab atsLibraryTab;
    }
}