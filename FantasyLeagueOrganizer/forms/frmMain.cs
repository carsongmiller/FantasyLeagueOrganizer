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
    public partial class frmMain : frmFantasyLeagueBase
    {
        public frmMain()
        {
            InitializeComponent();

            Context = new();
            base.LoadLeagueFromDatabase();

            RefreshUI();

            leagueSummary1.DatabaseDataChanged = ExternalDataChanged;
		}

        protected override void RefreshUI()
        {
            if (League == null) return;
            leagueSummary1.Setup(Context);
        }

        private void adminControlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
			var adminForm = new frmAdmin(Context);
            adminForm.DatabaseDataChanged = ExternalDataChanged;
			adminForm.Show();
		}

        private void btnBeginDraft_Click(object sender, EventArgs e)
        {
            var draftSetupForm = new frmDraftSetup(Context);
            draftSetupForm.DatabaseDataChanged = ExternalDataChanged;
            draftSetupForm.ShowDialog();
        }

        private void reloadLeagueToolStripMenuItem_Click(object sender, EventArgs e)
        {
			League = DatabaseHelpers.LoadLeague(Context);
            if (League != null)
            {
                RefreshUI();
			}
		}
    }
}
