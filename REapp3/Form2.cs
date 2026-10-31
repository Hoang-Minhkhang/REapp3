using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

		private void sIGNOUTToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Hide(); 
		}
	}
}
