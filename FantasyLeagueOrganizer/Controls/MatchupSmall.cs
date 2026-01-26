using FantasyLeagueOrganizer.Forms;
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
    public partial class MatchupSmall : UserControl
    {
        public MatchupRegularSeason Matchup;
        private LeagueDbContext Context;

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Action DatabaseDataChanged { get; set; }

		private int CenterRegionWidth = 100;
        public MatchupSmall(LeagueDbContext context, MatchupRegularSeason matchup)
        {
            InitializeComponent();

            Context = context;

            Matchup = matchup;
            if (matchup.IsBye)
            {
                btnPlay.Enabled = false;
			}
            RefreshUI();
        }

        public void RefreshUI()
        {
            tbTeamA.BackColor = Matchup.TeamA.Color;
            tbTeamA.Text = Matchup.TeamA.Name;
            lblTeamARecord.Text = Matchup.TeamA.RecordString;
            lblWeek.Text = $"Week {Matchup.Week + 1}";

            if (Matchup.IsBye)
            {
                tbTeamB.BackColor = Color.LightGray;
                tbTeamB.Text = "BYE";
                lblTeamBRecord.Text = "N/A";
            }
            else
            {
                tbTeamB.BackColor = Matchup.TeamB.Color;
                tbTeamB.Text = Matchup.TeamB.Name;
                lblTeamBRecord.Text = Matchup.TeamB.RecordString;
            }

            if (Matchup.Result == MatchupResult.Tie)
            {
                lblTeamAResult.Text = "T";
                lblTeamAResult.ForeColor = Color.DarkBlue;
                lblTeamBResult.Text = "T";
                lblTeamBResult.ForeColor = Color.DarkBlue;
            }
            else if (Matchup.Result == MatchupResult.AWon)
            {
                lblTeamAResult.Text = "W";
                lblTeamAResult.ForeColor = Color.DarkGreen;
                lblTeamBResult.Text = "L";
                lblTeamBResult.ForeColor = Color.DarkRed;
            }
            else if (Matchup.Result == MatchupResult.BWon)
            {
                lblTeamAResult.Text = "L";
                lblTeamAResult.ForeColor = Color.DarkRed;
                lblTeamBResult.Text = "W";
                lblTeamBResult.ForeColor = Color.DarkGreen;
            }
            else
            {
                lblTeamAResult.Text = "";
                lblTeamBResult.Text = "";
            }

            lblScore.Text = Matchup.ScoreString;
        }

        private void MatchupSmall_Resize(object sender, EventArgs e)
        {
            lblWeek.Left = (Width - lblWeek.Width) / 2;
            lblVS.Left = (Width - lblVS.Width) / 2;

            btnPlay.Left = (Width - btnPlay.Width) / 2;

            tbTeamA.Width = (Width - CenterRegionWidth - tbTeamA.Margin.Left - tbTeamB.Margin.Right) / 2;
            tbTeamA.Left = tbTeamA.Margin.Left;

            tbTeamB.Width = tbTeamA.Width;
            tbTeamB.Left = Width - tbTeamB.Margin.Right - tbTeamB.Width;

            lblTeamAResult.Left = tbTeamA.Right;
            lblTeamBResult.Left = tbTeamB.Left - lblTeamBResult.Width;

            lblScore.Left = (Width - lblScore.Width) / 2;

            lblTeamARecord.Left = lblTeamARecord.Margin.Left;
            lblTeamBRecord.Left = Width - lblTeamBRecord.Margin.Right - lblTeamBRecord.Width;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (!Matchup.TeamA.LineupIsValid)
            {
                MessageBox.Show($"{Matchup.TeamA.Name}'s lineup is not set", "Lineup not set", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

			if (!Matchup.TeamB.LineupIsValid)
			{
				MessageBox.Show($"{Matchup.TeamB.Name}'s lineup is not set", "Lineup not set", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			var playForm = new frmPlayMatchup(Context, Matchup);
            playForm.DatabaseDataChanged = ExternalDataChanged;
            playForm.ShowDialog();
            RefreshUI();
		}

        private void ExternalDataChanged()
        {
            //Reload the matchup from the DB
            Matchup = Context.Leagues.Single().Matchups.Where(m => m.Id == Matchup.Id).Single();
            if (Matchup != null)
            {
                RefreshUI();
            }

            DatabaseDataChanged.Invoke();
        }
    }
}
