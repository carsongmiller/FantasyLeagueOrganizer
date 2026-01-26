using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FantasyLeagueOrganizer.Models;

namespace FantasyLeagueOrganizer.Controls
{
    public partial class LineupChecklist : UserControl
    {
        public Team Team;
        public LineupChecklist()
        {
            InitializeComponent();
        }

        public void SetTeam(Team team)
        {
            Team = team;
            foreach (var category in Team.League.Categories)
            {
                var newStatusControl = new LineupCategoryStatus(Team, category);
                newStatusControl.Refresh();
                flowLayoutPanel1.Controls.Add(newStatusControl);
                newStatusControl.Width = Math.Max(0, flowLayoutPanel1.ClientSize.Width - flowLayoutPanel1.Margin.Horizontal - newStatusControl.Padding.Horizontal);
			}
		}
    }
}
