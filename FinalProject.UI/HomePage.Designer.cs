namespace FinalProject.UI
{
	partial class HomePage
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
			registration_btn = new Button();
			label_email = new Label();
			label_password = new Label();
			textBox_email = new TextBox();
			textBox_password = new TextBox();
			label_error = new Label();
			SuspendLayout();
			// 
			// registration_btn
			// 
			registration_btn.Location = new Point(184, 223);
			registration_btn.Name = "registration_btn";
			registration_btn.Size = new Size(115, 43);
			registration_btn.TabIndex = 0;
			registration_btn.Text = "Log in / Register";
			registration_btn.UseVisualStyleBackColor = true;
			registration_btn.Click += Login_Click;
			// 
			// label_email
			// 
			label_email.AutoSize = true;
			label_email.Location = new Point(222, 69);
			label_email.Name = "label_email";
			label_email.Size = new Size(36, 15);
			label_email.TabIndex = 1;
			label_email.Text = "email";
			// 
			// label_password
			// 
			label_password.AutoSize = true;
			label_password.Location = new Point(213, 152);
			label_password.Name = "label_password";
			label_password.Size = new Size(57, 15);
			label_password.TabIndex = 2;
			label_password.Text = "Password";
			// 
			// textBox_email
			// 
			textBox_email.Location = new Point(135, 96);
			textBox_email.Name = "textBox_email";
			textBox_email.Size = new Size(213, 23);
			textBox_email.TabIndex = 3;
			// 
			// textBox_password
			// 
			textBox_password.Location = new Point(135, 170);
			textBox_password.Name = "textBox_password";
			textBox_password.Size = new Size(213, 23);
			textBox_password.TabIndex = 4;
			// 
			// label_error
			// 
			label_error.AutoSize = true;
			label_error.ForeColor = Color.Red;
			label_error.Location = new Point(164, 279);
			label_error.Name = "label_error";
			label_error.Size = new Size(0, 15);
			label_error.TabIndex = 5;
			// 
			// HomePage
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(500, 339);
			Controls.Add(label_error);
			Controls.Add(textBox_password);
			Controls.Add(textBox_email);
			Controls.Add(label_password);
			Controls.Add(label_email);
			Controls.Add(registration_btn);
			Name = "HomePage";
			Text = "shop";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button registration_btn;
		private Label label_email;
		private Label label_password;
		private TextBox textBox_email;
		private TextBox textBox_password;
		private Label label_error;
	}
}
