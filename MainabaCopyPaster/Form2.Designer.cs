namespace MainabaCopyPaster
{
	partial class Form2
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			button1 = new Button();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			textBox1 = new TextBox();
			button2 = new Button();
			checkBox1 = new CheckBox();
			textBox2 = new TextBox();
			button3 = new Button();
			button4 = new Button();
			button5 = new Button();
			textBox3 = new TextBox();
			button6 = new Button();
			checkBox2 = new CheckBox();
			SuspendLayout();
			// 
			// button1
			// 
			button1.Location = new Point(12, 101);
			button1.Name = "button1";
			button1.Size = new Size(205, 86);
			button1.TabIndex = 2;
			button1.Text = "ファイルパス読み込み";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 9);
			label1.Name = "label1";
			label1.Size = new Size(343, 25);
			label1.TabIndex = 3;
			label1.Text = "C:\\vuptemp\\XXX\\current_honban\\_Front";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 36);
			label2.Name = "label2";
			label2.Size = new Size(396, 25);
			label2.TabIndex = 4;
			label2.Text = "C:\\vuptemp\\XXX\\更新用ファイル-Honban\\_Front";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(-4, 21);
			label3.Name = "label3";
			label3.Size = new Size(0, 25);
			label3.TabIndex = 5;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(12, 64);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(1042, 31);
			textBox1.TabIndex = 6;
			textBox1.Text = "\\XXX\\xxx.liquid";
			// 
			// button2
			// 
			button2.Location = new Point(240, 141);
			button2.Name = "button2";
			button2.Size = new Size(601, 46);
			button2.TabIndex = 8;
			button2.Text = "更新用ファイル作成";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// checkBox1
			// 
			checkBox1.AutoSize = true;
			checkBox1.Checked = true;
			checkBox1.CheckState = CheckState.Checked;
			checkBox1.Location = new Point(867, 158);
			checkBox1.Name = "checkBox1";
			checkBox1.Size = new Size(134, 29);
			checkBox1.TabIndex = 9;
			checkBox1.Text = "エディタで開く";
			checkBox1.UseVisualStyleBackColor = true;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(12, 230);
			textBox2.Multiline = true;
			textBox2.Name = "textBox2";
			textBox2.ReadOnly = true;
			textBox2.ScrollBars = ScrollBars.Vertical;
			textBox2.Size = new Size(1042, 58);
			textBox2.TabIndex = 10;
			// 
			// button3
			// 
			button3.Location = new Point(458, 101);
			button3.Name = "button3";
			button3.Size = new Size(265, 33);
			button3.TabIndex = 11;
			button3.Text = "手動マージファイル出力";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// button4
			// 
			button4.Location = new Point(729, 101);
			button4.Name = "button4";
			button4.Size = new Size(112, 33);
			button4.TabIndex = 12;
			button4.Text = "ログコピー";
			button4.UseVisualStyleBackColor = true;
			button4.Click += button4_Click;
			// 
			// button5
			// 
			button5.Location = new Point(240, 101);
			button5.Name = "button5";
			button5.Size = new Size(34, 34);
			button5.TabIndex = 13;
			button5.Text = "C";
			button5.UseVisualStyleBackColor = true;
			button5.Click += button5_Click;
			// 
			// textBox3
			// 
			textBox3.BackColor = SystemColors.ButtonFace;
			textBox3.ForeColor = Color.Red;
			textBox3.Location = new Point(12, 193);
			textBox3.Name = "textBox3";
			textBox3.ReadOnly = true;
			textBox3.Size = new Size(1042, 31);
			textBox3.TabIndex = 14;
			textBox3.Text = "ファイルパスを読み込んでください";
			// 
			// button6
			// 
			button6.Location = new Point(280, 102);
			button6.Name = "button6";
			button6.Size = new Size(172, 32);
			button6.TabIndex = 15;
			button6.Text = "WinMerge";
			button6.UseVisualStyleBackColor = true;
			button6.Click += button6_Click;
			// 
			// checkBox2
			// 
			checkBox2.AutoSize = true;
			checkBox2.Checked = true;
			checkBox2.CheckState = CheckState.Checked;
			checkBox2.Location = new Point(867, 106);
			checkBox2.Name = "checkBox2";
			checkBox2.Size = new Size(153, 29);
			checkBox2.TabIndex = 16;
			checkBox2.Text = "画面に固定する";
			checkBox2.UseVisualStyleBackColor = true;
			checkBox2.CheckedChanged += checkBox2_CheckedChanged;
			// 
			// Form2
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1069, 297);
			Controls.Add(checkBox2);
			Controls.Add(button6);
			Controls.Add(textBox3);
			Controls.Add(button5);
			Controls.Add(button4);
			Controls.Add(button3);
			Controls.Add(textBox2);
			Controls.Add(checkBox1);
			Controls.Add(button2);
			Controls.Add(textBox1);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(button1);
			Name = "Form2";
			Text = "更新用ファイル作成";
			TopMost = true;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Button button1;
		private Label label1;
		private Label label2;
		private Label label3;
		private TextBox textBox1;
		private Button button2;
		private CheckBox checkBox1;
		private TextBox textBox2;
		private Button button3;
		private Button button4;
		private Button button5;
		private TextBox textBox3;
		private Button button6;
		private CheckBox checkBox2;
	}
}
