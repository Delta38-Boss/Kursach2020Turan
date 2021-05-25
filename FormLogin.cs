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
using System.Security.Cryptography;

namespace Kursach2020
{
	public partial class FormLogin : Form
	{
		
		public FormLogin()
		{
			InitializeComponent();
			try
			{
				MySQLConnector.openConnection();
			}
			catch (MySqlException e)
			{
				MessageBox.Show("Подключение не удалось " + e, "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		

		private void Form1_Load(object sender, EventArgs e)
		{
			
		}

		private void loginButton_Click(object sender, EventArgs e)
		{
			MD5 md5Hash = MD5.Create();
			byte[] passByte = Encoding.UTF8.GetBytes(passField.Text);
			passByte = md5Hash.ComputeHash(passByte);
			string hash = BitConverter.ToString(passByte).Replace("-", string.Empty);


			MySQLConnector.command = new MySqlCommand("SELECT * FROM users WHERE Login = '"+ loginField.Text + "' " +
				"AND Password = '"+ hash +"'", MySQLConnector.GetConnection());
			DataTable table = new DataTable();
			MySQLConnector.adapter.SelectCommand = MySQLConnector.command;
			MySQLConnector.adapter.Fill(table);
			Console.WriteLine(table.Rows);
			Console.WriteLine(hash);

			if (table.Rows.Count > 0)
			{
				MySQLConnector.UserLogin(table.Rows[0][8].ToString(), table.Rows[0][0].ToString());
				table.Rows.Clear();
				MySQLConnector.command.Cancel();
				FormMain formmain = new FormMain();
				formmain.Show();
				this.Hide();

			}
			else
			{
				MessageBox.Show("Неверный логин или пароль!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
				MySQLConnector.command.Cancel();
				table.Rows.Clear();
			}
		}

		private void label4_Click(object sender, EventArgs e)
		{
			FormRegister form = new FormRegister();
			form.Show();
		}

		private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
		{
			MySQLConnector.closeConnection();
		}
	}
}
