using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kursach2020.classes;
using MySql;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Kursach2020.classes
{
	class MessageToUser
	{
		public static void SendMessage(string sendTo, string header, string message)
		{
			try
			{
				DateTime date = DateTime.Now;

				MySQLConnector.command = new MySqlCommand("INSERT INTO Messages VALUES('null','" + MySQLConnector.userId + "', '" + sendTo + "', '" + header + "', '" + message + "','" + date.ToString("yyyy-MM-dd") + "', 'no')", MySQLConnector.GetConnection());
				MySQLConnector.command.ExecuteNonQuery();
				MySQLConnector.command.Cancel();
			}
			catch (MySqlException e)
			{
				MessageBox.Show("Ошибка при отправки сообщения " + e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		    
		}
	}
}
