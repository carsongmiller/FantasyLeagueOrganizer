using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FantasyLeagueOrganizer
{
    public partial class LineupCategoryStatus : UserControl
    {
        private Team Team;
        private Category Category;
        public LineupCategoryStatus(Team team, Category category)
        {
            InitializeComponent();

            Team = team;
            Category = category;
            tbStatus.Text = $"{category.Name} ({category.NumInLineup(team)}/{category.RequiredCount})";
        }

        public void Refresh()
        {
            if (Category.SatisfiedByTeam(Team))
            {
                tbStatus.BackColor = Color.LightGreen;
            }
            else
            {
                tbStatus.BackColor = Color.IndianRed;
            }
        }
    }
}
