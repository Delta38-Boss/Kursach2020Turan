using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kursach2020.classes;
using MySql;
using MySql.Data.MySqlClient;

namespace Kursach2020
{
	public partial class FormInsertReq : Form
	{
		string id;
		public FormInsertReq(string recID = null)
		{
			id = recID;
			InitializeComponent();
		}

		private void FormInsertReq_Load(object sender, EventArgs e)
		{
			MySQLConnector.command = new MySqlCommand("SELECT Name FROM cities ", MySQLConnector.GetConnection());
			//MySQLConnector.adapter = new MySqlDataAdapter(MySQLConnector.command);
			MySQLConnector.reader = MySQLConnector.command.ExecuteReader();
			//MySQLConnector.adapter.Fill(MySQLConnector.dataSet, "Proposition");


			while (MySQLConnector.reader.Read())
			{
				cityBox.Items.Add(MySQLConnector.reader[0].ToString());


			}
			MySQLConnector.command.Cancel();
			MySQLConnector.reader.Close();
			if (id != null)
			{
				MySQLConnector.command = new MySqlCommand("SELECT Short_Desc, City, Price, Rooms, Description, State FROM request WHERE ID = '"+id+"'", MySQLConnector.GetConnection());
				MySQLConnector.adapter.SelectCommand = MySQLConnector.command;
				DataTable table = new DataTable();
				MySQLConnector.adapter.Fill(table);
				shortDescField.Text = table.Rows[0][0].ToString();
				cityBox.Text = table.Rows[0][1].ToString();
				priceField.Text =  table.Rows[0][2].ToString();
				roomsField.Text =  table.Rows[0][3].ToString();
				descriptionField.Text = table.Rows[0][4].ToString();
				stateField.Text = table.Rows[0][5].ToString();

				MySQLConnector.command.Cancel();
				table.Clear();

			}
		}

		private void sendButton_Click(object sender, EventArgs e)
		{
			if (id == null)
			{
				if (priceField.TextLength > 5 && roomsField.TextLength > 0 && descriptionField.TextLength > 10 && stateField.Text.Length > 0 && cityBox.Text.Length > 0)
				{

					MySQLConnector.command = new MySqlCommand("SELECT Customer FROM request WHERE Customer = '" + MySQLConnector.userId + "'", MySQLConnector.GetConnection());
					DataTable table = new DataTable();
					MySQLConnector.adapter.SelectCommand = MySQLConnector.command;
					MySQLConnector.adapter.Fill(table);
					MySQLConnector.command.Cancel();


					if (table.Rows.Count < 1)
					{
						table.Rows.Clear();
						MySQLConnector.command = new MySqlCommand("SELECT Name, Surname, Email, Phone FROM users WHERE ID = '" + MySQLConnector.userId + "'", MySQLConnector.GetConnection());
						MySQLConnector.adapter.SelectCommand = MySQLConnector.command;
						MySQLConnector.adapter.Fill(table);
						MySQLConnector.command.Cancel();

						MySQLConnector.command = new MySqlCommand("INSERT INTO request VALUES('null','" + shortDescField.Text + "', '" + cityBox.Text + "','" + MySQLConnector.userId + "','" + priceField.Text + "','" + roomsField.Text + "','" + table.Rows[0][3].ToString() + "','" + table.Rows[0][4].ToString() + "','" + table.Rows[0][1].ToString() + "','" + table.Rows[0][2].ToString() + "','" + descriptionField.Text + "','" + stateField.Text + "', 'wait')", MySQLConnector.GetConnection());
						table.Rows.Clear();

						if (MySQLConnector.command.ExecuteNonQuery() == 1)
						{
							MySQLConnector.command.Cancel();
							DialogResult result = MessageBox.Show("Ваша квартира добавлена в список модерации, ожидайте ответа администрации", "Все по плану", MessageBoxButtons.OK, MessageBoxIcon.Information);
							if (result == DialogResult.OK) this.Close();

						}
						else
						{
							MessageBox.Show("Что то пошло реально не по плану", "Ошибка критичная", MessageBoxButtons.OK, MessageBoxIcon.Error);
							MySQLConnector.command.Cancel();
						}
					}
					else
					{
						MessageBox.Show("У вас уже есть запрос на пойск квартиры, нельзя подавать более одного запроса", "Ошибка базы", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						MySQLConnector.command.Cancel();
					}


				}
				else
				{
					MessageBox.Show("Проверьте правильность заполнения полей", "Ошибка заполнения", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			else if (id != null)
			{
				if (priceField.TextLength > 5 && roomsField.TextLength > 0 && descriptionField.TextLength > 10 && stateField.Text.Length > 0 && cityBox.Text.Length > 0)
				{
					DataTable table = new DataTable();
					table.Rows.Clear();
					MySQLConnector.command = new MySqlCommand("SELECT Name, Surname, Email, Phone FROM users WHERE ID = '" + MySQLConnector.userId + "'", MySQLConnector.GetConnection());
					MySQLConnector.adapter.SelectCommand = MySQLConnector.command;
					MySQLConnector.adapter.Fill(table);
					MySQLConnector.command.Cancel();

					MySQLConnector.command = new MySqlCommand("UPDATE request SET Short_Desc= '" + shortDescField.Text + "', City = '"+cityBox.Text+"', Price = '"+priceField.Text+"', Rooms = '"+roomsField.Text+"', Description = '"+descriptionField.Text+"', State = '"+stateField.Text+"', Status = 'wait' WHERE ID = '"+id+"'", MySQLConnector.GetConnection());
					table.Rows.Clear();

					if (MySQLConnector.command.ExecuteNonQuery() == 1)
					{
						MySQLConnector.command.Cancel();
						DialogResult result = MessageBox.Show("Ваша квартира обновлена и добавлена в список модерации, ожидайте ответа администрации", "Все по плану", MessageBoxButtons.OK, MessageBoxIcon.Information);
						if (result == DialogResult.OK) this.Close();

					}
					else
					{
						MessageBox.Show("Что то пошло реально не по плану", "Ошибка критичная", MessageBoxButtons.OK, MessageBoxIcon.Error);
						MySQLConnector.command.Cancel();
					}
				}
				else
				{
					MessageBox.Show("Проверьте правильность заполнения полей", "Ошибка заполнения", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
		}
	}
}
