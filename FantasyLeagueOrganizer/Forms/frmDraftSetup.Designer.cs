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
            nudNumRounds = new NumericUpDown();
            label1 = new Label();
            radSnake = new RadioButton();
            panel1 = new Panel();
            radLinear = new RadioButton();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudNumRounds).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // listDraftOrder
            // 
            listDraftOrder.FormattingEnabled = true;
            listDraftOrder.Location = new Point(129, 12);
            listDraftOrder.Name = "listDraftOrder";
            listDraftOrder.Size = new Size(234, 199);
            listDraftOrder.TabIndex = 0;
            // 
            // bnMoveUp
            // 
            bnMoveUp.Location = new Point(369, 12);
            bnMoveUp.Name = "bnMoveUp";
            bnMoveUp.Size = new Size(111, 23);
            bnMoveUp.TabIndex = 1;
            bnMoveUp.Text = "Move Up";
            bnMoveUp.UseVisualStyleBackColor = true;
            bnMoveUp.Click += bnMoveUp_Click;
            // 
            // btnMoveDown
            // 
            btnMoveDown.Location = new Point(369, 41);
            btnMoveDown.Name = "btnMoveDown";
            btnMoveDown.Size = new Size(111, 23);
            btnMoveDown.TabIndex = 2;
            btnMoveDown.Text = "Move Down";
            btnMoveDown.UseVisualStyleBackColor = true;
            btnMoveDown.Click += btnMoveDown_Click;
            // 
            // btnProceed
            // 
            btnProceed.Location = new Point(252, 302);
            btnProceed.Name = "btnProceed";
            btnProceed.Size = new Size(111, 23);
            btnProceed.TabIndex = 3;
            btnProceed.Text = "Proceed";
            btnProceed.UseVisualStyleBackColor = true;
            btnProceed.Click += btnProceed_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(129, 302);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(111, 23);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnRandomize
            // 
            btnRandomize.Location = new Point(12, 12);
            btnRandomize.Name = "btnRandomize";
            btnRandomize.Size = new Size(111, 23);
            btnRandomize.TabIndex = 5;
            btnRandomize.Text = "Randomize";
            btnRandomize.UseVisualStyleBackColor = true;
            btnRandomize.Click += btnRandomize_Click;
            // 
            // btnAlphabetical
            // 
            btnAlphabetical.Location = new Point(12, 41);
            btnAlphabetical.Name = "btnAlphabetical";
            btnAlphabetical.Size = new Size(111, 23);
            btnAlphabetical.TabIndex = 6;
            btnAlphabetical.Text = "Alphabetical";
            btnAlphabetical.UseVisualStyleBackColor = true;
            btnAlphabetical.Click += btnAlphabetical_Click;
            // 
            // nudNumRounds
            // 
            nudNumRounds.Location = new Point(129, 217);
            nudNumRounds.Name = "nudNumRounds";
            nudNumRounds.Size = new Size(234, 23);
            nudNumRounds.TabIndex = 7;
            nudNumRounds.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 219);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 8;
            label1.Text = "Number of Rounds";
            // 
            // radSnake
            // 
            radSnake.AutoSize = true;
            radSnake.Checked = true;
            radSnake.Location = new Point(3, 3);
            radSnake.Name = "radSnake";
            radSnake.Size = new Size(56, 19);
            radSnake.TabIndex = 9;
            radSnake.TabStop = true;
            radSnake.Text = "Snake";
            radSnake.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(radLinear);
            panel1.Controls.Add(radSnake);
            panel1.Location = new Point(129, 246);
            panel1.Name = "panel1";
            panel1.Size = new Size(112, 50);
            panel1.TabIndex = 10;
            // 
            // radLinear
            // 
            radLinear.AutoSize = true;
            radLinear.Location = new Point(3, 28);
            radLinear.Name = "radLinear";
            radLinear.Size = new Size(57, 19);
            radLinear.TabIndex = 10;
            radLinear.Text = "Linear";
            radLinear.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 253);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 11;
            label2.Text = "Draft Style";
            // 
            // frmDraftSetup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 336);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(nudNumRounds);
            Controls.Add(btnAlphabetical);
            Controls.Add(btnRandomize);
            Controls.Add(btnCancel);
            Controls.Add(btnProceed);
            Controls.Add(btnMoveDown);
            Controls.Add(bnMoveUp);
            Controls.Add(listDraftOrder);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmDraftSetup";
            Text = "Draft Setup";
            ((System.ComponentModel.ISupportInitialize)nudNumRounds).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listDraftOrder;
        private Button bnMoveUp;
        private Button btnMoveDown;
        private Button btnProceed;
        private Button btnCancel;
        private Button btnRandomize;
        private Button btnAlphabetical;
        private NumericUpDown nudNumRounds;
        private Label label1;
        private RadioButton radSnake;
        private Panel panel1;
        private RadioButton radLinear;
        private Label label2;
    }
}