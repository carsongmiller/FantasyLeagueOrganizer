namespace FantasyLeagueOrganizer.controls
{
    partial class LineupViewer
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
            grpLineupViewer = new GroupBox();
            grpLineupViewer.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 19);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(873, 390);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // grpLineupViewer
            // 
            grpLineupViewer.Controls.Add(flowLayoutPanel1);
            grpLineupViewer.Dock = DockStyle.Fill;
            grpLineupViewer.Location = new Point(0, 0);
            grpLineupViewer.Name = "grpLineupViewer";
            grpLineupViewer.Size = new Size(879, 412);
            grpLineupViewer.TabIndex = 1;
            grpLineupViewer.TabStop = false;
            grpLineupViewer.Text = "Lineup Viewer - Team Name";
            // 
            // LineupViewer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(grpLineupViewer);
            Name = "LineupViewer";
            Size = new Size(879, 412);
            grpLineupViewer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox grpLineupViewer;
    }
}
