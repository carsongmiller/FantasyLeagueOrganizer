using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FantasyLeagueOrganizer.Forms
{
    public partial class frmDraft : Form
    {
        public League League;
        public frmDraft(League league)
        {
            InitializeComponent();

            League = league;
            Setup();
        }

        private void Setup()
        {
            freeAgentsLarge1.SetLeague(League);
        }
    }
}
