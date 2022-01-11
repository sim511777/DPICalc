using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPICalc
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnCalc_Click(object sender, EventArgs e)
		{
			try
			{
				double inch = double.Parse(this.tbxInch.Text);
				double xRes = int.Parse(this.tbxXres.Text);
				double yRes = int.Parse(this.tbxYres.Text);
				double diaRes = Math.Sqrt(xRes * xRes + yRes * yRes);
				double dpi = diaRes / inch;
				double xInch = inch * xRes / diaRes;
				double yInch = inch * yRes / diaRes;
				double area = xInch * yInch;
            // 300:30 150:60
            int dist_cm = (int)(9000/dpi);
				ListViewItem item = this.listView1.Items.Add(inch.ToString("F1"));
				item.SubItems.Add(xRes.ToString("F1"));
				item.SubItems.Add(yRes.ToString("F1"));
				item.SubItems.Add(dpi.ToString("F1"));
				item.SubItems.Add(xInch.ToString("F1"));
				item.SubItems.Add(yInch.ToString("F1"));
				item.SubItems.Add(area.ToString("F1"));
            item.SubItems.Add(dist_cm.ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
