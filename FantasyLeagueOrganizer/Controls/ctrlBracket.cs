using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FantasyLeagueOrganizer.Controls
{
    public partial class ctrlBracket : UserControl
    {
		[Category("Appearance")]
		[Description("The margin around all text elements")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public Padding TextMargins 
		{
			get => _textMargins;
			set
			{
				_textMargins = value;
				foreach (var bracketMatchup in Controls.OfType<ctrlBracketMatchup>())
				{
					bracketMatchup.TextMargins = value;
				}
			}
		}
		private Padding _textMargins = new Padding(3);


		[Category("Appearance")]
		[Description("The color used to draw bracket lines")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public Color LineColor
		{
			get => _lineColor;
			set
			{
				_lineColor = value;
				foreach (var bracketMatchup in Controls.OfType<ctrlBracketMatchup>())
				{
					bracketMatchup.LineColor = value;
				}
			}
		}
		private Color _lineColor = Color.Black;

		[Category("Appearance")]
		[Description("The thickness of the bracket lines")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public float LineWidth
		{
			get => _lineWidth;
			set
			{
				_lineWidth = value;
				foreach (var bracketMatchup in Controls.OfType<ctrlBracketMatchup>())
				{
					bracketMatchup.LineWidth = value;
				}
			}
		}
		private float _lineWidth = 1;

		public ctrlBracket()
        {
            InitializeComponent();

			AutoScaleMode = AutoScaleMode.None;

			var bracket1 = new ctrlBracketMatchup();
			var bracket2 = new ctrlBracketMatchup();
			var bracket3 = new ctrlBracketMatchup();

			Controls.Add(bracket1);
			Controls.Add(bracket2);
			Controls.Add(bracket3);

			bracket1.Height = 100;
			bracket1.Width = 200;
			bracket1.Location = new Point(0, 0);


			bracket2.Height = 100;
			bracket2.Width = 200;
			bracket2.Location = new Point(0, 150);

			bracket3.Height = 100;
			bracket3.Width = 200;

			bracket3.ParentUpper = bracket1;
			bracket3.ParentLower = bracket2;
		}

        public void GenerateBracket()
        {
            
		}
    }
}
