
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REapp3
{
	public partial class Windows2 : Form
	{
		private string currentPdfPath;
		public Windows2(string username)
		{
			InitializeComponent();
			usernameToolStripMenuItem.Text = username;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			webView21.GoBack();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			webView21.GoForward();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			string url = DiaChiThanh.Text.Trim();
			if (string.IsNullOrEmpty(url))
			{
				MessageBox.Show("Nhập địa chỉ .");
				return;
			}

			// Nếu người dùng quên http:// thì tự thêm vào
			if (!url.StartsWith("http://") && !url.StartsWith("https://"))
			{
				url = "https://" + url;
			}
			if (webView21.CoreWebView2 != null)
			{
				webView21.CoreWebView2.Navigate(url);
			}
		}

		private void DiaChiThanh_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				button3.PerformClick();
			}
		}
		private async void Form1_Load(object sender, EventArgs e)
		{
			await webView21.EnsureCoreWebView2Async();

			webView21.CoreWebView2.Navigate("https://www.microsoft.com");
		}
		private async void Windows2_Load(object sender, EventArgs e)
		{
			await webView21.EnsureCoreWebView2Async();

			webView21.CoreWebView2.Navigate("https://www.microsoft.com");
		}

		private async void button6_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();

			ofd.Filter = "PDF Files (*.pdf)|*.pdf";

			if (ofd.ShowDialog() == DialogResult.OK)
			{
				await webView21.EnsureCoreWebView2Async();

				webView21.Source = new Uri(ofd.FileName);
			}
			tabControl1.SelectedIndex = 0; 
		}

		private async void  button4_Click(object sender, EventArgs e)
		{
			await webView21.CoreWebView2.ExecuteScriptAsync(
	   "window.print();");
		}

		private void button7_Click(object sender, EventArgs e)
		{
			
		}

		private void button8_Click(object sender, EventArgs e)
		{
			
		}
	}
}
