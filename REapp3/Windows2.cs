
using iText.Kernel.Pdf.Canvas;
using Syncfusion.Drawing;
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
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas;
using iText.Kernel.Font;
using iText.IO.Font.Constants;

namespace REapp3
{
	public partial class Windows2 : Form
	{
		private string currentPdfPath;
		private string _username;
		private int _windows2choice;
		public Windows2(string username, int windows2choice)
		{
			InitializeComponent();
			usernameToolStripMenuItem.Text = username;
			_username = username;
			_windows2choice = windows2choice;
			if(_windows2choice == 1)
			{
				tabControl1.SelectedIndex = 0;
			}
			else if (_windows2choice == 2)
			{
				tabControl1.SelectedIndex = 1;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			webView21.GoBack();
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

		private void DiaChiThanh_KeyDown_1(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				button3.PerformClick();
			}
		}
		private async void Form1_Load(object sender, EventArgs e)
		{
			await webView21.EnsureCoreWebView2Async();

			webView21.CoreWebView2.Navigate("https://www.bing.com");
			webView21.NavigationCompleted += WebView21_NavigationCompleted;
		}
		private void WebView21_NavigationCompleted(
	object sender,
	Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
		{
			DiaChiThanh.Text = webView21.Source.ToString();
		}
		private async void Windows2_Load(object sender, EventArgs e)
		{
			await webView21.EnsureCoreWebView2Async();

			webView21.CoreWebView2.Navigate("https://www.bing.com");
		}
		private void webView21_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
		{
			if (webView21.Source != null)
			{
				DiaChiThanh.Text = webView21.Source.ToString();
			}
		}

		private void webView21_SourceChanged(object sender, Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs e)
		{
			if (webView21.Source != null)
			{
				DiaChiThanh.Text = webView21.Source.ToString();
			}
		}
		private async void button6_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();

			ofd.Filter = "PDF Files (*.pdf)|*.pdf";

			if (ofd.ShowDialog() == DialogResult.OK)
			{
				currentPdfPath = ofd.FileName;   // QUAN TRỌNG

				await webView22.EnsureCoreWebView2Async();

				webView22.Source = new Uri(currentPdfPath);
			}

		}

		private async void  button4_Click(object sender, EventArgs e)
		{
			await webView22.CoreWebView2.ExecuteScriptAsync(
	   "window.print();");
		}

		private void button7_Click(object sender, EventArgs e)
		{
			
		}

		private void button8_Click(object sender, EventArgs e)
		{
			
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			webView21.GoBack();
		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			webView21.GoForward();
		}

		private void webView21_SourceChanged_1(object sender, Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs e)
		{
			if (webView21.Source != null)
			{
				DiaChiThanh.Text = webView21.Source.ToString();
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			MessageBox.Show(currentPdfPath ?? "NULL");
			string inputPdf = currentPdfPath;

			string outputPdf =
				Path.Combine(
					Path.GetDirectoryName(inputPdf),
					"Signed_" + Path.GetFileName(inputPdf));

			PdfDocument pdf =
				new PdfDocument(
					new PdfReader(inputPdf),
					new PdfWriter(outputPdf));

			PdfFont font =
				PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

			string userName = Environment.UserName;
			string signTime = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

			for (int i = 1; i <= pdf.GetNumberOfPages(); i++)
			{
				var page = pdf.GetPage(i);
				PdfCanvas canvas = new PdfCanvas(page);
				canvas.BeginText();

				canvas.SetFontAndSize(font, 9);
				canvas.MoveText(20, 780);
				canvas.ShowText("REapp3 PDF SIGN");

				canvas.MoveText(0, -10);
				canvas.ShowText("Username : " + _username);

				canvas.MoveText(0, -10);
				canvas.ShowText("Date and time : " + signTime);

				canvas.MoveText(0, -10);
				canvas.ShowText("Chu ky hop le");
			}

			pdf.Close();

			currentPdfPath = outputPdf;

			webView22.Source = new Uri(outputPdf);

			MessageBox.Show($"Username : {_username}\nDate: {signTime}\n Chữ kí số hợp lệ ");
		}
	}
}
