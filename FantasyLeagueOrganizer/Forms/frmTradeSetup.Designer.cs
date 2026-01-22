
namespace FantasyLeagueOrganizer.Forms
{
    partial class frmTradeSetup
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
            listTeamA = new FantasyLeagueOrganizer.Controls.listBoxTeams();
            listTeamB = new FantasyLeagueOrganizer.Controls.listBoxTeams();
            chkListTeamA = new CheckedListBox();
            chkListTeamB = new CheckedListBox();
            tbPasswordA = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tbPasswordB = new TextBox();
            btnProceed = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // listTeamA
            // 
            listTeamA.DisplayMember = "Name";
            listTeamA.DrawMode = DrawMode.OwnerDrawFixed;
            listTeamA.Font = new Font("Microsoft Sans Serif", 14.25F);
            listTeamA.FormattingEnabled = true;
            listTeamA.ItemHeight = 26;
            listTeamA.Location = new Point(12, 12);
            listTeamA.Name = "listTeamA";
            listTeamA.Size = new Size(365, 160);
            listTeamA.TabIndex = 2;
            listTeamA.SelectedIndexChanged += listTeamA_SelectedIndexChanged;
            // 
            // listTeamB
            // 
            listTeamB.DisplayMember = "Name";
            listTeamB.DrawMode = DrawMode.OwnerDrawFixed;
            listTeamB.Font = new Font("Microsoft Sans Serif", 14.25F);
            listTeamB.FormattingEnabled = true;
            listTeamB.ItemHeight = 26;
            listTeamB.Location = new Point(383, 12);
            listTeamB.Name = "listTeamB";
            listTeamB.Size = new Size(365, 160);
            listTeamB.TabIndex = 3;
            listTeamB.SelectedIndexChanged += listTeamB_SelectedIndexChanged;
            // 
            // chkListTeamA
            // 
            chkListTeamA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            chkListTeamA.CheckOnClick = true;
            chkListTeamA.Font = new Font("Microsoft Sans Serif", 14.25F);
            chkListTeamA.FormattingEnabled = true;
            chkListTeamA.Location = new Point(12, 176);
            chkListTeamA.Name = "chkListTeamA";
            chkListTeamA.Size = new Size(365, 268);
            chkListTeamA.TabIndex = 6;
            // 
            // chkListTeamB
            // 
            chkListTeamB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            chkListTeamB.CheckOnClick = true;
            chkListTeamB.Font = new Font("Microsoft Sans Serif", 14.25F);
            chkListTeamB.FormattingEnabled = true;
            chkListTeamB.Location = new Point(383, 176);
            chkListTeamB.Name = "chkListTeamB";
            chkListTeamB.Size = new Size(365, 268);
            chkListTeamB.TabIndex = 7;
            // 
            // tbPasswordA
            // 
            tbPasswordA.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            tbPasswordA.Font = new Font("Segoe UI", 14.25F);
            tbPasswordA.Location = new Point(109, 451);
            tbPasswordA.Name = "tbPasswordA";
            tbPasswordA.PasswordChar = '●';
            tbPasswordA.Size = new Size(268, 33);
            tbPasswordA.TabIndex = 20;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F);
            label1.Location = new Point(12, 454);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 9;
            label1.Text = "Password";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(383, 454);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 11;
            label2.Text = "Password";
            // 
            // tbPasswordB
            // 
            tbPasswordB.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            tbPasswordB.Font = new Font("Segoe UI", 14.25F);
            tbPasswordB.Location = new Point(480, 451);
            tbPasswordB.Name = "tbPasswordB";
            tbPasswordB.PasswordChar = '●';
            tbPasswordB.Size = new Size(268, 33);
            tbPasswordB.TabIndex = 21;
            // 
            // btnProceed
            // 
            btnProceed.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnProceed.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProceed.Location = new Point(12, 525);
            btnProceed.Name = "btnProceed";
            btnProceed.Size = new Size(737, 103);
            btnProceed.TabIndex = 22;
            btnProceed.Text = "Proceed to Confirmation";
            btnProceed.UseVisualStyleBackColor = true;
            btnProceed.Click += btnProceed_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(12, 634);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(737, 103);
            btnCancel.TabIndex = 23;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmTradeSetup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 751);
            ControlBox = false;
            Controls.Add(btnCancel);
            Controls.Add(btnProceed);
            Controls.Add(label2);
            Controls.Add(tbPasswordB);
            Controls.Add(label1);
            Controls.Add(tbPasswordA);
            Controls.Add(chkListTeamB);
            Controls.Add(chkListTeamA);
            Controls.Add(listTeamB);
            Controls.Add(listTeamA);
            MaximizeBox = false;
            MaximumSize = new Size(777, 1000);
            MinimumSize = new Size(777, 600);
            Name = "frmTradeSetup";
            Text = "Trade Setup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controls.listBoxTeams listTeamA;
        private Controls.listBoxTeams listTeamB;
        private CheckedListBox chkListTeamA;
        private CheckedListBox chkListTeamB;
        private TextBox tbPasswordA;
        private Label label1;
        private Label label2;
        private TextBox tbPasswordB;
        private Button btnProceed;
        private Button btnCancel;
    }
}