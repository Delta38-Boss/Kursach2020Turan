using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql;
using MySql.Data.MySqlClient;
using Kursach2020.classes;

namespace Kursach2020
{
	public partial class FormAdminChangeStatus : Form
	{
		public string tableName, action, id;
		public FormAdminChangeStatus(string tn, string act, string idFrom)
		{
			InitializeComponent();
			tableName = tn;
			action = act;
			id = idFrom;
		}

		private void FormAdminChangeStatus_Load(object sender, EventArgs e)
		{

		}

		private void acceptButton_Click(object sender, EventArgs e)
		{
			string message = "";

			

		    if (tableName == "proposition")
			{
				MySQLConnector.command = new MySqlCommand("SELECT Owner, Address FROM " + tableName + " WHERE ID = " + id, MySQLConnector.GetConnection());
			}
			else if (tableName == "request")
			{
				MySQLConnector.command = new MySqlCommand("SELECT Customer, Short_Desc FROM " + tableName + " WHERE ID = " + id, MySQLConnector.GetConnection());
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


			MySQLConnector.command = new MySqlCommand("UPDATE " + tableName + " SET Status = '" + action + "' WHERE ID = '" + id + "'", MySQLConnector.GetConnection());
			if (action == "denied")
			{
				message = "Ваш запрос " + postName + " был отклонен. ";

			}
			else if (action == "wait")
			{
				message = "Ваш запрос "+ postName +" перевели в статус Ожидания. ";
			}
			else if (action == "confirm")
			{
				message = "Ваш запрос " + postName + " был принят, и сейчас виден всем. ";
			}

			if (messageBox.TextLength > 0)
			{
				message = message + "\nПримичание от администратора:\n " + messageBox.Text;
			}

			if (MySQLConnector.command.ExecuteNonQuery() == 1)
			{
				MySQLConnector.command.Cancel();
				MessageBox.Show("Запись изменила статус ", "Все по плану", MessageBoxButtons.OK, MessageBoxIcon.Information);
				MessageToUser.SendMessage(idMF, "Ваша запись " + postName + " сменила статус", message);
				this.Close();
			}
			else
			{
				MessageBox.Show("Что то пошло реально не по плану", "Ошибка критичная", MessageBoxButtons.OK, MessageBoxIcon.Error);
				MySQLConnector.command.Cancel();
			}
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
