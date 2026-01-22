namespace FantasyLeagueOrganizer.controls
{
    partial class LineupEditor
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
            grpLineupEditor = new GroupBox();
            grpLineupEditor.SuspendLayout();
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
            // grpLineupEditor
            // 
            grpLineupEditor.Controls.Add(flowLayoutPanel1);
            grpLineupEditor.Dock = DockStyle.Fill;
            grpLineupEditor.Location = new Point(0, 0);
            grpLineupEditor.Name = "grpLineupEditor";
            grpLineupEditor.Size = new Size(879, 412);
            grpLineupEditor.TabIndex = 1;
            grpLineupEditor.TabStop = false;
            grpLineupEditor.Text = "Lineup Editor - Team Name";
            // 
            // LineupEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(grpLineupEditor);
            Name = "LineupEditor";
            Size = new Size(879, 412);
            grpLineupEditor.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox grpLineupEditor;
    }
}
