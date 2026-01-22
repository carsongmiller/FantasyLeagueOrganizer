namespace FantasyLeagueOrganizer.Forms
{
    partial class frmTradeApproval
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
            tbTeamA = new TextBox();
            tbTeamB = new TextBox();
            listTeamAItems = new ListBox();
            listTeamBItems = new ListBox();
            btnConfirm = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // tbTeamA
            // 
            tbTeamA.Font = new Font("Microsoft Sans Serif", 14.25F);
            tbTeamA.Location = new Point(12, 12);
            tbTeamA.Name = "tbTeamA";
            tbTeamA.Size = new Size(331, 29);
            tbTeamA.TabIndex = 0;
            // 
            // tbTeamB
            // 
            tbTeamB.Font = new Font("Microsoft Sans Serif", 14.25F);
            tbTeamB.Location = new Point(349, 12);
            tbTeamB.Name = "tbTeamB";
            tbTeamB.Size = new Size(331, 29);
            tbTeamB.TabIndex = 1;
            // 
            // listTeamAItems
            // 
            listTeamAItems.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listTeamAItems.Font = new Font("Microsoft Sans Serif", 14.25F);
            listTeamAItems.FormattingEnabled = true;
            listTeamAItems.Location = new Point(12, 47);
            listTeamAItems.Name = "listTeamAItems";
            listTeamAItems.SelectionMode = SelectionMode.None;
            listTeamAItems.Size = new Size(331, 220);
            listTeamAItems.TabIndex = 2;
            // 
            // listTeamBItems
            // 
            listTeamBItems.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listTeamBItems.Font = new Font("Microsoft Sans Serif", 14.25F);
            listTeamBItems.FormattingEnabled = true;
            listTeamBItems.Location = new Point(349, 47);
            listTeamBItems.Name = "listTeamBItems";
            listTeamBItems.SelectionMode = SelectionMode.None;
            listTeamBItems.Size = new Size(331, 220);
            listTeamBItems.TabIndex = 3;
            // 
            // btnConfirm
            // 
            btnConfirm.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnConfirm.BackColor = Color.FromArgb(128, 255, 128);
            btnConfirm.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.Location = new Point(12, 293);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(668, 80);
            btnConfirm.TabIndex = 4;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancel.BackColor = Color.FromArgb(255, 128, 128);
            btnCancel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(12, 379);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(668, 80);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmTradeApproval
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 472);
            ControlBox = false;
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(listTeamBItems);
            Controls.Add(listTeamAItems);
            Controls.Add(tbTeamB);
            Controls.Add(tbTeamA);
            MaximumSize = new Size(708, 1000);
            MinimumSize = new Size(708, 420);
            Name = "frmTradeApproval";
            Text = "Trade Approval";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbTeamA;
        private TextBox tbTeamB;
        private ListBox listTeamAItems;
        private ListBox listTeamBItems;
        private Button btnConfirm;
        private Button btnCancel;
    }
}