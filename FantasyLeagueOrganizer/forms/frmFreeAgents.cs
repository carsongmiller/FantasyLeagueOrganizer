using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FantasyLeagueOrganizer.Forms
{
    public partial class frmFreeAgents : Form
    {
        public League League;
        public frmFreeAgents(League league)
        {
            InitializeComponent();

            listTeams.DisplayMember = nameof(Team.Name);

            League = league;
            Setup();
        }

        public void Setup()
        {
            freeAgentsLarge1.SetLeague(League);

            foreach (var team in League.Teams)
            {
				if (team.Name == "bye") continue; // skip bye teams
				listTeams.Items.Add(team);
            }
        }

        private void listTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            teamDisplaySmall1.Team = (Team)listTeams.SelectedItem;
            teamDisplaySmall1.Update();
		}
    }
}
