namespace FantasyLeagueOrganizer
{
    partial class LineupChecklist
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
            label1 = new Label();
            tbLineupStatus = new TextBox();
            grpChecklist = new GroupBox();
            grpChecklist.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(3, 51);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(297, 183);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 25);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 1;
            label1.Text = "Lineup OK: ";
            // 
            // tbLineupStatus
            // 
            tbLineupStatus.Location = new Point(81, 22);
            tbLineupStatus.Name = "tbLineupStatus";
            tbLineupStatus.ReadOnly = true;
            tbLineupStatus.Size = new Size(100, 23);
            tbLineupStatus.TabIndex = 2;
            tbLineupStatus.Text = "No";
            // 
            // grpChecklist
            // 
            grpChecklist.Controls.Add(flowLayoutPanel1);
            grpChecklist.Controls.Add(tbLineupStatus);
            grpChecklist.Controls.Add(label1);
            grpChecklist.Dock = DockStyle.Fill;
            grpChecklist.Location = new Point(0, 0);
            grpChecklist.Name = "grpChecklist";
            grpChecklist.Size = new Size(303, 237);
            grpChecklist.TabIndex = 3;
            grpChecklist.TabStop = false;
            grpChecklist.Text = "Lineup Checklist";
            // 
            // LineupChecklist
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(grpChecklist);
            Name = "LineupChecklist";
            Size = new Size(303, 237);
            grpChecklist.ResumeLayout(false);
            grpChecklist.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private TextBox tbLineupStatus;
        private GroupBox grpChecklist;
    }
}
