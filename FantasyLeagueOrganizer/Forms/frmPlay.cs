using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FantasyLeagueOrganizer.Forms
{
    public partial class frmPlay : frmFantasyLeagueBase
    {
        public frmPlay(LeagueDbContext context) : base(context)
        {
            InitializeComponent();

            Setup();
        }

        public void Setup()
        {

        }

        protected override void RefreshUI()
        {
            
        }
    }
}
