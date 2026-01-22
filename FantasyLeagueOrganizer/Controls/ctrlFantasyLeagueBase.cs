using FantasyLeagueOrganizer.DatabseClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FantasyLeagueOrganizer.Controls
{
    public partial class ctrlFantasyLeagueBase : UserControl
    {
		protected LeagueDbContext Context;

		/// <summary>
		/// Invoked when the form has become aware that data has been changed in the database
		/// </summary>
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Action DatabaseDataChanged { get; set; }

		public ctrlFantasyLeagueBase()
        {
            InitializeComponent();
        }

		public ctrlFantasyLeagueBase(LeagueDbContext context) : this()
		{
			Context = context;
		}

		protected virtual void LoadDataFromDatabase()
		{
			throw new NotImplementedException();
		}

		public virtual void RefreshUI()
		{
			throw new NotImplementedException("Derived form must implement RefreshUI()");
		}

		protected virtual void ExternalDataChanged()
		{
			LoadDataFromDatabase();
			RefreshUI();
			DatabaseDataChanged?.Invoke();
		}
	}
}
