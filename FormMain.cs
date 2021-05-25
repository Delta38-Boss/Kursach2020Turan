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
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
		}

		private void Form2_FormClosing(object sender, FormClosingEventArgs e)
		{
			
		}

		private void Form2_FormClosed(object sender, FormClosedEventArgs e)
		{
			MySQLConnector.closeConnection();
			Application.Exit();
		}

		private void FormMain_Load(object sender, EventArgs e)
		{
			DataTable table = new DataTable();
			if (MySQLConnector.userStatus == "admin")
			{
				adminModerationProps.Visible = true;
				adminModerationRequest.Visible = true; 
				adminPropsWait.Visible = true;
				adminReqWait.Visible = true;
				MySQLConnector.command = new MySqlCommand("SELECT ID FROM request WHERE Status = 'wait'", MySQLConnector.GetConnection());
				
				MySQLConnector.adapter.SelectCommand = MySQLConnector.command;
				MySQLConnector.adapter.Fill(table);
				adminReqWait.Text = "Ожидают: " + table.Rows.Count;
				MySQLConnector.command.Cancel();
				table.Rows.Clear();

				MySQLConnector.command = new MySqlCommand("SELECT ID FROM proposition WHERE Status = 'wait'", MySQLConnector.GetConnection());
				MySQLConnector.adapter.SelectCommand = MySQLConnector.command;
				MySQLConnector.adapter.Fill(table);
				adminPropsWait.Text = "Ожидают: " + table.Rows.Count;
				MySQLConnector.command.Cancel();
				table.Rows.Clear();


			}

			MySQLConnector.command = new MySqlCommand("SELECT ID FROM messages WHERE IsChecked = 'no' AND ToID = '"+MySQLConnector.userId+"'", MySQLConnector.GetConnection());
			
			MySQLConnector.adapter.SelectCommand = MySQLConnector.command;
			MySQLConnector.adapter.Fill(table);
			messagesWait.Text = "Сообщений: " + table.Rows.Count;
			MySQLConnector.command.Cancel();
			table.Rows.Clear();




		}

		private void requests_Click(object sender, EventArgs e)
		{
			FormView form = new FormView("request");
			form.Show();
		}

		private void createRequest_Click(object sender, EventArgs e)
		{
			FormInsertReq form = new FormInsertReq();
			form.Show();

		}

		private void createProp_Click(object sender, EventArgs e)
		{
			FormInsertProp form = new FormInsertProp();
			form.Show();
		}

		private void proposition_Click(object sender, EventArgs e)
		{
			FormView form = new FormView("proposition");
			form.Show();
		}

		private void adminModerationRequest_Click(object sender, EventArgs e)
		{
			FormAdmin form = new FormAdmin("request");
			form.Show();
		}

		private void adminModerationProps_Click(object sender, EventArgs e)
		{
			FormAdmin form = new FormAdmin("proposition");
			form.Show();
		}

		private void FormMain_Activated(object sender, EventArgs e)
		{
			DataTable table = new DataTable();
			if (MySQLConnector.userStatus == "admin")
			{
				adminModerationProps.Visible = true;
				adminModerationRequest.Visible = true;
				adminPropsWait.Visible = true;
				adminReqWait.Visible = true;
				MySQLConnector.command = new MySqlCommand("SELECT ID FROM request WHERE Status = 'wait'", MySQLConnector.GetConnection());
				
				MySQLConnector.adapter.SelectCommand = MySQLConnector.command;
				MySQLConnector.adapter.Fill(table);
				adminReqWait.Text = "Ожидают: " + table.Rows.Count;
				MySQLConnector.command.Cancel();
				table.Rows.Clear();

				MySQLConnector.command = new MySqlCommand("SELECT ID FROM proposition WHERE Status = 'wait'", MySQLConnector.GetConnection());
				MySQLConnector.adapter.SelectCommand = MySQLConnector.command;
				MySQLConnector.adapter.Fill(table);
				adminPropsWait.Text = "Ожидают: " + table.Rows.Count;
				MySQLConnector.command.Cancel();
				table.Rows.Clear();


			}
			MySQLConnector.command = new MySqlCommand("SELECT ID FROM messages WHERE IsChecked = 'no' AND ToID = '" + MySQLConnector.userId + "'", MySQLConnector.GetConnection());

			MySQLConnector.adapter.SelectCommand = MySQLConnector.command;
			MySQLConnector.adapter.Fill(table);
			messagesWait.Text = "Сообщений: " + table.Rows.Count;
			MySQLConnector.command.Cancel();
			table.Rows.Clear();



		}

		private void messagesWait_Click(object sender, EventArgs e)
		{
			FormMessage form = new FormMessage();
			form.Show();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
