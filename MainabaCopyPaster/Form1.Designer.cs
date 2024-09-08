namespace MainabaCopyPaster
{
	partial class Form1
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
			textBox1 = new TextBox();
			button1 = new Button();
			label1 = new Label();
			comboBox1 = new ComboBox();
			comboBox2 = new ComboBox();
			SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.Location = new Point(8, 31);
			textBox1.Margin = new Padding(2, 2, 2, 2);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(283, 23);
			textBox1.TabIndex = 0;
			// 
			// button1
			// 
			button1.Location = new Point(73, 76);
			button1.Margin = new Padding(2, 2, 2, 2);
			button1.Name = "button1";
			button1.Size = new Size(144, 29);
			button1.TabIndex = 2;
			button1.Text = "次へ";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(8, 14);
			label1.Margin = new Padding(2, 0, 2, 0);
			label1.Name = "label1";
			label1.Size = new Size(43, 15);
			label1.TabIndex = 3;
			label1.Text = "案件名";
			// 
			// comboBox1
			// 
			comboBox1.FormattingEnabled = true;
			comboBox1.Items.AddRange(new object[] { "テスト", "本番" });
			comboBox1.Location = new Point(8, 53);
			comboBox1.Margin = new Padding(2, 2, 2, 2);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(73, 23);
			comboBox1.TabIndex = 4;
			comboBox1.Text = "テスト";
			// 
			// comboBox2
			// 
			comboBox2.FormattingEnabled = true;
			comboBox2.Items.AddRange(new object[] { "", "_Front", "_w2cManager", "_w2cmsManager", "_w2csManager", "_w2mpManager", "_webapi", "CustomerResources" });
			comboBox2.Location = new Point(84, 53);
			comboBox2.Margin = new Padding(2, 2, 2, 2);
			comboBox2.Name = "comboBox2";
			comboBox2.Size = new Size(207, 23);
			comboBox2.TabIndex = 5;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(298, 117);
			Controls.Add(comboBox1);
			Controls.Add(label1);
			Controls.Add(button1);
			Controls.Add(textBox1);
			Controls.Add(comboBox2);
			Margin = new Padding(2, 2, 2, 2);
			Name = "Form1";
			Text = "ファイル設定";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox1;
		private Button button1;
		private Label label1;
		private ComboBox comboBox1;
		private ComboBox comboBox2;
	}
}
