namespace FantasyLeagueOrganizer.controls
{
    partial class LeagueSummary
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            grpLeagueSummary = new GroupBox();
            grpLeagueSummary.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(3, 19);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(388, 246);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // grpLeagueSummary
            // 
            grpLeagueSummary.Controls.Add(flowLayoutPanel1);
            grpLeagueSummary.Dock = DockStyle.Fill;
            grpLeagueSummary.Location = new Point(0, 0);
            grpLeagueSummary.Name = "grpLeagueSummary";
            grpLeagueSummary.Size = new Size(394, 268);
            grpLeagueSummary.TabIndex = 1;
            grpLeagueSummary.TabStop = false;
            grpLeagueSummary.Text = "League Summary";
            // 
            // LeagueSummary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(grpLeagueSummary);
            Name = "LeagueSummary";
            Size = new Size(394, 268);
            grpLeagueSummary.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox grpLeagueSummary;
    }
}
