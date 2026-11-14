using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace REapp3
{
	public partial class MainForm : Form
	{
		private string _username;
		public string _nickname { get; set; }
		private string TruyenForm2 = "";
		private bool isRunning = false;
		private DateTime startTime;
		private TimeSpan pausedTime = TimeSpan.Zero;
		private bool ok = true;
		private int windows2choice = 0; 
		private string ver = "REapp3 v0.1 UNrealeased yet - Last Update 13-11-2026 ";
		public MainForm(string username, string nickname)
		{
			InitializeComponent();
			_username = username;
			this.KeyPreview = true;
			_nickname = nickname;
			this.Text= $"REapp3 -{_nickname} - {ver}";
			label20.Text = username;
			label21.Text = nickname; 
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("REbuild Application3 \n\nVersion: " + ver + "\n\nThis application is designed for educational purposes only. \n\nPlease do not use it for any illegal activities. \n\nThank you for using REbuild Application3!", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		public class TaskItem
		{
			public string Name { get; set; }
			public string WorkTime { get; set; }
			public bool Completed { get; set; }
			public string Note { get; set; }
		}
		
		private void MainForm_Load(object sender, EventArgs e)
		{
			usernameToolStripMenuItem.Text = _nickname; 
		}
		private List<TaskItem> tasks =
	new List<TaskItem>();

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
		private string tbkinfo = "Thời khóa biểu lần 5 áp dụng ngày 07 11 2026 có thời hạn nhiều tuần ";
		private int tkbEXPday = 27;
		private int tkbEXPmonth = 11;
		private int tkbEXPyear = 2026;
		private string tkbname = "TKB L5";
		private string note = $"Thời khóa biểu lần 5 \n Thời khóa biểu có tính hợp lý "; 
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

		private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			//this.Close(); 
		}

		private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form1 form1 = new Form1();
			form1.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form2 form2 = new Form2(_username, _nickname, TruyenForm2);
			form2.Show();
		}
		string pdfPath = "";
		private void button3_Click(object sender, EventArgs e)
		{
			windows2choice = 1; 
			Windows2 windows2 = new Windows2(_username, windows2choice, pdfPath);
			windows2.Show(); 
		}

		private void button2_Click(object sender, EventArgs e)
		{
			windows2choice = 2;
			Windows2 windows2 = new Windows2(_username, windows2choice, pdfPath);
			windows2.Show();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Form3 form3 = new Form3(_username,_nickname);
			form3.Show();
		}
		private void timer1_Tick(object sender, EventArgs e)
		{
			if (isRunning)
			{
				TimeSpan elapsed =
					DateTime.Now - startTime;
				label19.Text =		elapsed.ToString(@"hh\:mm\:ss");
			}
		}
		private void button7_Click(object sender, EventArgs e)
		{
			isRunning = true;
			startTime = DateTime.Now;
			timer1.Start();
		}

		private void button9_Click(object sender, EventArgs e)
		{
			if (isRunning)
			{		
				isRunning = false;
				timer1.Stop();
				pausedTime = DateTime.Now - startTime;
				button9.Text = "Resume";
			}
			else
			{	
				isRunning = true;
				startTime = DateTime.Now - pausedTime;
				timer1.Start();
				button9.Text = "Pause";
			}
		}
		

		private void button10_Click(object sender, EventArgs e)
		{
			timer1.Stop();
			isRunning = false;
			button17.PerformClick();
			TruyenForm2 += $"Kết thúc phiên làm việc - tổng thời gian là  {label19.Text} vào {DateTime.Now}\n";
			TruyenForm2 += $"Chữ Ký {_username}\n \n \n \n \n \n \n \n \n \n _________________________________ \n Reapplication3 {ver} \n  xuất vào {DateTime.Now} ";
			Form2 form2 = new Form2(_username, _nickname, TruyenForm2);
			form2.Show();
		}
		private void UpdateProgress()
		{
			if (tasks.Count == 0)
			{
				progressBar1.Value = 0;
				return;
			}
			int completed =
				tasks.Count(t => t.Completed);
			int percent =
				completed * 100 / tasks.Count;
			progressBar1.Value = percent;
		}
		private void TxtNote_TextChanged(	object sender,EventArgs e)
		{
			TextBox txt = sender as TextBox;
			TaskItem task = txt.Tag as TaskItem;
			if (task != null)
			{
				task.Note = txt.Text;
			}
		}
		private void CreateTaskBox(TaskItem task)
		{
			GroupBox gb = new GroupBox();
			gb.Text = "Task";
			gb.Width = 300;
			gb.Height = 140;
			System.Windows.Forms.Label lblTask =
				new System.Windows.Forms.Label();
			lblTask.Text = task.Name;
			lblTask.Location = new Point(10, 20);
			lblTask.AutoSize = true;
			TextBox txtNote = new TextBox();
			txtNote.Name = "txtNote";
			txtNote.Multiline = true;
			txtNote.Width = 250;
			txtNote.Height = 20;
			txtNote.Location = new Point(10, 40);
			txtNote.Text = "";
			// PHẢI ĐẶT SAU KHI KHAI BÁO txtNote
			txtNote.Tag = task;
			txtNote.TextChanged += TxtNote_TextChanged;
			System.Windows.Forms.Label lblStatus =
				new System.Windows.Forms.Label();
			lblStatus.Name = "lblStatus";
			lblStatus.Text = "Đang thực hiện";
			lblStatus.ForeColor = Color.Orange;
			lblStatus.Location = new Point(10, 90);
			Button btnDone = new Button();
			btnDone.Text = "Hoàn Thành";
			btnDone.Location = new Point(180, 95);
			btnDone.Tag = task;
			btnDone.Click += BtnDone_Click;
			gb.Controls.Add(lblTask);
			gb.Controls.Add(txtNote);
			gb.Controls.Add(lblStatus);
			gb.Controls.Add(btnDone);

			flowLayoutPanel1.Controls.Add(gb);
		}
		private void BtnDone_Click(object sender, EventArgs e)
		{
			Button btn = sender as Button;
			TaskItem task = btn.Tag as TaskItem;
			GroupBox gb = btn.Parent as GroupBox;
			Label lbl =
				gb.Controls["lblStatus"]
				as Label;
			int index = tasks.IndexOf(task);
			/*	if (!task.Completed)
				{
					// Đánh dấu hoàn thành
					task.Completed = true;
					btn.Text = "Hoàn Tác";
					gb.BackColor = Color.LightGreen;
					lbl.Text = "✓ Hoàn Thành";
					lbl.ForeColor = Color.Green;
					if (index >= 0)
						checkedListBox1.SetItemChecked(index, true);
				}
				else
				{		
					task.Completed = false;
					btn.Text = "Hoàn Thành";
					gb.BackColor = SystemColors.Control;
					lbl.Text = "Đang thực hiện";
					lbl.ForeColor = Color.Orange;
					if (index >= 0)
					checkedListBox1.SetItemChecked(index, false);
				}*/
			if (lbl != null)
			{
				task.Completed = true;
				lbl.Text = "✓ Hoàn Thành";
				lbl.ForeColor = Color.Green;
				gb.BackColor = Color.LightGreen;
			}
			UpdateChecklist(); 
			UpdateProgress();
			int index1 = tasks.IndexOf(task);

			if (index1 >= 0)
			{
				checkedListBox1.SetItemChecked(index1, true);

			}
		}
		private void UpdateChecklist()
		{
			for (int i = 0; i < tasks.Count; i++)
			{
				checkedListBox1.SetItemChecked(
					i,
					tasks[i].Completed
				);
			}
		}

		private void textBox1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				string taskName = textBox1.Text.Trim();
				if (taskName == "")
					return;
				TaskItem task = new TaskItem();
				task.Name = taskName;
				task.Completed = false;
				tasks.Add(task);
				checkedListBox1.Items.Add(taskName);
				CreateTaskBox(task);
				textBox1.Clear();
				UpdateProgress();
			}
		}

		private void button13_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd =
		new OpenFileDialog();
			ofd.Filter =
				"Text Files (*.txt)|*.txt";
			if (ofd.ShowDialog() != DialogResult.OK)
				return;
			string[] lines =
				File.ReadAllLines(ofd.FileName);

			foreach (string line in lines)
			{
				if (string.IsNullOrWhiteSpace(line))
					continue;
				TaskItem task = new TaskItem();
				task.Name = line;
				task.Completed = false;
				tasks.Add(task);
				checkedListBox1.Items.Add(task.Name);
				CreateTaskBox(task);
			}
		}

		private void button16_Click(object sender, EventArgs e)
		{
			tabControl1.SelectedIndex = 2; 
		}

		private void button8_Click(object sender, EventArgs e)
		{
			button17.PerformClick(); 
			TruyenForm2+= $"Xuất phiên làm việc , thời gian tạm tính là {label19.Text} vào {DateTime.Now}\n";
			Form2 form2 = new Form2(_username, _nickname, TruyenForm2);
			form2.Show();
		}

		private void button17_Click(object sender, EventArgs e)
		{
			TruyenForm2+= "--------------------------------\n";
			TruyenForm2 += $"Tên người dùng : {_username}\n";
			TruyenForm2 +=
		$"Tên phiên : {TenPhien.Text}\n";
			TruyenForm2 +=
				$"Chi tiết  : {Details.Text}\n";
			TruyenForm2 +=
				$"Thời gian : {label19.Text}\n";
			TruyenForm2 +=
				"\n--------------------------------\n\n";
			foreach (TaskItem task in tasks)
			{
				TruyenForm2 +=
					$"{task.Name}\n";
				TruyenForm2 +=
					$"     Trạng thái : {(task.Completed ? "Hoàn Thành" : "Chưa Hoàn Thành")}\n";
				TruyenForm2 +=
					$"     Thời gian  : {(string.IsNullOrEmpty(task.WorkTime) ? label19.Text : task.WorkTime)}\n";
				TruyenForm2 +=
					$"     Ghi chú    : {(string.IsNullOrEmpty(task.Note) ? "Không có" : task.Note)}\n\n";
			}
			richTextBox1.Text = TruyenForm2;
		}
	}
}
