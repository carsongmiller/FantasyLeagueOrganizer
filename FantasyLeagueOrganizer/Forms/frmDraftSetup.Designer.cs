namespace FantasyLeagueOrganizer.Forms
{
    partial class frmDraftSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDraftSetup));
            listDraftOrder = new ListBox();
            bnMoveUp = new Button();
            btnMoveDown = new Button();
            btnProceed = new Button();
            btnCancel = new Button();
            btnRandomize = new Button();
            btnAlphabetical = new Button();
            SuspendLayout();
            // 
            // listDraftOrder
            // 
            listDraftOrder.FormattingEnabled = true;
            listDraftOrder.Location = new Point(261, 98);
            listDraftOrder.Name = "listDraftOrder";
            listDraftOrder.Size = new Size(234, 199);
            listDraftOrder.TabIndex = 0;
            // 
            // bnMoveUp
            // 
            bnMoveUp.Location = new Point(501, 98);
            bnMoveUp.Name = "bnMoveUp";
            bnMoveUp.Size = new Size(111, 23);
            bnMoveUp.TabIndex = 1;
            bnMoveUp.Text = "Move Up";
            bnMoveUp.UseVisualStyleBackColor = true;
            bnMoveUp.Click += bnMoveUp_Click;
            // 
            // btnMoveDown
            // 
            btnMoveDown.Location = new Point(501, 127);
            btnMoveDown.Name = "btnMoveDown";
            btnMoveDown.Size = new Size(111, 23);
            btnMoveDown.TabIndex = 2;
            btnMoveDown.Text = "Move Down";
            btnMoveDown.UseVisualStyleBackColor = true;
            btnMoveDown.Click += btnMoveDown_Click;
            // 
            // btnProceed
            // 
            btnProceed.Location = new Point(384, 415);
            btnProceed.Name = "btnProceed";
            btnProceed.Size = new Size(111, 23);
            btnProceed.TabIndex = 3;
            btnProceed.Text = "Proceed";
            btnProceed.UseVisualStyleBackColor = true;
            btnProceed.Click += btnProceed_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(267, 415);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(111, 23);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnRandomize
            // 
            btnRandomize.Location = new Point(144, 98);
            btnRandomize.Name = "btnRandomize";
            btnRandomize.Size = new Size(111, 23);
            btnRandomize.TabIndex = 5;
            btnRandomize.Text = "Randomize";
            btnRandomize.UseVisualStyleBackColor = true;
            btnRandomize.Click += btnRandomize_Click;
            // 
            // btnAlphabetical
            // 
            btnAlphabetical.Location = new Point(144, 127);
            btnAlphabetical.Name = "btnAlphabetical";
            btnAlphabetical.Size = new Size(111, 23);
            btnAlphabetical.TabIndex = 6;
            btnAlphabetical.Text = "Alphabetical";
            btnAlphabetical.UseVisualStyleBackColor = true;
            btnAlphabetical.Click += btnAlphabetical_Click;
            // 
            // frmDraftSetup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(btnAlphabetical);
            Controls.Add(btnRandomize);
            Controls.Add(btnCancel);
            Controls.Add(btnProceed);
            Controls.Add(btnMoveDown);
            Controls.Add(bnMoveUp);
            Controls.Add(listDraftOrder);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmDraftSetup";
            Text = "Draft Setup";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listDraftOrder;
        private Button bnMoveUp;
        private Button btnMoveDown;
        private Button btnProceed;
        private Button btnCancel;
        private Button btnRandomize;
        private Button btnAlphabetical;
    }
}