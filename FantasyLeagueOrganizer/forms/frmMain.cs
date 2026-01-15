using FantasyLeagueOrganizer.DatabseClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FantasyLeagueOrganizer.Forms
{
    public partial class frmMain : Form
    {
        private League? League;
        public frmMain()
        {
            InitializeComponent();

            League = DatabaseHelpers.LoadLeague();
            if (League != null)
            {
				RefreshUI();
			}   
		}

        public void RefreshUI()
        {
            leagueSummary1.SetLeague(League);
        }

        private void adminControlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
			var adminForm = new frmAdmin(League);
			adminForm.Show();
		}

        private void btnBeginDraft_Click(object sender, EventArgs e)
        {
            var draftSetupForm = new frmDraftSetup(League);
            draftSetupForm.ShowDialog();
        }

        private void reloadLeagueToolStripMenuItem_Click(object sender, EventArgs e)
        {
			League = DatabaseHelpers.LoadLeague();
            if (League != null)
            {
                RefreshUI();
			}
		}
    }
}
