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
	public partial class MainForm : Form
	{
		private string _username;
		public string _nickname { get; set; }
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
			MessageBox.Show("REbould Application3 \n\nVersion: " + ver + "\n\nThis application is designed for educational purposes only. \n\nPlease do not use it for any illegal activities. \n\nThank you for using REbould Application3!", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			usernameToolStripMenuItem.Text = _nickname; 
		}
	}
}
