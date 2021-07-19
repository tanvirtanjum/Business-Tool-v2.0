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
    class LoginRepo : ILoginRepo
    {
		DBC dbc;
        public LoginRepo()
		{
			dbc = new DBC();
		}

		public Login getLogin(string LID, string PASS)
		{
			Login login = null;
			string query = "SELECT LID,SID,PASS FROM `log_in` WHERE LID='" + LID + "' AND PASS= '" + PASS + "';";

			dbc.ConnectDB();
			dbc.ExecuteQuery(query);

			var dr = dbc.cmd.ExecuteReader();

			if (dr.HasRows)
			{
				login = new Login();
				dr.Read();

				login.setLID(dr.GetString(0));
				login.setSID(dr.GetInt32(1));
				login.setPASS(dr.GetString(2));
			}

			dbc.DisConnectDB();

			return login;
		}

		public Login checkUser(string LID)
		{
			Login login = null;
			string query = "SELECT LID,SID,PASS FROM `log_in` WHERE LID='" + LID + "';";

			dbc.ConnectDB();
			dbc.ExecuteQuery(query);

			var dr = dbc.cmd.ExecuteReader();

			if (dr.HasRows)
			{
				login = new Login();
				dr.Read();
			}
			dbc.DisConnectDB();

			return login;
		}
		public void updateLoginPass(string LID, string newPass)
		{
			string query = "UPDATE `log_in` SET `PASS`=" + newPass + " WHERE LID='" + LID + "';";

			dbc.ConnectDB();
			dbc.ExecuteQuery(query);
			dbc.DisConnectDB();
		}

		public void insertLogin(string LID, int SID, string PASS)
		{
			string query = "INSERT INTO `log_in`(`LID`, `SID`, `PASS`) VALUES ('" + LID + "','" + SID + "','" + PASS + "');";

			dbc.ConnectDB();
			dbc.ExecuteQuery(query);
			dbc.DisConnectDB();
		}


		public void deleteLogin(string LID)
		{
			string query = "DELETE FROM `log_in` WHERE LID='" + LID + "';";

			dbc.ConnectDB();
			dbc.ExecuteQuery(query);
			dbc.DisConnectDB();
		}

		public void updateLoginSID(string LID, int SID)
		{
			string query = "UPDATE `log_in` SET `SID`='" + SID + "' WHERE `LID`='" + LID + "';";

			dbc.ConnectDB();
			dbc.ExecuteQuery(query);
			dbc.DisConnectDB();
		}
	}
}
