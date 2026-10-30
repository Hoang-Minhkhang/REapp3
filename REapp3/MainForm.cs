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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace REapp3
{
	public partial class MainForm : Form
	{
		private string _username;
		public string _nickname { get; set; }
		private bool ok = true; 
		public MainForm(string username, string nickname)
		{
			InitializeComponent();
			_username = username;
			this.KeyPreview = true;
			_nickname = nickname;
		}
		private string ver = "REapp3 v1.0"; 
		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("REbuild Application3 \n\nVersion: " + ver + "\n\nThis application is designed for educational purposes only. \n\nPlease do not use it for any illegal activities. \n\nThank you for using REbuild Application3!", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		

		private void MainForm_Load(object sender, EventArgs e)
		{
			usernameToolStripMenuItem.Text = _nickname; 
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void tabPage3_Click(object sender, EventArgs e)
		{

		}
		
		private void tabPage2_Click(object sender, EventArgs e)
		{
			
		}

		private void button5_Click(object sender, EventArgs e)
		{
			tabControl1.SelectedIndex = 1; 
		}
		private string tbkinfo = "Thời khóa biểu lần 6 áp dụng ngày 02 11 2026 có thời hạn 1 tuần ";
		private int tkbEXPday = 07;
		private int tkbEXPmonth = 11;
		private int tkbEXPyear = 2026;
		private string tkbname = "TKB L6";
		private string note = $"Thời khóa biểu lần 6 \n Chú ý nghỉ chiều thứ 4 và sáng thứ 6 "; 
		private void tabPage2_Enter(object sender, EventArgs e)
		{
			if (ok)
			{
				label11.Text = $"{tkbEXPday} / {tkbEXPmonth} / {tkbEXPyear}";
				label3.Text = tbkinfo;
				pictureBox1.Visible = true;
				label15.Text = note;
				label7.Text = tkbname;
				var expiry = new DateTime(tkbEXPyear, tkbEXPmonth, tkbEXPday);
				if (DateTime.Now.Date <= expiry.Date)
				{
					label13.Text = "Còn Hiệu Lực ";
					label13.ForeColor = Color.Green;
				}
				else
				{
					label13.Text = "Hết  Hiệu Lực ";
					label13.ForeColor = Color.Red;
					MessageBox.Show("Thời khóa biểu đã hết hạn , vui lòng liên hệ quản trị viên để được cấp lại ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
		}
	}
}
