using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace REapp3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		string currentUsername = "";
		string nickname = "";
		string cuser = "";
		bool dangnhap = false;
		private void button7_Click(object sender, EventArgs e)
		{
			tabControl3.SelectedIndex = 0; 
		}

		private void button2_Click(object sender, EventArgs e)
		{
			tabControl3.SelectedIndex = 1;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			string username = TaiKhoan.Text;
			string password = MatKhau.Text;
			string TruyenForm2 = "";
			var credentials = new Dictionary<string, string>
			{
				{ "MinhKhang1995", "123456987@admin" },
				{ "Administrator", "123456987@admin" },
				{ "Test", "test@123" },
				{ "TurboLines", "TurboLines@123" },
				{ "User1005", "123456987" }
				// DO NOT SHARE ANY INFORMATION IN THIS CHECK thank you ! 
			};

			if (credentials.TryGetValue(username, out var expected) && expected == password)
			{
				currentUsername = username;
				cuser = username;

				var nicknames = new Dictionary<string, string>
				{
					{ "MinhKhang1995", "MinhKhang" },
					{ "Administrator", "Quản trị viên" },
					{ "Test", "Người dùng thử" },
					{ "TurboLines", "TurboLines" },
					{ "User1005", "DKhang" }
					// DO NOT SHARE PRIVATE INFORMATION .
				};
				string nickname;
				if (!nicknames.TryGetValue(username, out nickname))
					nickname = username;

				// open forms with both username and nickname
				MainForm mainForm = new MainForm(username, nickname);
				mainForm.Show();
				MatKhau.Text = "";
				Form2 form2 = new Form2(username, nickname, TruyenForm2);
				form2.Show();
				this.Hide(); 

			}
			else
			{
				dangnhap = false;
				MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng. Vui lòng thử lại.", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.KeyPreview = true;
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				button3.PerformClick();
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Process.Start("osk.exe"); 
		}

		private void đăngNhậpToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			button3.PerformClick();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close(); 
		}

		private void button8_Click(object sender, EventArgs e)
		{
			tabControl3.SelectedIndex = 0; 
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			
		}
	}
}
