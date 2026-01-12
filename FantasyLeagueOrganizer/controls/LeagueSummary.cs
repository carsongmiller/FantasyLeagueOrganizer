using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FantasyLeagueOrganizer.controls
{
    public partial class LeagueSummary : UserControl
    {
        League League;
        public LeagueSummary()
        {
            InitializeComponent();
        }

        public void SetLeague(League league)
        {
            League = league;

            flowLayoutPanel1.Controls.Clear();

			foreach (var team in League.Teams)
            {
                var newTeamDisplaySmall = new TeamDisplaySmall(team);
                flowLayoutPanel1.Controls.Add(newTeamDisplaySmall);
				//newTeamDisplaySmall.Width = Math.Max(0, flowLayoutPanel1.ClientSize.Width - flowLayoutPanel1.Margin.Horizontal - newTeamDisplaySmall.Padding.Horizontal);
				//newTeamDisplaySmall.Anchor  = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			}

            Update();
        }

        public void Update()
        {
			//get list of teams from the controls currently in the flow layout panel
            var teamsWithExistingControls = flowLayoutPanel1.Controls.OfType<TeamDisplaySmall>().Select(t => t.Team).ToList();


            //add a contorl to the flow layout panel for any teams in the league that don't have a control yet
            foreach (var team in League.Teams)
            {
                if (!teamsWithExistingControls.Contains(team))
                {
                    var newTeamDisplaySmall = new TeamDisplaySmall(team);
                    flowLayoutPanel1.Controls.Add(newTeamDisplaySmall);
                }
            }

            //Now update all
			foreach (var teamDisplay in flowLayoutPanel1.Controls.OfType<TeamDisplaySmall>())
            {
                teamDisplay.Update();
            }
        }
    }
}
