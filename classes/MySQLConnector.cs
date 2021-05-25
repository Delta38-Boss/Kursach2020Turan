using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql;
using MySql.Data.MySqlClient;
using MySql.Debugger;
using System.Windows.Forms;

namespace Kursach2020.classes
{
	class MySQLConnector : Config
	{
		private static string connectstr = "Server=" + Config.dbHost + ";User=" + Config.dbUser + ";Database=" + Config.dbName + ";Password=" + Config.dbPass + "; CharSet=utf8;";
		public static MySqlConnection connect = new MySqlConnection(connectstr);
		public static MySqlDataAdapter adapter = new MySqlDataAdapter();
		public static MySqlCommand command;
		public static MySqlDataReader reader;
		public static DataSet dataSet;
		public static string userStatus, userId;
		public static MySqlCommandBuilder builder = new MySqlCommandBuilder();
		/*
		public DataSet dataSet = new DataSet();*/

		public static void openConnection()
		{
			//string connectstr = "Server="+ server + ";User=" + user + ";Database=" + database + ";Password=" + password + ";";
			if (connect.State == ConnectionState.Closed)
			{
				
					Console.WriteLine(connectstr);
					connect.Open();
				
					
				
			}
		}
		public static void closeConnection()
		{
			if (connect.State == ConnectionState.Open)
			{
				connect.Close();
			}
		}
		public static MySqlConnection GetConnection()
		{
			return connect;
		}
		public static void UserLogin(string status, string id)
		{
			userStatus = status;
			userId = id;
			Console.WriteLine(userStatus);
		}
	}
}
