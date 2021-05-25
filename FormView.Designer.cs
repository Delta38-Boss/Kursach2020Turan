namespace Kursach2020
{
	partial class FormView
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
			this.SearchButton = new System.Windows.Forms.Button();
			this.topLabel = new System.Windows.Forms.Label();
			this.roomsField = new System.Windows.Forms.TextBox();
			this.priceMinField = new System.Windows.Forms.TextBox();
			this.priceLabel = new System.Windows.Forms.Label();
			this.roomsLabel = new System.Windows.Forms.Label();
			this.priceMaxField = new System.Windows.Forms.TextBox();
			this.toPriceLabel = new System.Windows.Forms.Label();
			this.searchLabel = new System.Windows.Forms.Label();
			this.createButton = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.custOwn = new System.Windows.Forms.Label();
			this.rooms = new System.Windows.Forms.Label();
			this.state = new System.Windows.Forms.Label();
			this.floors = new System.Windows.Forms.Label();
			this.description = new System.Windows.Forms.Label();
			this.contacts = new System.Windows.Forms.Label();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.price = new System.Windows.Forms.Label();
			this.dataLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cityBox = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.onlyMyBox = new System.Windows.Forms.CheckBox();
			this.changePostButton = new System.Windows.Forms.Button();
			this.changeToDeniedButton = new System.Windows.Forms.Button();
			this.deleteButton = new System.Windows.Forms.Button();
			this.namePost = new System.Windows.Forms.Label();
			this.respond = new System.Windows.Forms.Label();
			this.flowLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// SearchButton
			// 
			this.SearchButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.SearchButton.Location = new System.Drawing.Point(55, 201);
			this.SearchButton.Name = "SearchButton";
			this.SearchButton.Size = new System.Drawing.Size(102, 41);
			this.SearchButton.TabIndex = 0;
			this.SearchButton.Text = "Пойск";
			this.SearchButton.UseVisualStyleBackColor = true;
			this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
			// 
			// topLabel
			// 
			this.topLabel.AutoSize = true;
			this.topLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.topLabel.Font = new System.Drawing.Font("Arial", 16F);
			this.topLabel.Location = new System.Drawing.Point(442, 2);
			this.topLabel.Name = "topLabel";
			this.topLabel.Size = new System.Drawing.Size(114, 25);
			this.topLabel.TabIndex = 1;
			this.topLabel.Text = "Просмотр";
			this.topLabel.Click += new System.EventHandler(this.topLabel_Click);
			// 
			// roomsField
			// 
			this.roomsField.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.roomsField.Location = new System.Drawing.Point(84, 106);
			this.roomsField.Name = "roomsField";
			this.roomsField.Size = new System.Drawing.Size(42, 26);
			this.roomsField.TabIndex = 3;
			// 
			// priceMinField
			// 
			this.priceMinField.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.priceMinField.Location = new System.Drawing.Point(84, 35);
			this.priceMinField.Name = "priceMinField";
			this.priceMinField.Size = new System.Drawing.Size(125, 26);
			this.priceMinField.TabIndex = 4;
			// 
			// priceLabel
			// 
			this.priceLabel.AutoSize = true;
			this.priceLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.priceLabel.Location = new System.Drawing.Point(12, 38);
			this.priceLabel.Name = "priceLabel";
			this.priceLabel.Size = new System.Drawing.Size(66, 18);
			this.priceLabel.TabIndex = 5;
			this.priceLabel.Text = "Цена от";
			// 
			// roomsLabel
			// 
			this.roomsLabel.AutoSize = true;
			this.roomsLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.roomsLabel.Location = new System.Drawing.Point(17, 110);
			this.roomsLabel.Name = "roomsLabel";
			this.roomsLabel.Size = new System.Drawing.Size(61, 18);
			this.roomsLabel.TabIndex = 6;
			this.roomsLabel.Text = "Комнат";
			// 
			// priceMaxField
			// 
			this.priceMaxField.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.priceMaxField.Location = new System.Drawing.Point(84, 71);
			this.priceMaxField.Name = "priceMaxField";
			this.priceMaxField.Size = new System.Drawing.Size(125, 26);
			this.priceMaxField.TabIndex = 7;
			this.priceMaxField.TextChanged += new System.EventHandler(this.priceMaxField_TextChanged);
			// 
			// toPriceLabel
			// 
			this.toPriceLabel.AutoSize = true;
			this.toPriceLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toPriceLabel.Location = new System.Drawing.Point(52, 74);
			this.toPriceLabel.Name = "toPriceLabel";
			this.toPriceLabel.Size = new System.Drawing.Size(26, 18);
			this.toPriceLabel.TabIndex = 8;
			this.toPriceLabel.Text = "до";
			// 
			// searchLabel
			// 
			this.searchLabel.AutoSize = true;
			this.searchLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.searchLabel.Location = new System.Drawing.Point(75, 6);
			this.searchLabel.Name = "searchLabel";
			this.searchLabel.Size = new System.Drawing.Size(51, 18);
			this.searchLabel.TabIndex = 9;
			this.searchLabel.Text = "Пойск";
			// 
			// createButton
			// 
			this.createButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.createButton.Location = new System.Drawing.Point(55, 248);
			this.createButton.Name = "createButton";
			this.createButton.Size = new System.Drawing.Size(102, 41);
			this.createButton.TabIndex = 10;
			this.createButton.Text = "Создать";
			this.createButton.UseVisualStyleBackColor = true;
			this.createButton.Click += new System.EventHandler(this.createButton_Click);
			// 
			// listView1
			// 
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(228, 35);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(192, 407);
			this.listView1.TabIndex = 12;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Tile;
			this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
			// 
			// custOwn
			// 
			this.custOwn.AutoSize = true;
			this.custOwn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.custOwn.Location = new System.Drawing.Point(3, 0);
			this.custOwn.Name = "custOwn";
			this.custOwn.Size = new System.Drawing.Size(0, 16);
			this.custOwn.TabIndex = 0;
			// 
			// rooms
			// 
			this.rooms.AutoSize = true;
			this.rooms.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rooms.Location = new System.Drawing.Point(3, 16);
			this.rooms.Name = "rooms";
			this.rooms.Size = new System.Drawing.Size(0, 16);
			this.rooms.TabIndex = 1;
			// 
			// state
			// 
			this.state.AutoSize = true;
			this.state.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.state.Location = new System.Drawing.Point(3, 32);
			this.state.Name = "state";
			this.state.Size = new System.Drawing.Size(0, 16);
			this.state.TabIndex = 2;
			// 
			// floors
			// 
			this.floors.AutoSize = true;
			this.floors.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.floors.Location = new System.Drawing.Point(3, 48);
			this.floors.Name = "floors";
			this.floors.Size = new System.Drawing.Size(0, 16);
			this.floors.TabIndex = 3;
			// 
			// description
			// 
			this.description.AutoSize = true;
			this.description.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.description.Location = new System.Drawing.Point(3, 0);
			this.description.Name = "description";
			this.description.Size = new System.Drawing.Size(0, 16);
			this.description.TabIndex = 0;
			// 
			// contacts
			// 
			this.contacts.AutoSize = true;
			this.contacts.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.contacts.Location = new System.Drawing.Point(3, 64);
			this.contacts.Name = "contacts";
			this.contacts.Size = new System.Drawing.Size(0, 16);
			this.contacts.TabIndex = 4;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.flowLayoutPanel1.Controls.Add(this.description);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(426, 246);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(430, 196);
			this.flowLayoutPanel1.TabIndex = 13;
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.flowLayoutPanel2.Controls.Add(this.custOwn);
			this.flowLayoutPanel2.Controls.Add(this.rooms);
			this.flowLayoutPanel2.Controls.Add(this.state);
			this.flowLayoutPanel2.Controls.Add(this.floors);
			this.flowLayoutPanel2.Controls.Add(this.contacts);
			this.flowLayoutPanel2.Controls.Add(this.price);
			this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanel2.Location = new System.Drawing.Point(426, 71);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(430, 145);
			this.flowLayoutPanel2.TabIndex = 14;
			// 
			// price
			// 
			this.price.AutoSize = true;
			this.price.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.price.Location = new System.Drawing.Point(3, 80);
			this.price.Name = "price";
			this.price.Size = new System.Drawing.Size(0, 16);
			this.price.TabIndex = 5;
			// 
			// dataLabel
			// 
			this.dataLabel.AutoSize = true;
			this.dataLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dataLabel.Location = new System.Drawing.Point(430, 48);
			this.dataLabel.Name = "dataLabel";
			this.dataLabel.Size = new System.Drawing.Size(65, 18);
			this.dataLabel.TabIndex = 15;
			this.dataLabel.Text = "Данные";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(430, 224);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 18);
			this.label1.TabIndex = 16;
			this.label1.Text = "Описание";
			// 
			// cityBox
			// 
			this.cityBox.Font = new System.Drawing.Font("Arial", 12F);
			this.cityBox.FormattingEnabled = true;
			this.cityBox.Items.AddRange(new object[] {
            "Все города"});
			this.cityBox.Location = new System.Drawing.Point(84, 142);
			this.cityBox.Name = "cityBox";
			this.cityBox.Size = new System.Drawing.Size(125, 26);
			this.cityBox.TabIndex = 46;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(26, 145);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 18);
			this.label2.TabIndex = 45;
			this.label2.Text = "Город";
			// 
			// onlyMyBox
			// 
			this.onlyMyBox.AutoSize = true;
			this.onlyMyBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.onlyMyBox.Location = new System.Drawing.Point(55, 174);
			this.onlyMyBox.Name = "onlyMyBox";
			this.onlyMyBox.Size = new System.Drawing.Size(109, 22);
			this.onlyMyBox.TabIndex = 47;
			this.onlyMyBox.Text = "Только мои";
			this.onlyMyBox.UseVisualStyleBackColor = true;
			// 
			// changePostButton
			// 
			this.changePostButton.Enabled = false;
			this.changePostButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.changePostButton.Location = new System.Drawing.Point(55, 295);
			this.changePostButton.Name = "changePostButton";
			this.changePostButton.Size = new System.Drawing.Size(102, 41);
			this.changePostButton.TabIndex = 48;
			this.changePostButton.Text = "Изменить";
			this.changePostButton.UseVisualStyleBackColor = true;
			this.changePostButton.Click += new System.EventHandler(this.changePostButton_Click);
			// 
			// changeToDeniedButton
			// 
			this.changeToDeniedButton.Enabled = false;
			this.changeToDeniedButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.changeToDeniedButton.Location = new System.Drawing.Point(55, 342);
			this.changeToDeniedButton.Name = "changeToDeniedButton";
			this.changeToDeniedButton.Size = new System.Drawing.Size(102, 41);
			this.changeToDeniedButton.TabIndex = 49;
			this.changeToDeniedButton.Text = "Отменить";
			this.changeToDeniedButton.UseVisualStyleBackColor = true;
			this.changeToDeniedButton.Click += new System.EventHandler(this.changeToDeniedButton_Click);
			// 
			// deleteButton
			// 
			this.deleteButton.Enabled = false;
			this.deleteButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.deleteButton.Location = new System.Drawing.Point(55, 389);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(102, 41);
			this.deleteButton.TabIndex = 50;
			this.deleteButton.Text = "Удалить";
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
			// 
			// namePost
			// 
			this.namePost.AutoSize = true;
			this.namePost.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.namePost.Location = new System.Drawing.Point(501, 50);
			this.namePost.Name = "namePost";
			this.namePost.Size = new System.Drawing.Size(0, 16);
			this.namePost.TabIndex = 51;
			// 
			// respond
			// 
			this.respond.AutoSize = true;
			this.respond.Cursor = System.Windows.Forms.Cursors.Hand;
			this.respond.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.respond.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.respond.Location = new System.Drawing.Point(742, 24);
			this.respond.Name = "respond";
			this.respond.Size = new System.Drawing.Size(105, 18);
			this.respond.TabIndex = 52;
			this.respond.Text = "Откликнуться";
			this.respond.Visible = false;
			this.respond.Click += new System.EventHandler(this.respond_Click);
			// 
			// FormView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(868, 459);
			this.Controls.Add(this.respond);
			this.Controls.Add(this.namePost);
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.changeToDeniedButton);
			this.Controls.Add(this.changePostButton);
			this.Controls.Add(this.onlyMyBox);
			this.Controls.Add(this.cityBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataLabel);
			this.Controls.Add(this.flowLayoutPanel2);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.createButton);
			this.Controls.Add(this.searchLabel);
			this.Controls.Add(this.toPriceLabel);
			this.Controls.Add(this.priceMaxField);
			this.Controls.Add(this.roomsLabel);
			this.Controls.Add(this.priceLabel);
			this.Controls.Add(this.priceMinField);
			this.Controls.Add(this.roomsField);
			this.Controls.Add(this.topLabel);
			this.Controls.Add(this.SearchButton);
			this.Name = "FormView";
			this.Text = "FormView";
			this.Load += new System.EventHandler(this.FormView_Load);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.flowLayoutPanel2.ResumeLayout(false);
			this.flowLayoutPanel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button SearchButton;
		private System.Windows.Forms.Label topLabel;
		private System.Windows.Forms.TextBox roomsField;
		private System.Windows.Forms.TextBox priceMinField;
		private System.Windows.Forms.Label priceLabel;
		private System.Windows.Forms.Label roomsLabel;
		private System.Windows.Forms.TextBox priceMaxField;
		private System.Windows.Forms.Label toPriceLabel;
		private System.Windows.Forms.Label searchLabel;
		private System.Windows.Forms.Button createButton;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Label floors;
		private System.Windows.Forms.Label state;
		private System.Windows.Forms.Label rooms;
		private System.Windows.Forms.Label custOwn;
		private System.Windows.Forms.Label description;
		private System.Windows.Forms.Label contacts;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private System.Windows.Forms.Label dataLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label price;
		private System.Windows.Forms.ComboBox cityBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox onlyMyBox;
		private System.Windows.Forms.Button changePostButton;
		private System.Windows.Forms.Button changeToDeniedButton;
		private System.Windows.Forms.Button deleteButton;
		private System.Windows.Forms.Label namePost;
		private System.Windows.Forms.Label respond;
	}
}