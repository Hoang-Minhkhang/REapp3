namespace REapp3
{
	partial class Windows2
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Windows2));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.windows2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.usernameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.DiaChiThanh = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.webView22 = new Microsoft.Web.WebView2.WinForms.WebView2();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.webView22)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.windows2ToolStripMenuItem,
            this.usernameToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1148, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// windows2ToolStripMenuItem
			// 
			this.windows2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.eXITToolStripMenuItem});
			this.windows2ToolStripMenuItem.Name = "windows2ToolStripMenuItem";
			this.windows2ToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
			this.windows2ToolStripMenuItem.Text = "Windows 2 ";
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.settingsToolStripMenuItem.Text = "Settings";
			// 
			// eXITToolStripMenuItem
			// 
			this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
			this.eXITToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.eXITToolStripMenuItem.Text = "EXIT";
			// 
			// usernameToolStripMenuItem
			// 
			this.usernameToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.usernameToolStripMenuItem.Name = "usernameToolStripMenuItem";
			this.usernameToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
			this.usernameToolStripMenuItem.Text = "Username";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 24);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1148, 602);
			this.tabControl1.TabIndex = 1;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.webView21);
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1140, 576);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "WEB broswer";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// webView21
			// 
			this.webView21.AllowExternalDrop = true;
			this.webView21.CreationProperties = null;
			this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
			this.webView21.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webView21.Location = new System.Drawing.Point(3, 64);
			this.webView21.Name = "webView21";
			this.webView21.Size = new System.Drawing.Size(1134, 509);
			this.webView21.TabIndex = 2;
			this.webView21.ZoomFactor = 1D;
			this.webView21.SourceChanged += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs>(this.webView21_SourceChanged_1);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.DiaChiThanh);
			this.groupBox1.Controls.Add(this.button3);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1134, 61);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Tool";
			// 
			// DiaChiThanh
			// 
			this.DiaChiThanh.Location = new System.Drawing.Point(168, 22);
			this.DiaChiThanh.Name = "DiaChiThanh";
			this.DiaChiThanh.Size = new System.Drawing.Size(775, 20);
			this.DiaChiThanh.TabIndex = 3;
			this.DiaChiThanh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DiaChiThanh_KeyDown_1);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Location = new System.Drawing.Point(957, 19);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 2;
			this.button3.Text = "GOOO";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new System.Drawing.Point(87, 19);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "Continue";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click_1);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.LightCoral;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(6, 19);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "BACK";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.webView22);
			this.tabPage2.Controls.Add(this.groupBox2);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1140, 576);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "PDF PRINTPRE";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// webView22
			// 
			this.webView22.AllowExternalDrop = true;
			this.webView22.CreationProperties = null;
			this.webView22.DefaultBackgroundColor = System.Drawing.Color.White;
			this.webView22.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webView22.Location = new System.Drawing.Point(3, 74);
			this.webView22.Name = "webView22";
			this.webView22.Size = new System.Drawing.Size(1134, 499);
			this.webView22.TabIndex = 1;
			this.webView22.ZoomFactor = 1D;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.button6);
			this.groupBox2.Controls.Add(this.button5);
			this.groupBox2.Controls.Add(this.button4);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox2.Location = new System.Drawing.Point(3, 3);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(1134, 71);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Tool";
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.Yellow;
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.Location = new System.Drawing.Point(235, 16);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(103, 55);
			this.button6.TabIndex = 2;
			this.button6.Text = "Open File ";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.Location = new System.Drawing.Point(126, 16);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(103, 55);
			this.button5.TabIndex = 1;
			this.button5.Text = "Sign";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(17, 16);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(103, 55);
			this.button4.TabIndex = 0;
			this.button4.Text = "Print ";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.MistyRose;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(415, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(356, 18);
			this.label1.TabIndex = 3;
			this.label1.Text = "Your computer must install Webview2 before using it ";
			// 
			// Windows2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1148, 626);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Windows2";
			this.Text = "Windows2";
			this.Load += new System.EventHandler(this.Windows2_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.webView22)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem windows2ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.ToolStripMenuItem usernameToolStripMenuItem;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox DiaChiThanh;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private Microsoft.Web.WebView2.WinForms.WebView2 webView22;
		private System.Windows.Forms.Label label1;
	}
}