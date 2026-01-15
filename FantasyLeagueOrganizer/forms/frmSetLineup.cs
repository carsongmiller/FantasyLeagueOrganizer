using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FantasyLeagueOrganizer.Forms
{
    public partial class frmModifyLineup : Form
    {
        private Team Team;

        public frmModifyLineup(Team team)
        {
            InitializeComponent();

            Team = team;
            tbTeamName.Text = team.Name;
            tbTeamName.BackColor = team.Color;

            lineupEditor1.SetTeam(team);
            freeAgentsLarge1.SetLeague(team.League);
		}

        public void frmSetLineup_Shown(object sender, EventArgs e)
        {
            ActiveControl = null;
        }

		public void btnAddToTeam_Click(object sender, EventArgs e)
        {
            var selectedItem = freeAgentsLarge1.SelectedItem;
            if (selectedItem == null)
            {
                return;
            }

            selectedItem.AddToTeam(Team);

            lineupEditor1.UpdateAllCategories();
            freeAgentsLarge1.Update();
		}
	}
}
