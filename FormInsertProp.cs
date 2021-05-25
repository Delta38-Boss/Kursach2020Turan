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
	public partial class FormInsertProp : Form
	{
		public string tableName;
		string id;

		public FormInsertProp(string recID = null)
		{
			id = recID;
			InitializeComponent();
		}

		private void FormInsert_Load(object sender, EventArgs e)
		{
			try
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
					MySQLConnector.command = new MySqlCommand("SELECT Address, City, Flat, Rooms, Price, Description, Floor, Count_Floors, State FROM proposition WHERE ID = '" + id + "'", MySQLConnector.GetConnection());
					MySQLConnector.adapter.SelectCommand = MySQLConnector.command;
					DataTable table = new DataTable();
					MySQLConnector.adapter.Fill(table);
					addressField.Text = table.Rows[0][0].ToString();
					cityBox.Text = table.Rows[0][1].ToString();
					flatField.Text = table.Rows[0][2].ToString();
					roomsField.Text = table.Rows[0][3].ToString();
					priceField.Text = table.Rows[0][4].ToString();
					descriptionField.Text = table.Rows[0][5].ToString();
					floorField.Text = table.Rows[0][6].ToString();
					floorsCountField.Text = table.Rows[0][7].ToString();
					stateField.Text = table.Rows[0][8].ToString();

					MySQLConnector.command.Cancel();
					table.Clear();

				}
			}
			catch
			{

			}
		}

		private void floorField_TextChanged(object sender, EventArgs e)
		{

		}

		private void label9_Click(object sender, EventArgs e)
		{

		}

		private void label11_Click(object sender, EventArgs e)
		{

		}

		private void descriptionField_TextChanged(object sender, EventArgs e)
		{

		}

		private void sendButton_Click(object sender, EventArgs e)
		{
			if (id == null)
			{

				if (addressField.TextLength > 4 && priceField.TextLength > 5 && flatField.TextLength > 1
				&& roomsField.TextLength > 0 && floorsCountField.TextLength > 0 && floorField.TextLength > 0 &&
				descriptionField.TextLength > 10 && stateField.Text.Length > 0 && cityBox.Text.Length > 0)
				{

					MySQLConnector.command = new MySqlCommand("SELECT Name, Surname, Email, Phone FROM users WHERE ID = '" + MySQLConnector.userId + "'", MySQLConnector.GetConnection());
					DataTable table = new DataTable();
					MySQLConnector.adapter.SelectCommand = MySQLConnector.command;
					MySQLConnector.adapter.Fill(table);

					MySQLConnector.command.Cancel();




					MySQLConnector.command = new MySqlCommand("INSERT INTO proposition VALUES('null','" + addressField.Text + "', '" + cityBox.Text + "','" + flatField.Text + "','" + roomsField.Text + "','" + priceField.Text + "','" + MySQLConnector.userId + "','" + table.Rows[0][0].ToString() + "','" + table.Rows[0][1].ToString() + "','" + table.Rows[0][2].ToString() + "','" + table.Rows[0][3].ToString() + "','" + descriptionField.Text + "','" + floorField.Text + "','" + floorsCountField.Text + "','" + stateField.Text + "','wait')", MySQLConnector.GetConnection());
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
					MessageBox.Show("Проверьте правильность заполнения полей", "Ошибка заполнения", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}

			}
			else if (id != null)
			{
				if (addressField.TextLength > 4 && priceField.TextLength > 5 && flatField.TextLength > 1
				&& roomsField.TextLength > 0 && floorsCountField.TextLength > 0 && floorField.TextLength > 0 &&
				descriptionField.TextLength > 10 && stateField.Text.Length > 0 && cityBox.Text.Length > 0)
				{
					

					MySQLConnector.command = new MySqlCommand("UPDATE proposition SET Address = '"+ addressField.Text + "', Price = '"+ priceField.Text + "', City = '"+cityBox.Text+"', Flat = '" + flatField.Text + "', Rooms = '"+roomsField.Text+"',  Price = '"+priceField.Text+"',  Description = '"+descriptionField.Text+"',  Floor = '"+floorField.Text+"', Count_Floors = '"+floorsCountField.Text+"', State = '"+stateField.Text+"', Status = 'wait' WHERE ID = '" + id + "'", MySQLConnector.GetConnection());
					

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

/*
 MySQLConnector.command = new MySqlCommand("SELECT * FROM Proposition WHERE Owner = '"+ MySQLConnector.userId +"'", MySQLConnector.GetConnection());
					MySQLConnector.adapter.SelectCommand = MySQLConnector.command;
					DataTable table = new DataTable();
					MySQLConnector.adapter.Fill(table);
					if (table.Rows.Count < 1)
					{
					*/
