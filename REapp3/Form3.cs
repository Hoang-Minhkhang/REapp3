using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace REapp3
{
	public partial class Form3 : Form
	{
		private string _username;
		private string TruyenForm2 = "";
		private string _nickname;

		public Form3(string username , string nickname )
		{
			InitializeComponent();
			_username = username;
			_nickname = nickname;
			usernameToolStripMenuItem.Text = _nickname;
		}

		private void Form3_Load(object sender, EventArgs e)
		{

		}
		private string DapAnDung = "";
		private void Answer_CheckedChanged(object sender, EventArgs e)
		{
			UpdateTotal();
		}
		private void UpdateTotal()
		{
			int count = 0;

			foreach (Control control in flowLayoutPanel1.Controls)
			{
				GroupBox gb = control as GroupBox;

				if (gb == null)
					continue;

				bool answered = false;

				foreach (RadioButton rd in gb.Controls.OfType<RadioButton>())
				{
					if (rd.Checked)
					{
						answered = true;
						break;
					}
				}

				if (answered)
					count++;
			}

			label3.Text = $"đã làm {count} câu ";
		}

		private void button3_Click(object sender, EventArgs e)
		{
			flowLayoutPanel1.Controls.Clear();
			if (!int.TryParse(textBox1.Text, out int soCau))
			{
				MessageBox.Show("Nhập số câu hợp lệ!");
				return;
			}
			for (int i = 1; i <= int.Parse(textBox1.Text); i++)
			{
				GroupBox gb = new GroupBox();
				gb.Text = $"Câu {i}";
				gb.Width = flowLayoutPanel1.Width - 25;
				gb.Height = 55;

				TableLayoutPanel tlp = new TableLayoutPanel();

				tlp.Dock = DockStyle.Fill;
				tlp.ColumnCount = 4;

				for (int c = 0; c < 4; c++)
				{
					tlp.ColumnStyles.Add(
						new ColumnStyle(SizeType.Percent, 25));
				}

				RadioButton rdA = new RadioButton();
				rdA.Text = "A";

				RadioButton rdB = new RadioButton();
				rdB.Text = "B";

				RadioButton rdC = new RadioButton();
				rdC.Text = "C";

				RadioButton rdD = new RadioButton();
				rdD.Text = "D";

				rdA.CheckedChanged += Answer_CheckedChanged;
				rdB.CheckedChanged += Answer_CheckedChanged;
				rdC.CheckedChanged += Answer_CheckedChanged;
				rdD.CheckedChanged += Answer_CheckedChanged;

				tlp.Controls.Add(rdA, 0, 0);
				tlp.Controls.Add(rdB, 1, 0);
				tlp.Controls.Add(rdC, 2, 0);
				tlp.Controls.Add(rdD, 3, 0);
				

				gb.Controls.Add(tlp);

				flowLayoutPanel1.Controls.Add(gb);
			}
		}

		private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private async void button4_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();

			ofd.Filter = "PDF Files (*.pdf)|*.pdf";
			ofd.Title = "Chọn file PDF";

			if (ofd.ShowDialog() == DialogResult.OK)
			{
				await webView21.EnsureCoreWebView2Async();

				string pdfPath = ofd.FileName;

				webView21.Source = new Uri(pdfPath);
			}
		}
		string NgDung = ""; 
		private void button2_Click(object sender, EventArgs e)
		{
			TruyenForm2 += "BAI KIEM TRA \n ----- NGUOI DUNG GHI  \n ";

			int soCau = 1;

			foreach (Control control in flowLayoutPanel1.Controls)
			{
				GroupBox gb = control as GroupBox;

				if (gb == null)
					continue;

				string dapAn = "";

				foreach (TableLayoutPanel tlp in gb.Controls.OfType<TableLayoutPanel>())
				{
					foreach (RadioButton rd in tlp.Controls.OfType<RadioButton>())
					{
						if (rd.Checked)
						{
							dapAn = rd.Text;
							break;
						}
					}

					if (dapAn != "")
						break;
				}

				if (dapAn != "")
				{
					TruyenForm2 += $"{soCau}{dapAn} \n  ";
					NgDung += $"{soCau}{dapAn} \n  ";
				}

				soCau++;
			}
			label5.Text = "Đã hoàn thành " ;
			tabControl1.SelectedIndex = 1; 
			label5.BackColor = Color.LightGreen;
			MessageBox.Show("Đã hoàn thành " + TruyenForm2);
			
		}
		private Dictionary<int, string> ParseAnswer(string data)
		{
			Dictionary<int, string> result =
				new Dictionary<int, string>();

			string[] lines =
				data.Split(
					new[] { "\r\n", "\n" },
					StringSplitOptions.RemoveEmptyEntries);

			foreach (string line in lines)
			{
				string s = line.Trim();

				string number = "";
				string answer = "";

				foreach (char c in s)
				{
					if (char.IsDigit(c))
						number += c;
					else if (char.IsLetter(c))
						answer += c;
				}

				if (number != "" && answer != "")
				{
					result[int.Parse(number)] =
						answer.ToUpper();
				}
			}

			return result;
		}
		private void button5_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();

			ofd.Filter = "Text File (*.txt)|*.txt";

			if (ofd.ShowDialog() == DialogResult.OK)
			{
				DapAnDung = File.ReadAllText(ofd.FileName);

				MessageBox.Show("Đã nạp đáp án.");
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			var user = ParseAnswer(TruyenForm2);
			var key = ParseAnswer(DapAnDung);

			int dung = 0;
			int sai = 0;

			richTextBox1.Clear();

			foreach (var item in key)
			{
				int soCau = item.Key;
				string dapAnDung = item.Value;

				if (user.ContainsKey(soCau))
				{
					string dapAnUser = user[soCau];

					if (dapAnUser == dapAnDung)
					{
						dung++;
					}
					else
					{
						sai++;

						richTextBox1.AppendText(
							$"Câu {soCau}: Sai\n" +
							$"Bạn chọn: {dapAnUser}\n" +
							$"Đáp án đúng: {dapAnDung}\n\n");
					}
				}
				else
				{
					sai++;

					richTextBox1.AppendText(
						$"Câu {soCau}: Chưa làm\n" +
						$"Đáp án đúng: {dapAnDung}\n\n");
				}
			}

			label8.Text = dung.ToString();
			label10.Text = sai.ToString();

			double diem = (double)dung * 10 / key.Count;

			label12.Text = diem.ToString("0.00");
		}

		private void button7_Click(object sender, EventArgs e)
		{
			TruyenForm2+= $"So CAu Dung {label8.Text}  \n số câu sai {label10.Text} \n Diem {label12.Text} \n  Bài Làm Hoàn thành kết  điểm vào {DateTime.Now }" ; 
			Form2 form2 = new Form2(_username, _nickname, TruyenForm2);
			form2.Show(); 
		}

		private void nhậpĐápÁnToolStripMenuItem_Click(object sender, EventArgs e)
		{
			button5.PerformClick(); 
		}

		private void chấmLiềnToolStripMenuItem_Click(object sender, EventArgs e)
		{
			button6.PerformClick(); 
		}

		private void kếtĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
		{
			button7.PerformClick(); 
		}

		private void nhậpFilePDFKiểmTraToolStripMenuItem_Click(object sender, EventArgs e)
		{
			button4.PerformClick(); 
		}
	}
}
