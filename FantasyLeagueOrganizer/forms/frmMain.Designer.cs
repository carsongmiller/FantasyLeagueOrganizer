namespace FantasyLeagueOrganizer.Forms
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            reloadLeagueToolStripMenuItem = new ToolStripMenuItem();
            adminToolStripMenuItem = new ToolStripMenuItem();
            adminControlsToolStripMenuItem = new ToolStripMenuItem();
            btnBeginDraft = new Button();
            leagueSummary1 = new FantasyLeagueOrganizer.controls.LeagueSummary();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, adminToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1128, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { reloadLeagueToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // reloadLeagueToolStripMenuItem
            // 
            reloadLeagueToolStripMenuItem.Name = "reloadLeagueToolStripMenuItem";
            reloadLeagueToolStripMenuItem.Size = new Size(180, 22);
            reloadLeagueToolStripMenuItem.Text = "Reload League";
            reloadLeagueToolStripMenuItem.Click += reloadLeagueToolStripMenuItem_Click;
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adminControlsToolStripMenuItem });
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(55, 20);
            adminToolStripMenuItem.Text = "Admin";
            // 
            // adminControlsToolStripMenuItem
            // 
            adminControlsToolStripMenuItem.Name = "adminControlsToolStripMenuItem";
            adminControlsToolStripMenuItem.Size = new Size(180, 22);
            adminControlsToolStripMenuItem.Text = "Admin Controls";
            adminControlsToolStripMenuItem.Click += adminControlsToolStripMenuItem_Click;
            // 
            // btnBeginDraft
            // 
            btnBeginDraft.Location = new Point(12, 27);
            btnBeginDraft.Name = "btnBeginDraft";
            btnBeginDraft.Size = new Size(222, 123);
            btnBeginDraft.TabIndex = 1;
            btnBeginDraft.Text = "Begin Draft";
            btnBeginDraft.UseVisualStyleBackColor = true;
            btnBeginDraft.Click += btnBeginDraft_Click;
            // 
            // leagueSummary1
            // 
            leagueSummary1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            leagueSummary1.Location = new Point(722, 27);
            leagueSummary1.Name = "leagueSummary1";
            leagueSummary1.Size = new Size(394, 478);
            leagueSummary1.TabIndex = 2;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 517);
            Controls.Add(leagueSummary1);
            Controls.Add(btnBeginDraft);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            Text = "Fantasy League Organizer";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem adminControlsToolStripMenuItem;
        private Button btnBeginDraft;
        private ToolStripMenuItem reloadLeagueToolStripMenuItem;
        private controls.LeagueSummary leagueSummary1;
    }
}