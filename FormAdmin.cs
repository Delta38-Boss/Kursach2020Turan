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
	public partial class FormAdmin : Form
	{

		public string tableName;
		static List<string> postsId = new List<string>();

		public FormAdmin(string tn)
		{
			tableName = tn;
			InitializeComponent();
		}

		private void FormAdmin_Load(object sender, EventArgs e)
		{
			MySQLConnector.command = new MySqlCommand("SELECT Name FROM cities ", MySQLConnector.GetConnection());
			//MySQLConnector.adapter = new MySqlDataAdapter(MySQLConnector.command);
			MySQLConnector.reader = MySQLConnector.command.ExecuteReader();
			//MySQLConnector.adapter.Fill(MySQLConnector.dataSet, "Proposition");

			postsId.Clear();
			while (MySQLConnector.reader.Read())
			{
				cityBox.Items.Add(MySQLConnector.reader[0].ToString());


			}
			MySQLConnector.command.Cancel();
			MySQLConnector.reader.Close();

			if (tableName == "proposition")
			{
				MySQLConnector.command = new MySqlCommand("SELECT Address, ID FROM proposition WHERE Status = 'wait'", MySQLConnector.GetConnection());
				//MySQLConnector.adapter = new MySqlDataAdapter(MySQLConnector.command);
				MySQLConnector.reader = MySQLConnector.command.ExecuteReader();
				//MySQLConnector.adapter.Fill(MySQLConnector.dataSet, "Proposition");

				Console.WriteLine(MySQLConnector.reader.FieldCount);
				while (MySQLConnector.reader.Read())
				{

					listView1.Items.Add(MySQLConnector.reader[0].ToString());
					postsId.Add(MySQLConnector.reader[1].ToString());
					


				}
				MySQLConnector.command.Cancel();
				MySQLConnector.reader.Close();
			}
			else if (tableName == "request")
			{
				MySQLConnector.command = new MySqlCommand("SELECT Short_Desc, ID FROM request WHERE Status = 'wait' ", MySQLConnector.GetConnection());
				//MySQLConnector.adapter = new MySqlDataAdapter(MySQLConnector.command);
				MySQLConnector.reader = MySQLConnector.command.ExecuteReader();
				//MySQLConnector.adapter.Fill(MySQLConnector.dataSet, "Proposition");
				postsId.Clear();
				while (MySQLConnector.reader.Read())
				{
					listView1.Items.Add(MySQLConnector.reader[0].ToString());
					postsId.Add(MySQLConnector.reader[1].ToString());


				}
				MySQLConnector.command.Cancel();
				MySQLConnector.reader.Close();

			}

		}

		private void SearchButton_Click(object sender, EventArgs e)
		{
			if (tableName == "proposition")
			{
				listView1.Items.Clear();
				string qtext = "";
				if (priceMinField.TextLength > 0 && priceMaxField.TextLength > 0 && roomsField.TextLength > 0) { qtext = "WHERE Price > " + Convert.ToString(Convert.ToInt32(priceMinField.Text) - 1) + " AND Price < " + Convert.ToString(Convert.ToInt32(priceMaxField.Text) + 1) + " AND Rooms = '" + roomsField.Text + "' AND "; }
				if (priceMinField.TextLength < 1 && priceMaxField.TextLength < 1 && roomsField.TextLength < 1) { qtext = "WHERE "; }
				if (priceMinField.TextLength > 0 && priceMaxField.TextLength > 0 && roomsField.TextLength < 1) { qtext = "WHERE Price > " + Convert.ToString(Convert.ToInt32(priceMinField.Text) - 1) + " AND Price < " + Convert.ToString(Convert.ToInt32(priceMaxField.Text) + 1) + " AND "; }
				if (priceMinField.TextLength > 0 && priceMaxField.TextLength < 1 && roomsField.TextLength > 0) { qtext = "WHERE Price > " + Convert.ToString(Convert.ToInt32(priceMinField.Text) - 1) + " AND Rooms = '" + roomsField.Text + "' AND "; }
				if (priceMinField.TextLength < 1 && priceMaxField.TextLength > 0 && roomsField.TextLength > 0) { qtext = "WHERE Price < " + Convert.ToString(Convert.ToInt32(priceMaxField.Text) + 1) + " AND Rooms = '" + roomsField.Text + "' AND "; }
				if (priceMinField.TextLength < 1 && priceMaxField.TextLength < 1 && roomsField.TextLength > 0) { qtext = "WHERE Rooms = '" + roomsField.Text + "' "; }
				if (priceMinField.TextLength < 1 && priceMaxField.TextLength > 0 && roomsField.TextLength < 1) { qtext = "WHERE Price < " + Convert.ToString(Convert.ToInt32(priceMaxField.Text) + 1) + " AND "; }
				if (priceMinField.TextLength > 0 && priceMaxField.TextLength < 1 && roomsField.TextLength < 1) { qtext = "WHERE Price > " + Convert.ToString(Convert.ToInt32(priceMinField.Text) - 1) + " AND "; }
				Console.WriteLine("SELECT Short_Desc, ID FROM proposition " + qtext);





				if (waitRadio.Checked)
				{
					qtext = qtext + "Status = 'wait' ";
				}
				else if (deniedRadio.Checked)
				{
					qtext = qtext + "Status = 'denied' ";
				}
				else if (allRadio.Checked)
				{
					qtext = qtext + "Status = 'denied' OR Status = 'wait' OR Status = 'confirm' ";
				}
				else if (confRadio.Checked)
				{
					qtext = qtext + " Status = 'confirm' ";
				}

				if (cityBox.Text.Length > 0 && cityBox.Text != "Все города")
				{
					qtext = qtext + "AND City = '" + cityBox.Text + "' ";
				}
				else if (cityBox.Text.Length < 1 || cityBox.Text == "Все города")
				{
					qtext = qtext + " ";
				}


				Console.WriteLine("SELECT Address, ID FROM proposition " + qtext);
				MySQLConnector.command = new MySqlCommand("SELECT Address, ID  FROM proposition " + qtext, MySQLConnector.GetConnection());
				//MySQLConnector.adapter = new MySqlDataAdapter(MySQLConnector.command);
				MySQLConnector.reader = MySQLConnector.command.ExecuteReader();
				//MySQLConnector.adapter.Fill(MySQLConnector.dataSet, "Proposition");
				postsId.Clear();
				while (MySQLConnector.reader.Read())
				{
					listView1.Items.Add(MySQLConnector.reader[0].ToString());
					postsId.Add(MySQLConnector.reader[1].ToString());

				}
				MySQLConnector.command.Cancel();
				MySQLConnector.reader.Close();
			}
			else if (tableName == "request")
			{
				listView1.Items.Clear();
				string qtext = "";
				if (priceMinField.TextLength > 0 && priceMaxField.TextLength > 0 && roomsField.TextLength > 0) { qtext = "WHERE Price > " + Convert.ToString(Convert.ToInt32(priceMinField.Text) - 1) + " AND Price < " + Convert.ToString(Convert.ToInt32(priceMaxField.Text) + 1) + " AND Rooms = '" + roomsField.Text + "' AND "; }
				if (priceMinField.TextLength < 1 && priceMaxField.TextLength < 1 && roomsField.TextLength < 1) { qtext = "WHERE "; }
				if (priceMinField.TextLength > 0 && priceMaxField.TextLength > 0 && roomsField.TextLength < 1) { qtext = "WHERE Price > " + Convert.ToString(Convert.ToInt32(priceMinField.Text) - 1) + " AND Price < " + Convert.ToString(Convert.ToInt32(priceMaxField.Text) + 1) + " AND "; }
				if (priceMinField.TextLength > 0 && priceMaxField.TextLength < 1 && roomsField.TextLength > 0) { qtext = "WHERE Price > " + Convert.ToString(Convert.ToInt32(priceMinField.Text) - 1) + " AND Rooms = '" + roomsField.Text + "' AND "; }
				if (priceMinField.TextLength < 1 && priceMaxField.TextLength > 0 && roomsField.TextLength > 0) { qtext = "WHERE Price < " + Convert.ToString(Convert.ToInt32(priceMaxField.Text) + 1) + " AND Rooms = '" + roomsField.Text + "' AND "; }
				if (priceMinField.TextLength < 1 && priceMaxField.TextLength < 1 && roomsField.TextLength > 0) { qtext = "WHERE Rooms = '" + roomsField.Text + "' "; }
				if (priceMinField.TextLength < 1 && priceMaxField.TextLength > 0 && roomsField.TextLength < 1) { qtext = "WHERE Price < " + Convert.ToString(Convert.ToInt32(priceMaxField.Text) + 1) + " AND "; }
				if (priceMinField.TextLength > 0 && priceMaxField.TextLength < 1 && roomsField.TextLength < 1) { qtext = "WHERE Price > " + Convert.ToString(Convert.ToInt32(priceMinField.Text) - 1) + " AND "; }
				Console.WriteLine("SELECT Short_Desc, ID FROM request " + qtext);

				
				


				if (waitRadio.Checked)
				{
					qtext = qtext + "Status = 'wait' ";
				}
				else if (deniedRadio.Checked)
				{
					qtext = qtext + "Status = 'denied' ";
				}
				else if (allRadio.Checked)
				{
					qtext = qtext + "Status = 'denied' OR Status = 'wait' OR Status = 'confirm' ";
				}
				else if (confRadio.Checked)
				{
					qtext = qtext + " Status = 'confirm' ";
				}

				Console.WriteLine("SELECT Short_Desc, ID FROM request " + qtext);
				MySQLConnector.command = new MySqlCommand("SELECT Short_Desc, ID FROM request " + qtext, MySQLConnector.GetConnection());
				//MySQLConnector.adapter = new MySqlDataAdapter(MySQLConnector.command);
				MySQLConnector.reader = MySQLConnector.command.ExecuteReader();
				//MySQLConnector.adapter.Fill(MySQLConnector.dataSet, "Proposition");

				postsId.Clear();
				while (MySQLConnector.reader.Read())
				{
					listView1.Items.Add(MySQLConnector.reader[0].ToString());
					postsId.Add(MySQLConnector.reader[1].ToString());

				}
				MySQLConnector.command.Cancel();
				MySQLConnector.reader.Close();

			}
		}

		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (tableName == "proposition")
			{
				if (listView1.SelectedItems.Count > 0)
				{
					Console.WriteLine(listView1.SelectedItems[0].Text);
					Console.WriteLine(listView1.SelectedIndices[0]);
					MySQLConnector.command = new MySqlCommand("SELECT Owner_name, Owner_surname, Rooms, Flat, State, Floor, Count_floors, Email, Phone, Description, Price FROM proposition WHERE Address = '" + listView1.SelectedItems[0].Text + "'", MySQLConnector.GetConnection());

					Console.WriteLine("Id = " + postsId[listView1.SelectedIndices[0]]);
					MySQLConnector.adapter = new MySqlDataAdapter(MySQLConnector.command);
					MySQLConnector.builder = new MySqlCommandBuilder(MySQLConnector.adapter);
					DataTable table = new DataTable();

					MySQLConnector.adapter.Fill(table);
					custOwn.Text = "Владелец: " + table.Rows[0][1].ToString() + "  " + table.Rows[0][0].ToString();
					rooms.Text = "Комнат: " + table.Rows[0][2].ToString() + "  Жил. Площадь: " + table.Rows[0][3].ToString() + " кв. метров ";
					state.Text = "Состояние: " + table.Rows[0][4].ToString();
					floors.Text = "Этаж: " + table.Rows[0][5].ToString() + "/" + table.Rows[0][6].ToString();
					contacts.Text = "Email: " + table.Rows[0][7].ToString() + " Телефон: " + table.Rows[0][8].ToString();
					description.Text = table.Rows[0][9].ToString();
					price.Text = "Цена: " + table.Rows[0][10].ToString() + " т";
					//namePost.Text = "" + listView1.SelectedItems[0].Text;

					table.Clear();
					MySQLConnector.command.Cancel();
				}
			}
			else if (tableName == "request")
			{
				if (listView1.SelectedItems.Count > 0)
				{
					Console.WriteLine(listView1.SelectedItems[0].Text);
					MySQLConnector.command = new MySqlCommand("SELECT Short_Desc, Customer_Surname, Customer_Name, state, Rooms, Price, Email, Phone, Description  FROM request WHERE ID = '" + postsId[listView1.SelectedIndices[0]] + "'", MySQLConnector.GetConnection());


					MySQLConnector.adapter = new MySqlDataAdapter(MySQLConnector.command);
					MySQLConnector.builder = new MySqlCommandBuilder(MySQLConnector.adapter);
					DataTable table = new DataTable();

					MySQLConnector.adapter.Fill(table);
					custOwn.Text = table.Rows[0][0].ToString();
					rooms.Text = "Заказчик: " + table.Rows[0][1].ToString() + " " + table.Rows[0][2].ToString();
					state.Text = "Состояние: " + table.Rows[0][3].ToString();
					floors.Text = "Комнат требуется: " + table.Rows[0][4].ToString() + ". В цену до:" + table.Rows[0][5].ToString() + " т";
					contacts.Text = "Email: " + table.Rows[0][6].ToString() + " Телефон: " + table.Rows[0][7].ToString();
					description.Text = table.Rows[0][8].ToString();
					//namePost.Text = "" + listView1.SelectedItems[0].Text;
					table.Clear();
					MySQLConnector.command.Cancel();
				}

			}
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{

		}

		public string status;

		private void changeStatusButton_Click(object sender, EventArgs e)
		{
			if (waitRadio.Checked)
			{
				FormAdminChangeStatus form = new FormAdminChangeStatus(tableName, "wait", postsId[listView1.SelectedIndices[0]]);
				form.Show();
			}
			else if (deniedRadio.Checked)
			{
				FormAdminChangeStatus form = new FormAdminChangeStatus(tableName, "denied", postsId[listView1.SelectedIndices[0]]);
				form.Show();
			}
			else if (allRadio.Checked)
			{
				MessageBox.Show("Выберете тип один из трех но не этот!","Сделай нормально", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (confRadio.Checked)
			{
				FormAdminChangeStatus form = new FormAdminChangeStatus(tableName, "confirm", postsId[listView1.SelectedIndices[0]]);
				form.Show();
			}
			else
			{
				MessageBox.Show("Выберете тип один из трех но не этот!", "Сделай нормально", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void createButton_Click(object sender, EventArgs e)
		{

		}

		private void cityBox_SelectedIndexChanged(object sender, EventArgs e)
		{


		}

		private void deleteButton_Click(object sender, EventArgs e)
		{
			if (tableName == "proposition")
			{
				MySQLConnector.command = new MySqlCommand("SELECT Owner FROM " + tableName + " WHERE ID = " + postsId[listView1.SelectedIndices[0]].ToString(), MySQLConnector.GetConnection());
			}
			else if(tableName == "request")
			{
				MySQLConnector.command = new MySqlCommand("SELECT Customer FROM " + tableName + " WHERE ID = " + postsId[listView1.SelectedIndices[0]].ToString(), MySQLConnector.GetConnection());
			}
			MySQLConnector.reader = MySQLConnector.command.ExecuteReader();

			string idDeletedMF = "";

			while (MySQLConnector.reader.Read())
			{
				idDeletedMF = MySQLConnector.reader[0].ToString();

			}

			MySQLConnector.reader.Close();
			MySQLConnector.command.Cancel();

			MySQLConnector.command = new MySqlCommand("DELETE FROM " + tableName + " WHERE ID = '" + postsId[listView1.SelectedIndices[0]] + "'", MySQLConnector.GetConnection());

			if (MySQLConnector.command.ExecuteNonQuery() == 1)
			{
				MySQLConnector.command.Cancel();
				MessageBox.Show("Ваша запись удалена", "Все по плану", MessageBoxButtons.OK, MessageBoxIcon.Information);
				MessageToUser.SendMessage(idDeletedMF, "Ваша запись " + listView1.SelectedItems[0].Text + " была удалена администратором",
					"Если ваша запись была удалена администратором. То что-то реально там не то будьте оккуратны в следующий раз.");
				this.Refresh();
				
			}
			else
			{
				MessageBox.Show("Что то пошло реально не по плану", "Ошибка критичная", MessageBoxButtons.OK, MessageBoxIcon.Error);
				MySQLConnector.command.Cancel();
			}
		}
	}
}


/*if (priceMinField.TextLength > 0 && priceMaxField.TextLength > 0 && roomsField.TextLength > 0 && waitRadio.Checked) { qtext = "WHERE Price > " + Convert.ToString(Convert.ToInt32(priceMinField.Text) - 1) + " AND Price < " + Convert.ToString(Convert.ToInt32(priceMaxField.Text) + 1) + " AND Rooms = '" + roomsField.Text + "' AND Status = 'wait'"; }
				if (priceMinField.TextLength < 1 && priceMaxField.TextLength < 1 && roomsField.TextLength < 1 && waitRadio.Checked) { qtext = "WHERE Status = 'wait"; }
				if (priceMinField.TextLength > 0 && priceMaxField.TextLength > 0 && roomsField.TextLength < 1 && waitRadio.Checked) { qtext = "WHERE Price > " + Convert.ToString(Convert.ToInt32(priceMinField.Text) - 1) + " AND Price < " + Convert.ToString(Convert.ToInt32(priceMaxField.Text) + 1) + " AND Status = 'wait'"; }
				if (priceMinField.TextLength > 0 && priceMaxField.TextLength < 1 && roomsField.TextLength > 0 && waitRadio.Checked) { qtext = "WHERE Price > " + Convert.ToString(Convert.ToInt32(priceMinField.Text) - 1) + " AND Rooms = '" + roomsField.Text + "' AND Status = 'wait'"; }
				if (priceMinField.TextLength < 1 && priceMaxField.TextLength > 0 && roomsField.TextLength > 0 && waitRadio.Checked) { qtext = "WHERE Price < " + Convert.ToString(Convert.ToInt32(priceMaxField.Text) + 1) + " AND Rooms = '" + roomsField.Text + "' AND Status = 'wait'"; }
				if (priceMinField.TextLength < 1 && priceMaxField.TextLength < 1 && roomsField.TextLength > 0 && waitRadio.Checked) { qtext = "WHERE Rooms = '" + roomsField.Text + "' AND Status = 'wait'"; }
				if (priceMinField.TextLength < 1 && priceMaxField.TextLength > 0 && roomsField.TextLength < 1 && waitRadio.Checked) { qtext = "WHERE Price < " + Convert.ToString(Convert.ToInt32(priceMaxField.Text) + 1) + " AND Status = 'wait'"; }
				if (priceMinField.TextLength > 0 && priceMaxField.TextLength < 1 && roomsField.TextLength < 1 && waitRadio.Checked) { qtext = "WHERE Price > " + Convert.ToString(Convert.ToInt32(priceMinField.Text) - 1) + " AND Status = 'wait'"; }*/
