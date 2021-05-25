namespace Kursach2020
{
	partial class FormMain
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
			this.requests = new System.Windows.Forms.Label();
			this.proposition = new System.Windows.Forms.Label();
			this.adminModerationRequest = new System.Windows.Forms.Label();
			this.adminModerationProps = new System.Windows.Forms.Label();
			this.topLabel = new System.Windows.Forms.Label();
			this.createRequest = new System.Windows.Forms.Label();
			this.createProp = new System.Windows.Forms.Label();
			this.adminReqWait = new System.Windows.Forms.Label();
			this.adminPropsWait = new System.Windows.Forms.Label();
			this.messagesWait = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// requests
			// 
			this.requests.AutoSize = true;
			this.requests.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.requests.Location = new System.Drawing.Point(66, 134);
			this.requests.Name = "requests";
			this.requests.Size = new System.Drawing.Size(136, 24);
			this.requests.TabIndex = 0;
			this.requests.Text = "Просмотреть";
			this.requests.Click += new System.EventHandler(this.requests_Click);
			// 
			// proposition
			// 
			this.proposition.AutoSize = true;
			this.proposition.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.proposition.Location = new System.Drawing.Point(512, 134);
			this.proposition.Name = "proposition";
			this.proposition.Size = new System.Drawing.Size(136, 24);
			this.proposition.TabIndex = 1;
			this.proposition.Text = "Просмотреть";
			this.proposition.Click += new System.EventHandler(this.proposition_Click);
			// 
			// adminModerationRequest
			// 
			this.adminModerationRequest.AutoSize = true;
			this.adminModerationRequest.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.adminModerationRequest.Location = new System.Drawing.Point(30, 251);
			this.adminModerationRequest.Name = "adminModerationRequest";
			this.adminModerationRequest.Size = new System.Drawing.Size(193, 24);
			this.adminModerationRequest.TabIndex = 2;
			this.adminModerationRequest.Text = "Модерация спроса";
			this.adminModerationRequest.Visible = false;
			this.adminModerationRequest.Click += new System.EventHandler(this.adminModerationRequest_Click);
			// 
			// adminModerationProps
			// 
			this.adminModerationProps.AutoSize = true;
			this.adminModerationProps.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.adminModerationProps.Location = new System.Drawing.Point(471, 251);
			this.adminModerationProps.Name = "adminModerationProps";
			this.adminModerationProps.Size = new System.Drawing.Size(253, 24);
			this.adminModerationProps.TabIndex = 3;
			this.adminModerationProps.Text = "Модерация предложений";
			this.adminModerationProps.Visible = false;
			this.adminModerationProps.Click += new System.EventHandler(this.adminModerationProps_Click);
			// 
			// topLabel
			// 
			this.topLabel.AutoSize = true;
			this.topLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.topLabel.Location = new System.Drawing.Point(277, 9);
			this.topLabel.Name = "topLabel";
			this.topLabel.Size = new System.Drawing.Size(200, 32);
			this.topLabel.TabIndex = 4;
			this.topLabel.Text = "Что вам нужно";
			// 
			// createRequest
			// 
			this.createRequest.AutoSize = true;
			this.createRequest.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.createRequest.Location = new System.Drawing.Point(66, 172);
			this.createRequest.Name = "createRequest";
			this.createRequest.Size = new System.Drawing.Size(92, 24);
			this.createRequest.TabIndex = 5;
			this.createRequest.Text = "Создать";
			this.createRequest.Click += new System.EventHandler(this.createRequest_Click);
			// 
			// createProp
			// 
			this.createProp.AutoSize = true;
			this.createProp.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.createProp.Location = new System.Drawing.Point(512, 172);
			this.createProp.Name = "createProp";
			this.createProp.Size = new System.Drawing.Size(92, 24);
			this.createProp.TabIndex = 6;
			this.createProp.Text = "Создать";
			this.createProp.Click += new System.EventHandler(this.createProp_Click);
			// 
			// adminReqWait
			// 
			this.adminReqWait.AutoSize = true;
			this.adminReqWait.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.adminReqWait.Location = new System.Drawing.Point(30, 286);
			this.adminReqWait.Name = "adminReqWait";
			this.adminReqWait.Size = new System.Drawing.Size(107, 24);
			this.adminReqWait.TabIndex = 7;
			this.adminReqWait.Text = "Ожидают:";
			this.adminReqWait.Visible = false;
			// 
			// adminPropsWait
			// 
			this.adminPropsWait.AutoSize = true;
			this.adminPropsWait.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.adminPropsWait.Location = new System.Drawing.Point(471, 286);
			this.adminPropsWait.Name = "adminPropsWait";
			this.adminPropsWait.Size = new System.Drawing.Size(107, 24);
			this.adminPropsWait.TabIndex = 8;
			this.adminPropsWait.Text = "Ожидают:";
			this.adminPropsWait.Visible = false;
			// 
			// messagesWait
			// 
			this.messagesWait.AutoSize = true;
			this.messagesWait.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.messagesWait.Location = new System.Drawing.Point(601, 17);
			this.messagesWait.Name = "messagesWait";
			this.messagesWait.Size = new System.Drawing.Size(128, 24);
			this.messagesWait.TabIndex = 9;
			this.messagesWait.Text = "Сообщений:";
			this.messagesWait.Click += new System.EventHandler(this.messagesWait_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(29, 95);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(217, 27);
			this.label1.TabIndex = 10;
			this.label1.Text = "Квартирный спрос";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(470, 95);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(259, 27);
			this.label2.TabIndex = 11;
			this.label2.Text = "Предложения квартир";
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(786, 358);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.messagesWait);
			this.Controls.Add(this.adminPropsWait);
			this.Controls.Add(this.adminReqWait);
			this.Controls.Add(this.createProp);
			this.Controls.Add(this.createRequest);
			this.Controls.Add(this.topLabel);
			this.Controls.Add(this.adminModerationProps);
			this.Controls.Add(this.adminModerationRequest);
			this.Controls.Add(this.proposition);
			this.Controls.Add(this.requests);
			this.Name = "FormMain";
			this.Text = "Главная страница";
			this.Activated += new System.EventHandler(this.FormMain_Activated);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label requests;
		private System.Windows.Forms.Label proposition;
		private System.Windows.Forms.Label adminModerationRequest;
		private System.Windows.Forms.Label adminModerationProps;
		private System.Windows.Forms.Label topLabel;
		private System.Windows.Forms.Label createRequest;
		private System.Windows.Forms.Label createProp;
		private System.Windows.Forms.Label adminReqWait;
		private System.Windows.Forms.Label adminPropsWait;
		private System.Windows.Forms.Label messagesWait;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}