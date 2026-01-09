namespace FantasyLeagueOrganizer
{
    partial class frmSetLineup
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
            lineupEditor1 = new FantasyLeagueOrganizer.controls.LineupEditor();
            freeAgentList1 = new FantasyLeagueOrganizer.controls.FreeAgentList();
            btnAddToTeam = new Button();
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
            lineupEditor1.Location = new Point(328, 35);
            lineupEditor1.Name = "lineupEditor1";
            lineupEditor1.Size = new Size(1046, 412);
            lineupEditor1.TabIndex = 3;
            // 
            // freeAgentList1
            // 
            freeAgentList1.Location = new Point(12, 64);
            freeAgentList1.Name = "freeAgentList1";
            freeAgentList1.Size = new Size(310, 383);
            freeAgentList1.TabIndex = 4;
            // 
            // btnAddToTeam
            // 
            btnAddToTeam.Location = new Point(12, 35);
            btnAddToTeam.Name = "btnAddToTeam";
            btnAddToTeam.Size = new Size(310, 23);
            btnAddToTeam.TabIndex = 5;
            btnAddToTeam.Text = "Add to Team";
            btnAddToTeam.UseVisualStyleBackColor = true;
            btnAddToTeam.Click += this.btnAddToTeam_Click;
            // 
            // frmSetLineup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1386, 553);
            Controls.Add(btnAddToTeam);
            Controls.Add(freeAgentList1);
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
        private controls.LineupEditor lineupEditor1;
        private controls.FreeAgentList freeAgentList1; 
        private Button btnAddToTeam;
    }
}