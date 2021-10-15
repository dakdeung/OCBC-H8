using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

using System.Windows.Forms;

using System.Data;

namespace LoginRegisterWindows
{
	class Config
	{
		string ConnectionString = "";
		public MySqlConnection Connection = null;
public string server = "127.0.0.1";
		public string user = "root";
		public string password = "root";
		DataSet ds;
		DataTable dt;
		public string Table = "user_info";
		public string ConnectionType = "";
		string RecordSource = "";

		DataGridView tempdata;

		public Config()
		{

		}

		public void Connect(string database_name)
		{
			try
			{
				ConnectionString = "Server=" + server + ";" + "DATABASE=" + database_name + ";" + "UID=" + user + ";" + "PASSWORD=" + password + ";";
				Connection = new MySqlConnection(ConnectionString);
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}
		}

		public void ExecuteSql(string Sql_command)
		{
			nowquiee(Sql_command);
		}

		public void nowquiee(string sql_comm)
		{
			try
			{
				MySqlConnection cs = new MySqlConnection(ConnectionString);
				cs.Open();
				MySqlCommand myc = new MySqlCommand(sql_comm, cs);
				myc.ExecuteNonQuery();

				cs.Close();
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}
		}

		public void Execute(string Sql_command)
		{
			RecordSource = Sql_command;
			ConnectionType = Table;
			dt = new DataTable(ConnectionType);
			try
			{
				string command = RecordSource.ToUpper();

				MySqlDataAdapter da2 = new MySqlDataAdapter(RecordSource, Connection);

				DataSet tempds = new DataSet();
				da2.Fill(tempds);
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}
		}

		public string Result(int ROW, string COLUMN_NAME)
		{
			try
			{
				return dt.Rows[ROW][COLUMN_NAME].ToString();
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
				return "";
			}
		}

		public string Results(int ROW, int COLUMN_NAME)
		{
			try
			{
				return dt.Rows[ROW][COLUMN_NAME].ToString();
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
				return dt.Rows[ROW][COLUMN_NAME].ToString();
			}
		}

		public void ExecuteSelect(string Sql_command)
		{
			RecordSource = Sql_command;
			ConnectionType = Table;
			dt = new DataTable(ConnectionType);
			try
			{
				string command = RecordSource.ToUpper();
				MySqlDataAdapter da = new MySqlDataAdapter(RecordSource, Connection);
				ds = new DataSet();
				da.Fill(ds, ConnectionType);
				da.Fill(dt);
				tempdata = new DataGridView();
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}
		}

		public int Count()
		{
			return dt.Rows.Count;
		}
	}
}
