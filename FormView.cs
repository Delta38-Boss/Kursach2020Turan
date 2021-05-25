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
	public partial class FormView : Form
	{
		public string tableName;
		static List<string> postsId = new List<string>();
		string currentID = "";

		public FormView(string tn)
		{
			tableName = tn;
			InitializeComponent();
		}

		private void topLabel_Click(object sender, EventArgs e)
		{

		}

		private void SearchButton_Click(object sender, EventArgs e)
		{
			if (tableName == "proposition")
			{
				listView1.Items.Clear();

				string qtext = "";
				string status_text = " Status = 'confirm' ";

				if (onlyMyBox.Checked)
				{
					status_text = " (Status = 'denied' OR Status = 'confirm' OR Status = 'wait') ";
				}
				if (priceMinField.TextLength > 0 && priceMaxField.TextLength > 0 && roomsField.TextLength > 0) { qtext = "WHERE Price > " + Convert.ToString(Convert.ToInt32(priceMinField.Text) - 1) + " AND Price < " + Convert.ToString(Convert.ToInt32(priceMaxField.Text) + 1) + " AND Rooms = '" + roomsField.Text + "' AND "+ status_text +" "; }
				if (priceMinField.TextLength < 1 && priceMaxField.TextLength < 1 && roomsField.TextLength < 1) { qtext = "WHERE "+ status_text +" "; }
				if (priceMinField.TextLength > 0 && priceMaxField.TextLength > 0 && roomsField.TextLength < 1) { qtext = "WHERE Price > " + Convert.ToString(Convert.ToInt32(priceMinField.Text) - 1)  + " AND Price < " + Convert.ToString(Convert.ToInt32(priceMaxField.Text) + 1) + " AND " + status_text + " "; }
				if (priceMinField.TextLength > 0 && priceMaxField.TextLength < 1 && roomsField.TextLength > 0) { qtext = "WHERE Price > " + Convert.ToString(Convert.ToInt32(priceMinField.Text) - 1) + " AND Rooms = '" + roomsField.Text + "' AND " + status_text + " "; }
				if (priceMinField.TextLength < 1 && priceMaxField.TextLength > 0 && roomsField.TextLength > 0) { qtext = "WHERE Price < " + Convert.ToString(Convert.ToInt32(priceMaxField.Text) + 1) + " AND Rooms = '" + roomsField.Text + "' AND " + status_text + " "; }
				if (priceMinField.TextLength < 1 && priceMaxField.TextLength < 1 && roomsField.TextLength > 0) { qtext = "WHERE Rooms = '" + roomsField.Text + "' AND " + status_text + " "; }
				if (priceMinField.TextLength < 1 && priceMaxField.TextLength > 0 && roomsField.TextLength < 1) { qtext = "WHERE Price < " + Convert.ToString(Convert.ToInt32(priceMaxField.Text) + 1) + " AND " + status_text + " "; }
				if (priceMinField.TextLength > 0 && priceMaxField.TextLength < 1 && roomsField.TextLength < 1) { qtext = "WHERE Price > " + Convert.ToString(Convert.ToInt32(priceMinField.Text) - 1) + " AND " + status_text + " "; }

				if (cityBox.Text.Length > 0 && cityBox.Text != "Все города")
				{
					qtext = qtext + "AND City = '" + cityBox.Text + "' ";
				}
				else if (cityBox.Text.Length < 1 || cityBox.Text == "Все города")
				{
					qtext = qtext + " ";
				}

				if (onlyMyBox.Checked)
				{
					qtext = qtext + " AND Owner = '"+ MySQLConnector.userId +"' ";
				}

				Console.WriteLine("SELECT Address, ID FROM proposition " + qtext);
				MySQLConnector.command = new MySqlCommand("SELECT Address, ID FROM proposition "+ qtext, MySQLConnector.GetConnection());
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
				string status_text = " Status = 'confirm' ";

				if (onlyMyBox.Checked)
				{
					status_text = " (Status = 'denied' OR Status = 'confirm' OR Status = 'wait') ";
				}
				if (priceMinField.TextLength > 0 && priceMaxField.TextLength > 0 && roomsField.TextLength > 0) { qtext = "WHERE Price > " + Convert.ToString(Convert.ToInt32(priceMinField.Text) - 1) + " AND Price < " + Convert.ToString(Convert.ToInt32(priceMaxField.Text) + 1) + " AND Rooms = '" + roomsField.Text + "' AND " + status_text + " "; }
				if (priceMinField.TextLength < 1 && priceMaxField.TextLength < 1 && roomsField.TextLength < 1) { qtext = "WHERE " + status_text + " "; }
				if (priceMinField.TextLength > 0 && priceMaxField.TextLength > 0 && roomsField.TextLength < 1) { qtext = "WHERE Price > " + Convert.ToString(Convert.ToInt32(priceMinField.Text) - 1) + " AND Price < " + Convert.ToString(Convert.ToInt32(priceMaxField.Text) + 1) + " AND " + status_text + " "; }
				if (priceMinField.TextLength > 0 && priceMaxField.TextLength < 1 && roomsField.TextLength > 0) { qtext = "WHERE Price > " + Convert.ToString(Convert.ToInt32(priceMinField.Text) - 1) + " AND Rooms = '" + roomsField.Text + "' AND " + status_text + " "; }
				if (priceMinField.TextLength < 1 && priceMaxField.TextLength > 0 && roomsField.TextLength > 0) { qtext = "WHERE Price < " + Convert.ToString(Convert.ToInt32(priceMaxField.Text) + 1) + " AND Rooms = '" + roomsField.Text + "' AND " + status_text + " "; }
				if (priceMinField.TextLength < 1 && priceMaxField.TextLength < 1 && roomsField.TextLength > 0) { qtext = "WHERE Rooms = '" + roomsField.Text + "' AND " + status_text + " "; }
				if (priceMinField.TextLength < 1 && priceMaxField.TextLength > 0 && roomsField.TextLength < 1) { qtext = "WHERE Price < " + Convert.ToString(Convert.ToInt32(priceMaxField.Text) + 1) + " AND " + status_text + " "; }
				if (priceMinField.TextLength > 0 && priceMaxField.TextLength < 1 && roomsField.TextLength < 1) { qtext = "WHERE Price > " + Convert.ToString(Convert.ToInt32(priceMinField.Text) - 1) + " AND " + status_text + " "; }
				if (cityBox.Text.Length > 0 && cityBox.Text != "Все города")
				{
					qtext = qtext + "AND City = '"+ cityBox.Text + "'";
				}
				else if (cityBox.Text.Length <  1 || cityBox.Text == "Все города")
				{
					qtext = qtext + "";
				}

				if (onlyMyBox.Checked)
				{
					qtext = qtext + " AND Customer = '" + MySQLConnector.userId + "' ";
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

		private void FormView_Load(object sender, EventArgs e)
		{
			try
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
			}
			catch
			{
				MessageBox.Show("Ошибка при загрузке таблиц ", "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}




			if (tableName == "proposition")
			{
				try
				{
					MySQLConnector.command = new MySqlCommand("SELECT Address, ID FROM proposition WHERE Status = 'confirm'", MySQLConnector.GetConnection());
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
				catch
				{
					MessageBox.Show("Ошибка при загрузке таблиц ", "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

			}
			else if (tableName == "request")
			{
				try
				{
					MySQLConnector.command = new MySqlCommand("SELECT Short_Desc, ID FROM request WHERE Status = 'confirm' ", MySQLConnector.GetConnection());
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
				catch
				{
					MessageBox.Show("Ошибка при загрузке таблиц ", "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

			}

		}

		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{
			respond.Visible = false;
			if (tableName == "proposition")
			{
				if (listView1.SelectedItems.Count > 0)
				{
					respond.Visible = true;
					MySQLConnector.command = new MySqlCommand("SELECT Owner, Status FROM proposition WHERE ID = " + postsId[listView1.SelectedIndices[0]] +" ", MySQLConnector.GetConnection());
					string currentStat = "";
					
					MySQLConnector.reader = MySQLConnector.command.ExecuteReader();
					
					while (MySQLConnector.reader.Read())
					{
						currentID = MySQLConnector.reader[0].ToString();
						currentStat = MySQLConnector.reader[1].ToString();
					}
					

					if (currentID == MySQLConnector.userId)
					{
						deleteButton.Enabled = true;
						changePostButton.Enabled = true;
						if (currentStat != "denied") { changeToDeniedButton.Enabled = true; } else { changeToDeniedButton.Enabled = false; }
					}
					else
					{
						deleteButton.Enabled = false;
						changePostButton.Enabled = false;
						changeToDeniedButton.Enabled = false;
					}
					MySQLConnector.command.Cancel();
					MySQLConnector.reader.Close();

					Console.WriteLine(listView1.SelectedItems[0].Text);
					Console.WriteLine(listView1.SelectedIndices[0]);
					MySQLConnector.command = new MySqlCommand("SELECT Owner_name, Owner_surname, Rooms, Flat, State, Floor, Count_floors, Email, Phone, Description, Price FROM proposition WHERE Address = '" + listView1.SelectedItems[0].Text + "'", MySQLConnector.GetConnection());


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
					//namePost.Text = "Адрес:" + listView1.SelectedItems[0].Text;
					table.Clear();
					MySQLConnector.command.Cancel();
				}
			}
			else if (tableName == "request")
			{
				if (listView1.SelectedItems.Count > 0)
				{
					respond.Visible = true;
					MySQLConnector.command = new MySqlCommand("SELECT Customer, Status FROM request WHERE ID = " + postsId[listView1.SelectedIndices[0]] + " ", MySQLConnector.GetConnection());

					string currentStat = "";
					MySQLConnector.reader = MySQLConnector.command.ExecuteReader();
					
					while (MySQLConnector.reader.Read())
					{
						currentID = MySQLConnector.reader[0].ToString();
						currentStat = MySQLConnector.reader[1].ToString();
					}


					if (currentID == MySQLConnector.userId)
					{
						deleteButton.Enabled = true;
						changePostButton.Enabled = true;
						if (currentStat != "denied"){changeToDeniedButton.Enabled = true;}else{ changeToDeniedButton.Enabled = false; }
					}
					else
					{
						deleteButton.Enabled = false;
						changePostButton.Enabled = false;
						changeToDeniedButton.Enabled = false;
					}
					MySQLConnector.command.Cancel();
					MySQLConnector.reader.Close();

					Console.WriteLine(listView1.SelectedItems[0].Text);
					MySQLConnector.command = new MySqlCommand("SELECT Short_Desc, Customer_Surname, Customer_Name, state, Rooms, Price, Email, Phone, Description  FROM request WHERE ID = '" + postsId[listView1.SelectedIndices[0]] + "'", MySQLConnector.GetConnection());


					MySQLConnector.adapter = new MySqlDataAdapter(MySQLConnector.command);
					MySQLConnector.builder = new MySqlCommandBuilder(MySQLConnector.adapter);
					DataTable table = new DataTable();

					MySQLConnector.adapter.Fill(table);
					custOwn.Text =  table.Rows[0][0].ToString();
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

		private void createButton_Click(object sender, EventArgs e)
		{
			if (tableName == "proposition") {
				FormInsertProp form = new FormInsertProp();
				form.Show();
				this.Close();
			} else if (tableName == "request")
			{
				FormInsertReq form = new FormInsertReq();
				form.Show();
				this.Close();
			}
		}

		private void priceMaxField_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void changePostButton_Click(object sender, EventArgs e)
		{
			if (tableName == "request")
			{
				FormInsertReq form = new FormInsertReq(postsId[listView1.SelectedIndices[0]]);
				form.Show();
			}
			else if (tableName == "proposition")
			{
				FormInsertProp form = new FormInsertProp(postsId[listView1.SelectedIndices[0]]);
				form.Show();
			}
		}

		private void changeToDeniedButton_Click(object sender, EventArgs e)
		{
			MySQLConnector.command = new MySqlCommand("UPDATE "+tableName+ " SET Status = 'denied' WHERE ID = '" + postsId[listView1.SelectedIndices[0]] + "'", MySQLConnector.GetConnection());

			if (MySQLConnector.command.ExecuteNonQuery() == 1)
			{
				MySQLConnector.command.Cancel();
				MessageBox.Show("Ваша запись изменила статус на 'Отказ'. Для того чтобы сного перевести в статус 'Ожидаю' измените запись" +
					" через редактор", "Все по плану", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Refresh();
			}
			else
			{
				MessageBox.Show("Что то пошло реально не по плану", "Ошибка критичная", MessageBoxButtons.OK, MessageBoxIcon.Error);
				MySQLConnector.command.Cancel();
			}
		}

		private void deleteButton_Click(object sender, EventArgs e)
		{
		
				MySQLConnector.command = new MySqlCommand("DELETE FROM "+ tableName +" WHERE ID = '"+ postsId[listView1.SelectedIndices[0]] +"'", MySQLConnector.GetConnection());

				if (MySQLConnector.command.ExecuteNonQuery() == 1)
				{
					MySQLConnector.command.Cancel();
					MessageBox.Show("Ваша запись удалена", "Все по плану", MessageBoxButtons.OK, MessageBoxIcon.Information);
				    this.Refresh();
				}
				else
				{
					MessageBox.Show("Что то пошло реально не по плану", "Ошибка критичная", MessageBoxButtons.OK, MessageBoxIcon.Error);
					MySQLConnector.command.Cancel();
				}
			
		}

		private void respond_Click(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count > 0)
			{

				if (tableName == "proposition")
				{
					MySQLConnector.command = new MySqlCommand("SELECT Owner, Address FROM " + tableName + " WHERE ID = " + postsId[listView1.SelectedIndices[0]], MySQLConnector.GetConnection());
				}
				else if (tableName == "request")
				{
					MySQLConnector.command = new MySqlCommand("SELECT Customer, Short_Desc FROM " + tableName + " WHERE ID = " + postsId[listView1.SelectedIndices[0]], MySQLConnector.GetConnection());
				}
				MySQLConnector.reader = MySQLConnector.command.ExecuteReader();

				string idMF = "", postName = "";

				while (MySQLConnector.reader.Read())
				{
					idMF = MySQLConnector.reader[0].ToString();
					postName = MySQLConnector.reader[1].ToString();

				}

				MySQLConnector.reader.Close();
				MySQLConnector.command.Cancel();

				MySQLConnector.command = new MySqlCommand("SELECT Surname, Name, Email, Phone FROM users WHERE ID = " + MySQLConnector.userId, MySQLConnector.GetConnection());

				MySQLConnector.reader = MySQLConnector.command.ExecuteReader();

				string nameRec = "", surnameRec = "", emailRec = "", phoneRec = "";

				while (MySQLConnector.reader.Read())
				{
					surnameRec = MySQLConnector.reader[0].ToString();
					nameRec = MySQLConnector.reader[1].ToString();
					emailRec = MySQLConnector.reader[2].ToString();
					phoneRec = MySQLConnector.reader[3].ToString(); 



				}

				string message = "Отклик на запись " + postName + "\nФамилия Имя: "+ surnameRec + " " + nameRec + 
					"\nEmail: " + emailRec + "\nТелефон:  " + phoneRec;
				MySQLConnector.reader.Close();
				MySQLConnector.command.Cancel();
				MessageBox.Show("Ваш отклик добрался ", "Все по плану", MessageBoxButtons.OK, MessageBoxIcon.Information);
				MessageToUser.SendMessage(idMF, "На вашу запись " + postName + " откликнулсь", message);
			}
			else
			{
				MessageBox.Show("Выберите вас интересующую запись", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
	}
}



