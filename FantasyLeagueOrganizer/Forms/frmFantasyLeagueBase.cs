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
    public partial class frmFantasyLeagueBase : Form
    {
        protected League? League;
		protected LeagueDbContext Context;

		/// <summary>
		/// Invoked when the form has become aware that data has been changed in the database
		/// </summary>
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Action DatabaseDataChanged { get; set; }

		public frmFantasyLeagueBase()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Stores the provided context and uses it to load the league
		/// </summary>
		/// <param name="context"></param>
		public frmFantasyLeagueBase(LeagueDbContext context) : this()
        {
            Context = context;
			LoadLeagueFromDatabase();
        }

		protected virtual void LoadLeagueFromDatabase()
		{
			if (League == null)
			{
				League = DatabaseHelpers.LoadLeague(Context);
			}
			else
			{
				Context.Entry(League).Reload();
			}
		}

		protected virtual void RefreshUI()
		{
			throw new NotImplementedException("Derived form must implement RefreshUI()");
		}

        protected virtual void ExternalDataChanged()
        {
			LoadLeagueFromDatabase();
			RefreshUI();
			DatabaseDataChanged?.Invoke();
        }
    }
}
