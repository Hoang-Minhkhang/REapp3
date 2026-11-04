using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace REapp3
{
	public partial class Form2 : Form
	{
		public Form2(string username, string nickname,string TruyenForm2 )
		{
			InitializeComponent();
			richTextBox1.Text = "THis is REapp3 Notepad \n HI " + username + " !\n\nVisit https://github.com/Hoang-Minhkhang/REapp3/ for more information  \n to save this document : Notepad->saveFile \n  ";
			richTextBox1.Text += "\n Sign in as " + username + " at " + DateTime.Now + " \n " + TruyenForm2;
			usernameToolStripMenuItem.Text = nickname;
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			
		}
		private string MinhKhangNotepad = null;
		private void sIGNOUTToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Hide(); 
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(MinhKhangNotepad))
			{
				File.WriteAllText(MinhKhangNotepad, richTextBox1.Text);
			}
			else
			{
				SaveFileDialog sfd = new SaveFileDialog();
				sfd.Filter = "Text Files|*.txt";

				if (sfd.ShowDialog() == DialogResult.OK)
				{
					MinhKhangNotepad = sfd.FileName;

					File.WriteAllText(MinhKhangNotepad, richTextBox1.Text);

					MessageBox.Show(
						"File saved successfully!",
						"Information",
						MessageBoxButtons.OK,
						MessageBoxIcon.Information);
				}
			}
		}

		private void nEWToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Clear();

			// Reset trạng thái file
			MinhKhangNotepad = null;

			// Cập nhật tiêu đề form giống Notepad
			this.Text = $"MinhKhang.exe - notepadApplication";
		}

		private void importToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "Text Files|*.txt";
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				MinhKhangNotepad = ofd.FileName;
				richTextBox1.Text = File.ReadAllText(MinhKhangNotepad);
			}
		}
	}
}
