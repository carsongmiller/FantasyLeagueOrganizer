using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;
using FantasyLeagueOrganizer.Models;

namespace FantasyLeagueOrganizer.Controls
{
    public partial class ctrlBracketMatchup : ctrlFantasyLeagueBase
    {
        [Category("Appearance")]
        [Description("The margin around all text elements")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Padding TextMargins { get; set; } = new Padding(3);

		[Category("Appearance")]
		[Description("The color used to draw bracket lines")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public Color LineColor { get; set; } = Color.Black;

		[Category("Appearance")]
		[Description("The thickness of the bracket lines")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public float LineWidth { get; set; } = 1;

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Team TeamTop { get; set; }

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Team TeamBottom { get; set; }

		/// <summary>
		/// The bracket control which feeds into the top of this control
		/// </summary>
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public ctrlBracketMatchup ParentUpper
		{
			get => _parentUpper;
			set
			{
				_parentUpper = value;
				_parentUpper.Child = this;
				SetLocationBasedOnParents();
			}
		}
		private ctrlBracketMatchup _parentUpper;

		/// <summary>
		/// The bracket control which feeds into the bottom of this control
		/// </summary>
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public ctrlBracketMatchup ParentLower
		{
			get => _parentLower;
			set
			{
				_parentLower = value;
				_parentLower.Child = this;
				SetLocationBasedOnParents();
			}
		}
		private ctrlBracketMatchup _parentLower;

		/// <summary>
		/// The bracket control which this control feeds into
		/// </summary>
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public ctrlBracketMatchup Child
		{
			get => _child;
			set
			{
				_child = value;
			}
		}
		private ctrlBracketMatchup _child;

		/// <summary>
		/// The point from which a child bracket matchup control should branch off
		/// </summary>
		public Point ChildBranchPoint => new(Location.X + Width, Location.Y + VerticalLineVerticalCenter);

		/// <summary>
		/// The vertical center of this bracket segment's vertical line
		/// </summary>
		private int VerticalLineVerticalCenter => (LowerLineBottom - UpperLineTop) / 2 + UpperLineTop;

		/// <summary>
		/// The vertical center of the upper horizontal line
		/// </summary>
		private int UpperLineVerticalCenter => Font.Height + TextMargins.Vertical + (int)LineWidth / 2;

		/// <summary>
		/// The vertical center of the lower horizontal line
		/// </summary>
		private int LowerLineVerticalCenter => Height - ((int)LineWidth + 1) / 2;

		/// <summary>
		/// The horizontal center of the vertical line
		/// </summary>
		private int VerticalLineHorizontalCenter => Width - ((int)LineWidth + 1) / 2;

		private int UpperLineTop => UpperLineVerticalCenter - (int)LineWidth / 2;
		private int UpperLineBottom => UpperLineVerticalCenter + ((int)LineWidth + 1) / 2;

		private int LowerLineTop => LowerLineVerticalCenter - (int)LineWidth / 2;
		private int LowerLineBottom => LowerLineVerticalCenter + ((int)LineWidth + 1) / 2;

		private int VerticalLineLeft => VerticalLineHorizontalCenter - (int)LineWidth / 2;
		private int VerticalLineRight => VerticalLineHorizontalCenter - ((int)LineWidth + 1) / 2;

		/// <summary>
		/// The distance above the vertical center of the upper horizontal line
		/// </summary>
		private int DistanceAboveUpperLine => (UpperLineVerticalCenter - UpperLineBottom) + TextMargins.Vertical + Font.Height;

		/// <summary>
		/// The distance below the vertical center of the lower horizontal line
		/// </summary>
		private int DistanceBelowLowerLine => (LowerLineBottom - LowerLineVerticalCenter);

		private int DistanceBetweenHorizontalLines
		{
			get => LowerLineVerticalCenter - UpperLineVerticalCenter;
			set
			{
				//Set the control's height so that the distance between the vertical centers of the two horizontal lines is set correcly
				Height = value + DistanceAboveUpperLine + DistanceBelowLowerLine;
			}
		}

		public ctrlBracketMatchup()
        {
            InitializeComponent();

			AutoScaleMode = AutoScaleMode.None;
        }

		/// <summary>
		/// Set this control's location based on the locations of its parent(s)
		/// </summary>
		private void SetLocationBasedOnParents()
		{
			var widthOriginal = Width;

			//If the parents are both null, do nothing
			if (ParentUpper is null && ParentLower is null)
			{
				return;
			}

			//If exactly one parent is not null, just move us so that the appropriate horizontal line
			//lines up with that parent's vertical line's center
			if (ParentUpper is not null && ParentLower is null)
			{
				//Only upper parent is set
				Location = new Point(ParentUpper.ChildBranchPoint.X, ParentUpper.ChildBranchPoint.Y - DistanceAboveUpperLine);
				return;
			}
			
			if (ParentUpper is null && ParentLower is not null)
			{
				//Only lower parent is set
				Location = new Point(ParentLower.ChildBranchPoint.X, ParentLower.ChildBranchPoint.Y - DistanceAboveUpperLine - DistanceBetweenHorizontalLines);
				return;
			}

			//Both parents are set.
			//Resize so that both of our horizontal lines line up with the middles of their vertical lines

			if (ParentLower.ChildBranchPoint.Y < ParentUpper.ChildBranchPoint.Y)
			{
				return; //The lower parent is above the upper parent;
			}


			DistanceBetweenHorizontalLines = ParentLower.ChildBranchPoint.Y - ParentUpper.ChildBranchPoint.Y;
			//Set location based on upper parent now
			//For this control's vertical location, the spacing of the horizontal lines should match up with both lower and upper parents
			//But for the horiontal location, we just go based off of the upper parent, since we have to choose one
			Location = new Point(ParentUpper.ChildBranchPoint.X, ParentUpper.ChildBranchPoint.Y - DistanceAboveUpperLine);

			Width = widthOriginal;
		}

		public override Size GetPreferredSize(Size proposedSize)
		{
			return Size; // freeze preferred size to current size
		}

		private void ctrlBracketMatchup_Paint(object sender, PaintEventArgs e)
        {
			SetLocationBasedOnParents();

			Point horizontalUpperP1 = new(0, UpperLineVerticalCenter);
            Point horizontalUpperP2 = new(Width, UpperLineVerticalCenter);

            Point horizontalLowerP1 = new(0, LowerLineVerticalCenter);
            Point horizontalLowerP2 = new(Width, LowerLineVerticalCenter);

            Point verticalP1 = new(VerticalLineHorizontalCenter, UpperLineTop);
            Point verticalP2 = new(VerticalLineHorizontalCenter, LowerLineBottom);

            var pen = new Pen(LineColor, LineWidth);

            //Draw the lines
            e.Graphics.DrawLine(pen, horizontalUpperP1, horizontalUpperP2);
            e.Graphics.DrawLine(pen, horizontalLowerP1, horizontalLowerP2);
            e.Graphics.DrawLine(pen, verticalP1, verticalP2);

			var textBrush = new SolidBrush(ForeColor);

			PointF topTextUpperLeftCorner = new(0, 0);
			PointF bottomTextUpperLeftCorner = new(0, LowerLineTop - Font.Height - TextMargins.Vertical);

			//Draw the text
			if (TeamTop == null)
			{
				//Mostly just here so you can see text in the designer
				e.Graphics.DrawString("Top Team (0 - 0 - 0)", Font, textBrush, topTextUpperLeftCorner);
			}
			else
			{
				e.Graphics.DrawString($"{TeamTop.Name} ({TeamTop.RecordString})", Font, textBrush, topTextUpperLeftCorner);
			}

			//Draw the text
			if (TeamBottom == null)
			{
				//Mostly just here so you can see text in the designer
				e.Graphics.DrawString("Bottom Team (0 - 0 - 0)", Font, textBrush, bottomTextUpperLeftCorner);
			}
			else
			{
				e.Graphics.DrawString($"{TeamBottom.Name} ({TeamBottom.RecordString})", Font, textBrush, bottomTextUpperLeftCorner);
			}
		}
    }
}
