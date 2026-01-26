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
    public partial class MatchupItemPair : UserControl
    {
        private int centerGapWidth = 300;
        public int ScoreA;
        public int ScoreB;

        public bool Revealed { get; private set; } = false;

        public MatchupItemPair(Category category, Item itemA, Item itemB, int scoreA, int scoreB)
        {
            InitializeComponent();

            ScoreA = scoreA;
            ScoreB = scoreB;

            lblCategory.Text = category.Name;
            tbItemA.Text = $" {itemA.Name}";
            tbItemB.Text = $"{itemB.Name} ";

            tbItemA.BackColor = itemA.Team.Color;
            tbItemB.BackColor = itemB.Team.Color;
        }

        public void Reveal()
        {
            tbScoreA.Text = ScoreA.ToString();
            tbScoreB.Text = ScoreB.ToString();
            Revealed = true;
        }

        private void MatchupItemPair_Resize(object sender, EventArgs e)
        {
            lblCategory.Width = centerGapWidth;
            lblCategory.Left = (Width - lblCategory.Width) / 2;

            tbScoreA.Left = lblCategory.Left - tbScoreA.Margin.Right - tbScoreA.Width;

			tbItemA.Left = tbItemA.Margin.Left;
            tbItemA.Width = tbScoreA.Left - tbItemA.Margin.Right - tbItemA.Left;

            tbScoreB.Left = lblCategory.Right + tbScoreB.Margin.Left;

            tbItemB.Left = tbScoreB.Right + tbItemB.Margin.Left;
            tbItemB.Width = Width - tbItemB.Margin.Right - tbItemB.Left;
		}
    }
}
