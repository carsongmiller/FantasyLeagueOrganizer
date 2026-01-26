namespace FantasyLeagueOrganizer.Forms
{
    partial class frmModifyLineup
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
            label1 = new Label();
            tbTeamName = new TextBox();
            lineupEditor1 = new FantasyLeagueOrganizer.Controls.LineupEditor();
            btnAddToTeam = new Button();
            freeAgentsLarge1 = new FantasyLeagueOrganizer.Controls.FreeAgentsLarge();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 0;
            label1.Text = "Team: ";
            // 
            // tbTeamName
            // 
            tbTeamName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbTeamName.Location = new Point(59, 6);
            tbTeamName.Name = "tbTeamName";
            tbTeamName.ReadOnly = true;
            tbTeamName.Size = new Size(256, 23);
            tbTeamName.TabIndex = 1;
            // 
            // lineupEditor1
            // 
            lineupEditor1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lineupEditor1.Location = new Point(691, 64);
            lineupEditor1.Name = "lineupEditor1";
            lineupEditor1.Size = new Size(683, 477);
            lineupEditor1.TabIndex = 3;
            // 
            // btnAddToTeam
            // 
            btnAddToTeam.Location = new Point(12, 35);
            btnAddToTeam.Name = "btnAddToTeam";
            btnAddToTeam.Size = new Size(310, 23);
            btnAddToTeam.TabIndex = 5;
            btnAddToTeam.Text = "Add to Team";
            btnAddToTeam.UseVisualStyleBackColor = true;
            btnAddToTeam.Click += btnAddToTeam_Click;
            // 
            // freeAgentsLarge1
            // 
            freeAgentsLarge1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            freeAgentsLarge1.Location = new Point(12, 64);
            freeAgentsLarge1.Name = "freeAgentsLarge1";
            freeAgentsLarge1.Size = new Size(673, 477);
            freeAgentsLarge1.TabIndex = 6;
            // 
            // frmSetLineup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1386, 553);
            Controls.Add(freeAgentsLarge1);
            Controls.Add(btnAddToTeam);
            Controls.Add(lineupEditor1);
            Controls.Add(tbTeamName);
            Controls.Add(label1);
            Name = "frmSetLineup";
            Text = "SetLineup";
            Shown += frmSetLineup_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbTeamName;
        private Controls.LineupEditor lineupEditor1;
        private Button btnAddToTeam;
        private Controls.FreeAgentsLarge freeAgentsLarge1;
    }
}