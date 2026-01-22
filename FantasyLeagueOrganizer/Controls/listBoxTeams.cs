using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FantasyLeagueOrganizer.Controls
{
    public partial class listBoxTeams : ListBox
    {
        public listBoxTeams()
        {
            InitializeComponent();

			DrawMode = DrawMode.OwnerDrawFixed;
			DisplayMember = nameof(Team.Name);
			UpdateItemHeight();
		}

		protected override void OnFontChanged(EventArgs e) 
		{ 
			base.OnFontChanged(e);
			UpdateItemHeight(); 
		}

		private void UpdateItemHeight()
		{ 
			// a little padding so it doesn’t feel cramped
			ItemHeight = Font.Height + 4; 
		}

		protected override void OnDrawItem(DrawItemEventArgs e)
        {
			if (e.Index < 0 || e.Index >= Items.Count)
				return;

			var teamToDraw = (Team)Items[e.Index];

			// Get the item text
			string text = teamToDraw.Name;

			var foreColor = Color.Black;
			var backColor = teamToDraw.Color;

			if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
			{
				foreColor = SystemColors.HighlightText;
				backColor = SystemColors.Highlight;
			}

			// Draw background
			using (var bg = new SolidBrush(backColor))
			{
				e.Graphics.FillRectangle(bg, e.Bounds);
			}

			// Measure text height for current font
			Size textSize = TextRenderer.MeasureText(e.Graphics, text, e.Font); 

			// Compute vertical offset to center the text
			int verticalOffset = e.Bounds.Top + (e.Bounds.Height - textSize.Height) / 2;

			// Draw text using adjusted rectangle
			Rectangle textRect = new Rectangle(e.Bounds.Left, verticalOffset, e.Bounds.Width, textSize.Height);

			// Draw text
			TextRenderer.DrawText(
				e.Graphics,
				text,
				e.Font,
				textRect,
				foreColor,
				TextFormatFlags.Left
			);

			// Draw focus rectangle if needed
			e.DrawFocusRectangle();
		}
    }
}
