using FantasyLeagueOrganizer.Controls;
using FantasyLeagueOrganizer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FantasyLeagueOrganizer.Forms
{
    public partial class frmPlayMatchup : frmFantasyLeagueBase
    {
        public MatchupRegularSeason Matchup;
        private System.Timers.Timer tmrPlay;
        private int categoriesRevealed = 0;

        public frmPlayMatchup(LeagueDbContext context, MatchupRegularSeason matchup) : base(context)
        {
            InitializeComponent();
            Matchup = matchup;

            Setup();

            tmrPlay = new();
            tmrPlay.Interval = 1000;
            tmrPlay.AutoReset = false;
            tmrPlay.Elapsed += TmrPlay_Elapsed;
        }

        private void TmrPlay_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
        {
            categoriesRevealed++;

            Invoke((MethodInvoker)delegate
            {
                RevealNext();
            });

			if (Matchup.Result == MatchupResult.Incomplete)
            {
				//if (categoriesRevealed == Matchup.League.Categories.Sum(c => c.RequiredCount) - 1 && Math.Abs(Matchup.ScoreA - Matchup.ScoreB) <= 10)
				//{
    //                tmrPlay.Interval = 3000;
				//}
				tmrPlay.Start();
            }
        }

        private void RevealNext()
        {
            categoriesRevealed++;
			var controls = flowLayoutPanel1.Controls.OfType<MatchupItemPair>();

			for (int i = 0; i < controls.Count(); i++)
			{
				var control = controls.ElementAt(i);
				if (!control.Revealed)
				{
					control.Reveal();
					UpdateScore(control.ScoreA, control.ScoreB);
					if (i == controls.Count() - 1)
					{
						GameCompleted();
					}
					break;
				}
			}
		}

        public void Setup()
        {
            Text = $"Play Matchup - Week {Matchup.Week}: {Matchup.TeamA.Name} vs {Matchup.TeamB.Name}";
            tbTeamA.Text = $" {Matchup.TeamA.Name}";
            tbTeamA.BackColor = Matchup.TeamA.Color;

            tbTeamB.Text = $"{Matchup.TeamB.Name} ";
            tbTeamB.BackColor = Matchup.TeamB.Color;

            foreach (var category in Matchup.League.Categories)
            {
                for (int i = 0; i < category.RequiredCount; i++)
                {
                    var itemA = Matchup.TeamA.Lineup.Where(i => i.AssignedCategoryId == category.Id).ElementAtOrDefault(i);
                    var itemB = Matchup.TeamB.Lineup.Where(i => i.AssignedCategoryId == category.Id).ElementAtOrDefault(i);
                    var scoreA = Matchup.RankingProvider.GetItemScore(itemA);
                    var scoreB = Matchup.RankingProvider.GetItemScore(itemB);

                    var newMatchupPairControl = new MatchupItemPair(category, itemA, itemB, scoreA, scoreB);
                    newMatchupPairControl.Width = flowLayoutPanel1.ClientSize.Width - flowLayoutPanel1.Padding.Horizontal - newMatchupPairControl.Margin.Horizontal;
                    flowLayoutPanel1.Controls.Add(newMatchupPairControl);
                }
            }
        }

        private void btnRevealNext_Click(object sender, EventArgs e)
        {
            RevealNext();
        }

        private void GameCompleted()
        {
            if (Matchup.ScoreA > Matchup.ScoreB)
            {
                Matchup.Result = MatchupResult.AWon;
            }
            else if (Matchup.ScoreB > Matchup.ScoreA)
            {
                Matchup.Result = MatchupResult.BWon;
            }
            else
            {
                Matchup.Result = MatchupResult.Tie;
            }

            RevealWinner();

            Context.SaveChanges();
            DatabaseDataChanged.Invoke();
        }

        private void UpdateScore(int addScoreA, int addScoreB)
        {
            Matchup.ScoreA += addScoreA;
            Matchup.ScoreB += addScoreB;
            lblScoreA.Text = Matchup.ScoreA.ToString();
            lblScoreB.Text = Matchup.ScoreB.ToString();
        }

        private void RevealWinner()
        {
            var result = Matchup.Result;
            if (result == MatchupResult.AWon)
            {
                lblScoreA.BackColor = Color.LightGreen;
                lblScoreB.BackColor = Color.IndianRed;
            }
            else if (result == MatchupResult.BWon)
            {
                lblScoreA.BackColor = Color.IndianRed;
                lblScoreB.BackColor = Color.LightGreen;
            }
            else if (result == MatchupResult.Tie)
            {
                lblScoreA.BackColor = Color.LightBlue;
                lblScoreB.BackColor = Color.LightBlue;
            }
        }

        private void flowLayoutPanel1_Resize(object sender, EventArgs e)
        {
            foreach (var control in flowLayoutPanel1.Controls.OfType<MatchupItemPair>())
            {
                control.Width = flowLayoutPanel1.ClientSize.Width - flowLayoutPanel1.Padding.Horizontal - control.Margin.Horizontal;
            }
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            var w = panel1.ClientSize.Width;

            lblVS.Left = (w - lblVS.Width) / 2;

            lblScoreA.Left = lblVS.Left - lblScoreA.Margin.Right - lblScoreA.Width;

            lblScoreB.Left = lblVS.Right + lblScoreB.Margin.Left;

            tbTeamA.Left = tbTeamA.Margin.Left;
            tbTeamA.Width = lblScoreA.Left - tbTeamA.Margin.Right - tbTeamA.Left;

            tbTeamB.Left = lblScoreB.Right + tbTeamB.Margin.Left;
            tbTeamB.Width = w - tbTeamB.Margin.Right - tbTeamB.Left;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            tmrPlay.Start();
        }
    }
}
