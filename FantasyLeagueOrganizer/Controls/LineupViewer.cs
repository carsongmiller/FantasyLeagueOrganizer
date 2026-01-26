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
    public partial class LineupViewer : UserControl
    {
        private Team Team;
        public LineupViewer()
        {
            InitializeComponent();
        }

        public void SetTeam(Team team)
        {
            flowLayoutPanel1.Controls.Clear();

            Team = team;

            grpLineupViewer.Text = $"Lineup Viewer - {Team.Name}";

            foreach (var category in team.League.Categories)
            {
                var newLineupCategoryViewer = new LineupCategoryViewer(team, category);
                flowLayoutPanel1.Controls.Add(newLineupCategoryViewer);
			}
        }

        public void UpdateAllCategories()
        {
            foreach (LineupCategoryViewer control in flowLayoutPanel1.Controls)
            {
                control.RefreshUI();
			}
		}
    }
}
