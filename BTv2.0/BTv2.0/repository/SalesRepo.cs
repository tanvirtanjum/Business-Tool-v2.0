using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data.Common;
using System.Data;
using BTv2._0.entity;
using BTv2._0.Interface;


namespace BTv2._0.repository
{
    class SalesRepo : ISalesRepo
    {
		int id;
		string date;
		DBC dbc;
		public SalesRepo()
		{
			dbc = new DBC();
		}
		public Sales getSale(int SLID)
		{
			Sales sales = null;

			string query = "SELECT `SLID`, `PID`, `QUANT`, `OB_AMMOUNT`, `PROFIT`, `C_NAME`, `C_MOB`, `SOLD_BY`, `Sell_SDate` FROM `sales` WHERE `SLID` like '" + SLID + "';";

			dbc.ConnectDB();
			dbc.ExecuteQuery(query);

			var dr = dbc.cmd.ExecuteReader();

			if (dr.HasRows)
			{
				sales = new Sales();
				dr.Read();

				sales.setSLID(dr.GetInt32(0));
				sales.setPID(dr.GetString(1));
				sales.setQUANT(dr.GetInt32(2));
				sales.setOB_AMMOUNT(dr.GetDouble(3));
				sales.setPROFIT(dr.GetDouble(4));
				sales.setC_NAME(dr.GetString(5));
				sales.setC_MOB(dr.GetString(6));
				sales.setSOLD_BY(dr.GetString(7));
				sales.setSell_SDate(dr.GetDateTime(8));

			}

			dbc.DisConnectDB();

			return sales;
		}

		public DataTable getTable()
		{
			string query = "SELECT * FROM `sales` ORDER BY 	`SLID`,`SOLD_BY`,`PID`;";

			dbc.ConnectDB();
			dbc.ExecuteQuery(query);
			DataTable dt = new DataTable();
			MySqlDataAdapter da = new MySqlDataAdapter(dbc.cmd);
			da.Fill(dt);
			dbc.DisConnectDB();
			return dt;
		}

		public int getLastID()
		{
			string query = "SELECT (auto_increment-1) AS lastId FROM information_schema.tables where table_name = 'sales' AND table_schema = 'bt';";

			dbc.ConnectDB();
			dbc.ExecuteQuery(query);

			var dr = dbc.cmd.ExecuteReader();

			if (dr.HasRows)
			{
				dr.Read();

				id = dr.GetInt32(0);

			}
			dbc.DisConnectDB();

			return id;
		}

		public string getDateTime(int SLID)
		{
			string query = "SELECT `Sell_SDate` FROM `sales` WHERE `SLID` like '" + SLID + "';";

			dbc.ConnectDB();
			dbc.ExecuteQuery(query);

			var dr = dbc.cmd.ExecuteReader();

			if (dr.HasRows)
			{
				dr.Read();

				date = dr.GetDateTime(0).ToString();

			}
			dbc.DisConnectDB();

			return date;
		}

		public void insertSales(string PID, int quant, double obm, double profit, string name, string mob, string EmpID)
		{
			string query = "INSERT INTO `sales`(`PID`, `QUANT`, `OB_AMMOUNT`, `PROFIT`, `C_NAME`, `C_MOB`, `SOLD_BY`, `Sell_SDate`) VALUES('" + PID + "','" + quant + "','" + obm + "','" + profit + "','" + name + "','" + mob + "','" + EmpID + "',current_timestamp());";

			dbc.ConnectDB();
			dbc.ExecuteQuery(query);
			dbc.DisConnectDB();
		}
	}
}
