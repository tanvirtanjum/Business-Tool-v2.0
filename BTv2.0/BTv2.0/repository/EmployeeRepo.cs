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
	class EmployeeRepo : IEmployeeRepo
	{
		DBC dbc;
		public EmployeeRepo()
		{
			dbc = new DBC();
		}
		public Employee getEmployee(string LID)
		{
			Employee employee = null;

			string query = "SELECT `EmpID`, `E_NAME`, `DID`, `SAL`, `E_MOB`, `JOIN_DATE`, `ADDED_BY` FROM `employee` WHERE EmpID='" + LID + "';";

			dbc.ConnectDB();
			dbc.ExecuteQuery(query);

			var dr = dbc.cmd.ExecuteReader();

			if (dr.HasRows)
			{
				employee = new Employee();
				dr.Read();

				employee.setEmpID(dr.GetString(0));
				employee.setE_NAME(dr.GetString(1));
				employee.setDID(dr.GetInt32(2));
				employee.setSAL(dr.GetDouble(3));
				employee.setE_MOB(dr.GetString(4));
				employee.setJoin_Date(dr.GetDateTime(5));
				employee.setAdded_by(dr.GetString(6));

			}

			dbc.DisConnectDB();

			return employee;
		}

		public Employee checkUser(string LID)
		{
			Employee employee = null;

			string query = "SELECT `EmpID`, `E_NAME`, `DID`, `SAL`, `E_MOB`, `JOIN_DATE`, `ADDED_BY` FROM `employee` WHERE EmpID='" + LID + "';";

			dbc.ConnectDB();
			dbc.ExecuteQuery(query);

			var dr = dbc.cmd.ExecuteReader();

			if (dr.HasRows)
			{
				employee = new Employee();
			}

			dbc.DisConnectDB();

			return employee;
		}

		public DataTable getTable()
		{
			string query = "SELECT * FROM `employee` ORDER BY `DID`,`EmpID`;";

			dbc.ConnectDB();
			dbc.ExecuteQuery(query);
			DataTable dt = new DataTable();
			MySqlDataAdapter da = new MySqlDataAdapter(dbc.cmd);
			da.Fill(dt);
			dbc.DisConnectDB();
			return dt;
		}

		public void insertEmployee(string EmpID, string name, int did, double sal, string mob, string addedby)
		{
			string query = "INSERT INTO `employee`(`EmpID`, `E_NAME`, `DID`, `SAL`, `E_MOB`, `JOIN_DATE`, `ADDED_BY`) VALUES('" + EmpID + "','" + name + "','" + did + "','" + sal + "','" + mob + "',current_timestamp(),'" + addedby + "');";

			dbc.ConnectDB();
			dbc.ExecuteQuery(query);
			dbc.DisConnectDB();	
		}

		public void deleteEmployee(string EmpID)
		{
			string query = "DELETE FROM `employee` WHERE `EmpID`='" + EmpID + "';";

			dbc.ConnectDB();
			dbc.ExecuteQuery(query);
			dbc.DisConnectDB();
		}

		public void updateEmployee(string EmpID, string name, int did, double sal, string mob)
		{
			string query = "UPDATE `employee` SET `E_NAME`='" + name + "',`DID`='" + did + "',`SAL`='" + sal + "',`E_MOB`='" + mob + "' WHERE `EmpID`='" + EmpID + "';";

			dbc.ConnectDB();
			dbc.ExecuteQuery(query);
			dbc.DisConnectDB();
		}

	}
}
