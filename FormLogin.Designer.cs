namespace Kursach2020
{
	partial class FormLogin
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.loginButton = new System.Windows.Forms.Button();
			this.loginField = new System.Windows.Forms.TextBox();
			this.passField = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// loginButton
			// 
			this.loginButton.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.loginButton.Location = new System.Drawing.Point(127, 290);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(120, 50);
			this.loginButton.TabIndex = 0;
			this.loginButton.Text = "Войти";
			this.loginButton.UseVisualStyleBackColor = true;
			this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
			// 
			// loginField
			// 
			this.loginField.Font = new System.Drawing.Font("Arial", 16F);
			this.loginField.Location = new System.Drawing.Point(89, 129);
			this.loginField.Name = "loginField";
			this.loginField.Size = new System.Drawing.Size(200, 32);
			this.loginField.TabIndex = 1;
			// 
			// passField
			// 
			this.passField.Font = new System.Drawing.Font("Arial", 16F);
			this.passField.Location = new System.Drawing.Point(89, 222);
			this.passField.Name = "passField";
			this.passField.PasswordChar = '*';
			this.passField.Size = new System.Drawing.Size(200, 32);
			this.passField.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(110, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(154, 27);
			this.label1.TabIndex = 3;
			this.label1.Text = "Авторизация";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(85, 102);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 24);
			this.label2.TabIndex = 4;
			this.label2.Text = "Логин";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(85, 195);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 24);
			this.label3.TabIndex = 5;
			this.label3.Text = "Пароль";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial", 12F);
			this.label4.Location = new System.Drawing.Point(112, 366);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(160, 18);
			this.label4.TabIndex = 6;
			this.label4.Text = "Зарегистрироваться";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// FormLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 411);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.passField);
			this.Controls.Add(this.loginField);
			this.Controls.Add(this.loginButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximumSize = new System.Drawing.Size(400, 450);
			this.MinimumSize = new System.Drawing.Size(400, 450);
			this.Name = "FormLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLogin_FormClosed);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button loginButton;
		private System.Windows.Forms.TextBox loginField;
		private System.Windows.Forms.TextBox passField;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
	}
}

