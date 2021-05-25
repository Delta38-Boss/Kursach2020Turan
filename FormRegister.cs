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
using System.Security.Cryptography;

namespace Kursach2020
{
	public partial class FormRegister : Form
	{
		public FormRegister()
		{
			InitializeComponent();
		}

		private void FormRegister_Load(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}


		private void registerButton_Click(object sender, EventArgs e)
		{
			try
			{
			if (loginField.TextLength > 3 && passField.TextLength > 5 && repassField.TextLength > 5
				&& nameField.TextLength > 0 && surnameField.TextLength > 0 && emailField.TextLength > 0 &&
				phoneField.TextLength > 4)
			{
				if (passField.Text == repassField.Text)
				{

					MySQLConnector.command = new MySqlCommand("SELECT Login FROM users WHERE Login = '" + loginField.Text + "'", MySQLConnector.GetConnection());
					MySQLConnector.adapter.SelectCommand = MySQLConnector.command;
					DataTable table = new DataTable();
					MySQLConnector.adapter.Fill(table);
					if (table.Rows.Count < 1)
					{
						MySQLConnector.command.Cancel();
						table.Rows.Clear();
						MySQLConnector.command = new MySqlCommand("SELECT Email FROM users WHERE Email = '" + emailField.Text + "'", MySQLConnector.GetConnection());
						MySQLConnector.adapter.SelectCommand = MySQLConnector.command;
						MySQLConnector.adapter.Fill(table);
						if (table.Rows.Count < 1)
						{
							MySQLConnector.command.Cancel();
							table.Rows.Clear();

							MD5 md5Hash = MD5.Create();
							byte[] passByte = Encoding.UTF8.GetBytes(passField.Text);
							passByte = md5Hash.ComputeHash(passByte);
							string hash = BitConverter.ToString(passByte).Replace("-", string.Empty);

							string gender = null;
							if (radioMale.Checked)
							{
								gender = radioMale.Text;
							}
							else if (radioFemale.Checked)
							{
								gender = radioFemale.Text;
							}


							MySQLConnector.command = new MySqlCommand("INSERT INTO users VALUES('null','" + loginField.Text + "','" + hash + "'," +
								"'" + nameField.Text + "','" + surnameField.Text + "','" + gender + "'," +
								"'" + emailField.Text + "','" + phoneField.Text + "','user')", MySQLConnector.GetConnection());

							if (MySQLConnector.command.ExecuteNonQuery() == 1)
							{
								MySQLConnector.command.Cancel();
								MessageBox.Show("Ваш аккаунт создан. Пожалуйста авторизуйтесь", "Все по плану", MessageBoxButtons.OK, MessageBoxIcon.Information);
								this.Close();
							}
							else
							{
								MessageBox.Show("Что то пошло реально не по плану", "Ошибка критичная", MessageBoxButtons.OK, MessageBoxIcon.Error);
								MySQLConnector.command.Cancel();
							}
						}
						else
						{
							MessageBox.Show("Данная электронная почта уже имеется в базе", "Ошибка заполнения",
								MessageBoxButtons.OK, MessageBoxIcon.Warning);
							MySQLConnector.command.Cancel();
							table.Rows.Clear();
						}
					}
					else
					{
						MessageBox.Show("Пользователь с таким логином уже существует", "Ошибка заполнения", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						MySQLConnector.command.Cancel();
						table.Rows.Clear();
					}

				}
				else
				{
					MessageBox.Show("Пароли не совпадают", "Ошибка заполнения", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}

			}
			else
			{
				MessageBox.Show("Проверьте правильность заполнения полей", "Ошибка заполнения", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
			catch
			{
				MessageBox.Show("Что то пошло реально не по плану", "Ошибка критичная", MessageBoxButtons.OK, MessageBoxIcon.Error);
				
			}

		}
	}
}
