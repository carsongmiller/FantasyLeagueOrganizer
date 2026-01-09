using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FantasyLeagueOrganizer.controls
{
    public partial class LineupEditor : UserControl
    {
        private Team Team;
        public LineupEditor()
        {
            InitializeComponent();
        }

        public void SetTeam(Team team)
        {
            Team = team;

            foreach (var category in team.League.Categories)
            {
                var newLineupCategorySelector = new LineupCategorySelector(team, category);
                flowLayoutPanel1.Controls.Add(newLineupCategorySelector);
			}

            foreach (LineupCategorySelector control in flowLayoutPanel1.Controls)
            {
                control.ItemCheckedChanged += Control_ItemCheckedChanged;
			}
        }

        private void Control_ItemCheckedChanged(object? sender, LineupCategorySelector.ItemCheckedChangedEventArgs e)
        {
            foreach (LineupCategorySelector control in flowLayoutPanel1.Controls)
            {
                if (e.CategoryOld == control.Category.Id)
                {
                    control.UpdateLists();
                }
				
            }
        }

        public void UpdateAllCategories()
        {
            foreach (LineupCategorySelector control in flowLayoutPanel1.Controls)
            {
                control.Setup();
			}
		}
    }
}
