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
	public partial class FormMessage : Form
	{
		static List<string> postsId = new List<string>();
		public FormMessage()
		{
			InitializeComponent();
		}

		private void FormMessage_Load(object sender, EventArgs e)
		{
			MySQLConnector.command = new MySqlCommand("SELECT Header, ID FROM messages WHERE ToID = '"+MySQLConnector.userId +"' ORDER BY ID DESC", MySQLConnector.GetConnection());
			//MySQLConnector.adapter = new MySqlDataAdapter(MySQLConnector.command);
			MySQLConnector.reader = MySQLConnector.command.ExecuteReader();
			//MySQLConnector.adapter.Fill(MySQLConnector.dataSet, "Proposition");
			postsId.Clear();
			Console.WriteLine(MySQLConnector.reader.FieldCount);
			while (MySQLConnector.reader.Read())
			{

				listView1.Items.Add(MySQLConnector.reader[0].ToString());
				postsId.Add(MySQLConnector.reader[1].ToString());



			}
			MySQLConnector.command.Cancel();
			MySQLConnector.reader.Close();
		}

		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(listView1.SelectedItems.Count > 0)
				{

				Console.WriteLine(listView1.SelectedItems[0].Text);
				Console.WriteLine("INDEX = " + listView1.SelectedIndices[0]);
				Console.WriteLine("ID = " + postsId[listView1.SelectedIndices[0]]);
				MySQLConnector.command = new MySqlCommand("SELECT Message, IsChecked FROM messages WHERE ID = '" + postsId[listView1.SelectedIndices[0]] + "' ", MySQLConnector.GetConnection());


				MySQLConnector.adapter = new MySqlDataAdapter(MySQLConnector.command);
				MySQLConnector.builder = new MySqlCommandBuilder(MySQLConnector.adapter);
				DataTable table = new DataTable();

				MySQLConnector.adapter.Fill(table);
				messageLabel.Text =  table.Rows[0][0].ToString();
				MySQLConnector.command.Cancel();
				
				if (table.Rows[0][1].ToString() == "no")
				{
					MySQLConnector.command = new MySqlCommand("UPDATE messages SET IsChecked = 'yes' WHERE ID = '" + postsId[listView1.SelectedIndices[0]] + "'", MySQLConnector.GetConnection());
					MySQLConnector.command.ExecuteNonQuery();
			
						MySQLConnector.command.Cancel();
			    }
				table.Clear();

			}
	    }
	}
}
