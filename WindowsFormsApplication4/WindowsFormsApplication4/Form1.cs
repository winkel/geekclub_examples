using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		int AreaLeft
		{
			set
			{
				cornerA1.Left = value;
				cornerA2.Left = value;
			}
			get { return cornerA1.Left; }
		}

		int AreaTop
		{
			set { cornerA1.Top = value; }
			get { return cornerA1.Top; }
		}

		int AreaBottom
		{
			set { cornerA2.Top = value; }
			get { return cornerA2.Top; }
		}

		int AreaRight
		{
			set { ; }
			// tbd
			get { return 0; }
		}

		bool processA1 = false;
		Point locationA1;

		private void cornerA1_MouseDown(object sender, MouseEventArgs e)
		{
			processA1 = true;
			locationA1 = cornerA1.PointToScreen(e.Location);
		}

		private void cornerA1_MouseUp(object sender, MouseEventArgs e)
		{
			processA1 = false;
		}

		private void cornerA1_MouseMove(object sender, MouseEventArgs e)
		{
			if (processA1)
			{
				Point oldLocation = locationA1;
				locationA1 = cornerA1.PointToScreen(e.Location);

				//using (var gfx = CreateGraphics())
				//{
				//	Debug.WriteLine("X:{0}; Y:{1}; dX:{2}; dY:{3}; DpiX:{4}; DpiY:{5}", 
				//		e.Location.X, e.Location.Y, 
				//		locationA1.X - oldLocation.X, locationA1.Y - oldLocation.Y, 
				//		gfx.DpiX, gfx.DpiY);
				//}

				AreaLeft += locationA1.X - oldLocation.X;
				AreaTop += locationA1.Y - oldLocation.Y;
			}
		}

		bool processA2 = false;
		Point locationA2;

		private void cornerA2_MouseDown(object sender, MouseEventArgs e)
		{
			processA2 = true;
			locationA2 = cornerA2.PointToScreen(e.Location);
		}

		private void cornerA2_MouseUp(object sender, MouseEventArgs e)
		{
			processA2 = false;
		}

		private void cornerA2_MouseMove(object sender, MouseEventArgs e)
		{
			if (processA2)
			{
				Point oldLocation = locationA2;
				locationA2 = cornerA2.PointToScreen(e.Location);

				AreaLeft += locationA2.X - oldLocation.X;
				AreaBottom += locationA2.Y - oldLocation.Y;
			}
		}
	}
}
