namespace Kursach2020
{
	partial class FormInsertReq
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
			this.label11 = new System.Windows.Forms.Label();
			this.stateField = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.descriptionField = new System.Windows.Forms.TextBox();
			this.priceField = new System.Windows.Forms.TextBox();
			this.roomsField = new System.Windows.Forms.TextBox();
			this.sendButton = new System.Windows.Forms.Button();
			this.shDecsLabel = new System.Windows.Forms.Label();
			this.shortDescField = new System.Windows.Forms.TextBox();
			this.cityBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label11.Location = new System.Drawing.Point(395, 155);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(17, 18);
			this.label11.TabIndex = 39;
			this.label11.Text = "Т";
			// 
			// stateField
			// 
			this.stateField.Font = new System.Drawing.Font("Arial", 12F);
			this.stateField.FormattingEnabled = true;
			this.stateField.Items.AddRange(new object[] {
            "Хорошее",
            "Среднее",
            "Евроремонт"});
			this.stateField.Location = new System.Drawing.Point(75, 152);
			this.stateField.Name = "stateField";
			this.stateField.Size = new System.Drawing.Size(141, 26);
			this.stateField.TabIndex = 38;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label10.Location = new System.Drawing.Point(72, 131);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(87, 18);
			this.label10.TabIndex = 37;
			this.label10.Text = "Состояние";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label9.Location = new System.Drawing.Point(72, 188);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(78, 18);
			this.label9.TabIndex = 36;
			this.label9.Text = "Описание";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label8.Location = new System.Drawing.Point(245, 131);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(46, 18);
			this.label8.TabIndex = 35;
			this.label8.Text = "Цена";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(245, 72);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(61, 18);
			this.label5.TabIndex = 32;
			this.label5.Text = "Комнат";
			// 
			// descriptionField
			// 
			this.descriptionField.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.descriptionField.Location = new System.Drawing.Point(75, 209);
			this.descriptionField.Multiline = true;
			this.descriptionField.Name = "descriptionField";
			this.descriptionField.Size = new System.Drawing.Size(421, 229);
			this.descriptionField.TabIndex = 26;
			// 
			// priceField
			// 
			this.priceField.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.priceField.Location = new System.Drawing.Point(248, 152);
			this.priceField.Name = "priceField";
			this.priceField.Size = new System.Drawing.Size(141, 26);
			this.priceField.TabIndex = 25;
			// 
			// roomsField
			// 
			this.roomsField.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.roomsField.Location = new System.Drawing.Point(248, 93);
			this.roomsField.Name = "roomsField";
			this.roomsField.Size = new System.Drawing.Size(59, 26);
			this.roomsField.TabIndex = 23;
			// 
			// sendButton
			// 
			this.sendButton.Font = new System.Drawing.Font("Arial", 12F);
			this.sendButton.Location = new System.Drawing.Point(376, 444);
			this.sendButton.Name = "sendButton";
			this.sendButton.Size = new System.Drawing.Size(120, 29);
			this.sendButton.TabIndex = 40;
			this.sendButton.Text = "Отправить";
			this.sendButton.UseVisualStyleBackColor = true;
			this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
			// 
			// shDecsLabel
			// 
			this.shDecsLabel.AutoSize = true;
			this.shDecsLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.shDecsLabel.Location = new System.Drawing.Point(72, 18);
			this.shDecsLabel.Name = "shDecsLabel";
			this.shDecsLabel.Size = new System.Drawing.Size(147, 18);
			this.shDecsLabel.TabIndex = 42;
			this.shDecsLabel.Text = "Короткое название";
			// 
			// shortDescField
			// 
			this.shortDescField.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.shortDescField.Location = new System.Drawing.Point(75, 39);
			this.shortDescField.Name = "shortDescField";
			this.shortDescField.Size = new System.Drawing.Size(421, 26);
			this.shortDescField.TabIndex = 41;
			// 
			// cityBox
			// 
			this.cityBox.Font = new System.Drawing.Font("Arial", 12F);
			this.cityBox.FormattingEnabled = true;
			this.cityBox.Items.AddRange(new object[] {
            "Хорошее",
            "Среднее",
            "Евроремонт"});
			this.cityBox.Location = new System.Drawing.Point(75, 93);
			this.cityBox.Name = "cityBox";
			this.cityBox.Size = new System.Drawing.Size(141, 26);
			this.cityBox.TabIndex = 44;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(72, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 18);
			this.label1.TabIndex = 43;
			this.label1.Text = "Город";
			// 
			// FormInsertReq
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(541, 500);
			this.Controls.Add(this.cityBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.shDecsLabel);
			this.Controls.Add(this.shortDescField);
			this.Controls.Add(this.sendButton);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.stateField);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.descriptionField);
			this.Controls.Add(this.priceField);
			this.Controls.Add(this.roomsField);
			this.Name = "FormInsertReq";
			this.Text = "FormInsertReq";
			this.Load += new System.EventHandler(this.FormInsertReq_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox stateField;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox descriptionField;
		private System.Windows.Forms.TextBox priceField;
		private System.Windows.Forms.TextBox roomsField;
		private System.Windows.Forms.Button sendButton;
		private System.Windows.Forms.Label shDecsLabel;
		private System.Windows.Forms.TextBox shortDescField;
		private System.Windows.Forms.ComboBox cityBox;
		private System.Windows.Forms.Label label1;
	}
}