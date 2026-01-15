using FantasyLeagueOrganizer.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FantasyLeagueOrganizer.controls
{
    public partial class MatchupSmall : UserControl
    {
        public Matchup Matchup;

        private int CenterRegionWidth = 100;
        public MatchupSmall(Matchup matchup)
        {
            InitializeComponent();

            Matchup = matchup;
            if (matchup.IsBye)
            {
                btnPlay.Enabled = false;
			}
            Update();
        }

        public void Update()
        {
            tbTeamA.BackColor = Matchup.TeamA.Color;
            tbTeamA.Text = Matchup.TeamA.Name;
            lblTeamARecord.Text = Matchup.TeamA.RecordString;
            lblWeek.Text = $"Week {Matchup.Week}";

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

            if (Matchup.Result == Matchup.MatchupResult.Tie)
            {
                lblTeamAResult.Text = "T";
                lblTeamAResult.ForeColor = Color.DarkBlue;
                lblTeamBResult.Text = "T";
                lblTeamBResult.ForeColor = Color.DarkBlue;
            }
            else if (Matchup.Result == Matchup.MatchupResult.AWon)
            {
                lblTeamAResult.Text = "W";
                lblTeamAResult.ForeColor = Color.DarkGreen;
                lblTeamBResult.Text = "L";
                lblTeamBResult.ForeColor = Color.DarkRed;
            }
            else if (Matchup.Result == Matchup.MatchupResult.BWon)
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
            var playForm = new frmPlayMatchup(Matchup);
            playForm.ShowDialog();
            Update();
		}
    }
}
