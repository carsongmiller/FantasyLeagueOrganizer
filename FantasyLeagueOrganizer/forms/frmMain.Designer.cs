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
            leagueSummary1 = new FantasyLeagueOrganizer.Controls.LeagueSummary();
            btnPlay = new Button();
            btnTrade = new Button();
            ctrlBracket1 = new FantasyLeagueOrganizer.Controls.ctrlBracket();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, adminToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1327, 24);
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
            reloadLeagueToolStripMenuItem.Size = new Size(151, 22);
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
            adminControlsToolStripMenuItem.Size = new Size(158, 22);
            adminControlsToolStripMenuItem.Text = "Admin Controls";
            adminControlsToolStripMenuItem.Click += adminControlsToolStripMenuItem_Click;
            // 
            // btnBeginDraft
            // 
            btnBeginDraft.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBeginDraft.Location = new Point(12, 27);
            btnBeginDraft.Name = "btnBeginDraft";
            btnBeginDraft.Size = new Size(564, 123);
            btnBeginDraft.TabIndex = 1;
            btnBeginDraft.Text = "Draft";
            btnBeginDraft.UseVisualStyleBackColor = true;
            btnBeginDraft.Click += btnBeginDraft_Click;
            // 
            // leagueSummary1
            // 
            leagueSummary1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            leagueSummary1.Location = new Point(721, 27);
            leagueSummary1.Name = "leagueSummary1";
            leagueSummary1.Size = new Size(594, 723);
            leagueSummary1.TabIndex = 2;
            // 
            // btnPlay
            // 
            btnPlay.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPlay.Location = new Point(12, 285);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(564, 123);
            btnPlay.TabIndex = 3;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // btnTrade
            // 
            btnTrade.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTrade.Location = new Point(12, 156);
            btnTrade.Name = "btnTrade";
            btnTrade.Size = new Size(564, 123);
            btnTrade.TabIndex = 4;
            btnTrade.Text = "Trade";
            btnTrade.UseVisualStyleBackColor = true;
            btnTrade.Click += btnTrade_Click;
            // 
            // ctrlBracket1
            // 
            ctrlBracket1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ctrlBracket1.LineColor = Color.Black;
            ctrlBracket1.LineWidth = 5F;
            ctrlBracket1.Location = new Point(12, 27);
            ctrlBracket1.Name = "ctrlBracket1";
            ctrlBracket1.Size = new Size(875, 381);
            ctrlBracket1.TabIndex = 5;
            ctrlBracket1.TextMargins = new Padding(3);
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1327, 762);
            Controls.Add(ctrlBracket1);
            Controls.Add(btnTrade);
            Controls.Add(btnPlay);
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
        private Controls.LeagueSummary leagueSummary1;
        private Button btnPlay;
        private Button btnTrade;
        private Controls.ctrlBracket ctrlBracket1;
    }
}