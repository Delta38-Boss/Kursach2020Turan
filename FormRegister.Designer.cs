namespace Kursach2020
{
	partial class FormRegister
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
			this.registerButton = new System.Windows.Forms.Button();
			this.nameField = new System.Windows.Forms.TextBox();
			this.surnameField = new System.Windows.Forms.TextBox();
			this.loginField = new System.Windows.Forms.TextBox();
			this.passField = new System.Windows.Forms.TextBox();
			this.repassField = new System.Windows.Forms.TextBox();
			this.emailField = new System.Windows.Forms.TextBox();
			this.phoneField = new System.Windows.Forms.TextBox();
			this.radioMale = new System.Windows.Forms.RadioButton();
			this.radioFemale = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// registerButton
			// 
			this.registerButton.Font = new System.Drawing.Font("Arial", 14F);
			this.registerButton.Location = new System.Drawing.Point(198, 399);
			this.registerButton.Name = "registerButton";
			this.registerButton.Size = new System.Drawing.Size(240, 50);
			this.registerButton.TabIndex = 0;
			this.registerButton.Text = "Зарегестрироваться";
			this.registerButton.UseVisualStyleBackColor = true;
			this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
			// 
			// nameField
			// 
			this.nameField.Font = new System.Drawing.Font("Arial", 12F);
			this.nameField.Location = new System.Drawing.Point(398, 80);
			this.nameField.Name = "nameField";
			this.nameField.Size = new System.Drawing.Size(220, 26);
			this.nameField.TabIndex = 1;
			// 
			// surnameField
			// 
			this.surnameField.Font = new System.Drawing.Font("Arial", 12F);
			this.surnameField.Location = new System.Drawing.Point(398, 148);
			this.surnameField.Name = "surnameField";
			this.surnameField.Size = new System.Drawing.Size(220, 26);
			this.surnameField.TabIndex = 2;
			// 
			// loginField
			// 
			this.loginField.Font = new System.Drawing.Font("Arial", 12F);
			this.loginField.Location = new System.Drawing.Point(31, 80);
			this.loginField.Name = "loginField";
			this.loginField.Size = new System.Drawing.Size(220, 26);
			this.loginField.TabIndex = 3;
			// 
			// passField
			// 
			this.passField.Font = new System.Drawing.Font("Arial", 12F);
			this.passField.Location = new System.Drawing.Point(31, 144);
			this.passField.Name = "passField";
			this.passField.PasswordChar = '*';
			this.passField.Size = new System.Drawing.Size(220, 26);
			this.passField.TabIndex = 4;
			// 
			// repassField
			// 
			this.repassField.Font = new System.Drawing.Font("Arial", 12F);
			this.repassField.Location = new System.Drawing.Point(31, 215);
			this.repassField.Name = "repassField";
			this.repassField.PasswordChar = '*';
			this.repassField.Size = new System.Drawing.Size(220, 26);
			this.repassField.TabIndex = 5;
			// 
			// emailField
			// 
			this.emailField.Font = new System.Drawing.Font("Arial", 12F);
			this.emailField.Location = new System.Drawing.Point(398, 219);
			this.emailField.Name = "emailField";
			this.emailField.Size = new System.Drawing.Size(220, 26);
			this.emailField.TabIndex = 6;
			// 
			// phoneField
			// 
			this.phoneField.Font = new System.Drawing.Font("Arial", 12F);
			this.phoneField.Location = new System.Drawing.Point(398, 292);
			this.phoneField.Name = "phoneField";
			this.phoneField.Size = new System.Drawing.Size(220, 26);
			this.phoneField.TabIndex = 7;
			// 
			// radioMale
			// 
			this.radioMale.AutoSize = true;
			this.radioMale.Checked = true;
			this.radioMale.Font = new System.Drawing.Font("Arial", 12F);
			this.radioMale.Location = new System.Drawing.Point(6, 28);
			this.radioMale.Name = "radioMale";
			this.radioMale.Size = new System.Drawing.Size(60, 22);
			this.radioMale.TabIndex = 8;
			this.radioMale.TabStop = true;
			this.radioMale.Text = "Муж.";
			this.radioMale.UseVisualStyleBackColor = true;
			// 
			// radioFemale
			// 
			this.radioFemale.AutoSize = true;
			this.radioFemale.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.radioFemale.Location = new System.Drawing.Point(6, 56);
			this.radioFemale.Name = "radioFemale";
			this.radioFemale.Size = new System.Drawing.Size(61, 22);
			this.radioFemale.TabIndex = 9;
			this.radioFemale.Text = "Жен.";
			this.radioFemale.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 16F);
			this.label1.Location = new System.Drawing.Point(253, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(140, 25);
			this.label1.TabIndex = 10;
			this.label1.Text = "Регистрация";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioMale);
			this.groupBox1.Controls.Add(this.radioFemale);
			this.groupBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox1.Location = new System.Drawing.Point(31, 268);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(83, 95);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Пол";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 14F);
			this.label2.Location = new System.Drawing.Point(396, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 22);
			this.label2.TabIndex = 12;
			this.label2.Text = "Имя";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 14F);
			this.label3.Location = new System.Drawing.Point(396, 123);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(87, 22);
			this.label3.TabIndex = 13;
			this.label3.Text = "Фамилия";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial", 14F);
			this.label4.Location = new System.Drawing.Point(394, 194);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(57, 22);
			this.label4.TabIndex = 14;
			this.label4.Text = "Email";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial", 14F);
			this.label5.Location = new System.Drawing.Point(394, 263);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(89, 22);
			this.label5.TabIndex = 15;
			this.label5.Text = "Телефон";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Arial", 14F);
			this.label6.Location = new System.Drawing.Point(27, 55);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(60, 22);
			this.label6.TabIndex = 16;
			this.label6.Text = "Логин";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Arial", 14F);
			this.label7.Location = new System.Drawing.Point(27, 119);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(76, 22);
			this.label7.TabIndex = 17;
			this.label7.Text = "Пароль";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Arial", 14F);
			this.label8.Location = new System.Drawing.Point(27, 190);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(170, 22);
			this.label8.TabIndex = 18;
			this.label8.Text = "Повторите пароль";
			// 
			// FormRegister
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(652, 461);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.phoneField);
			this.Controls.Add(this.emailField);
			this.Controls.Add(this.repassField);
			this.Controls.Add(this.passField);
			this.Controls.Add(this.loginField);
			this.Controls.Add(this.surnameField);
			this.Controls.Add(this.nameField);
			this.Controls.Add(this.registerButton);
			this.MaximumSize = new System.Drawing.Size(668, 500);
			this.MinimumSize = new System.Drawing.Size(668, 500);
			this.Name = "FormRegister";
			this.Text = "FormRegister";
			this.Load += new System.EventHandler(this.FormRegister_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button registerButton;
		private System.Windows.Forms.TextBox nameField;
		private System.Windows.Forms.TextBox surnameField;
		private System.Windows.Forms.TextBox loginField;
		private System.Windows.Forms.TextBox passField;
		private System.Windows.Forms.TextBox repassField;
		private System.Windows.Forms.TextBox emailField;
		private System.Windows.Forms.TextBox phoneField;
		private System.Windows.Forms.RadioButton radioMale;
		private System.Windows.Forms.RadioButton radioFemale;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
	}
}