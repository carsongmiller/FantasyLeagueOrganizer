namespace FantasyLeagueOrganizer.forms
{
    partial class frmFreeAgents
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
            freeAgentsLarge1 = new FantasyLeagueOrganizer.controls.FreeAgentsLarge();
            listTeams = new ListBox();
            teamDisplaySmall1 = new TeamDisplaySmall();
            SuspendLayout();
            // 
            // freeAgentsLarge1
            // 
            freeAgentsLarge1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            freeAgentsLarge1.Location = new Point(324, 49);
            freeAgentsLarge1.Name = "freeAgentsLarge1";
            freeAgentsLarge1.Size = new Size(1047, 558);
            freeAgentsLarge1.TabIndex = 0;
            // 
            // listTeams
            // 
            listTeams.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listTeams.FormattingEnabled = true;
            listTeams.Location = new Point(12, 49);
            listTeams.Name = "listTeams";
            listTeams.Size = new Size(306, 559);
            listTeams.TabIndex = 1;
            listTeams.SelectedIndexChanged += listTeams_SelectedIndexChanged;
            // 
            // teamDisplaySmall1
            // 
            teamDisplaySmall1.Location = new Point(12, 12);
            teamDisplaySmall1.Name = "teamDisplaySmall1";
            teamDisplaySmall1.Size = new Size(365, 31);
            teamDisplaySmall1.TabIndex = 2;
            // 
            // frmFreeAgents
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1383, 619);
            Controls.Add(teamDisplaySmall1);
            Controls.Add(listTeams);
            Controls.Add(freeAgentsLarge1);
            Name = "frmFreeAgents";
            Text = "Free Agents";
            ResumeLayout(false);
        }

        #endregion

        private controls.FreeAgentsLarge freeAgentsLarge1;
        private ListBox listTeams;
        private TeamDisplaySmall teamDisplaySmall1;
    }
}