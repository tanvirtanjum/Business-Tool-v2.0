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
    class ProductRepo : IProductRepo
    {
		DBC dbc;
		public ProductRepo()
		{
			dbc = new DBC();
		}
		public Product getProduct(string PID)
		{
			Product product = null;

			string query = "SELECT `PID`, `P_NAME`, `TYPE`, `QUANTITY`, `BUY_PRICE`, `SELL_PRICE`, `MOD_BY`, `Add_PDate` FROM `product` WHERE `PID` like '" + PID+ "';";

			dbc.ConnectDB();
			dbc.ExecuteQuery(query);

			var dr = dbc.cmd.ExecuteReader();

			if (dr.HasRows)
			{
				product = new Product();
				dr.Read();

				product.setPID(dr.GetString(0));
				product.setP_NAME(dr.GetString(1));
				product.setTYPE(dr.GetString(2));
				product.setQUANTITY(dr.GetInt32(3));
				product.setBUYPRICE(dr.GetDouble(4));
				product.setSELLPRICE(dr.GetDouble(5));
				product.setMod_By(dr.GetString(6));
				product.setAdd_PDate(dr.GetDateTime(7));

			}

			dbc.DisConnectDB();

			return product;
		}

		public Product checkProduct(string PID)
		{
			Product product = null;

			string query = "SELECT * FROM `product` WHERE PID='" + PID + "';";

			dbc.ConnectDB();
			dbc.ExecuteQuery(query);

			var dr = dbc.cmd.ExecuteReader();

			if (dr.HasRows)
			{
				product = new Product();
			}

			dbc.DisConnectDB();

			return product;
		}

		public Product checkProductByType(string type)
		{
			Product product = null;

			string query = "SELECT * FROM `product` WHERE `TYPE` like '" + type + "';";

			dbc.ConnectDB();
			dbc.ExecuteQuery(query);

			var dr = dbc.cmd.ExecuteReader();

			if (dr.HasRows)
			{
				product = new Product();
			}

			dbc.DisConnectDB();

			return product;
		}

		public DataTable getTable()
		{
			string query = "SELECT * FROM `product` ORDER BY `TYPE`,`MOD_BY`,`PID`;";

			dbc.ConnectDB();
			dbc.ExecuteQuery(query);
			DataTable dt = new DataTable();
			MySqlDataAdapter da = new MySqlDataAdapter(dbc.cmd);
			da.Fill(dt);
			dbc.DisConnectDB();
			return dt;
		}

		public DataTable getTableByType(string type)
		{
			string query = "SELECT * FROM `product` WHERE `TYPE` like '" + type + "' ORDER BY `PID`, `MOD_BY`;";

			dbc.ConnectDB();
			dbc.ExecuteQuery(query);
			DataTable dt = new DataTable();
			MySqlDataAdapter da = new MySqlDataAdapter(dbc.cmd);
			da.Fill(dt);
			dbc.DisConnectDB();
			return dt;
		}
		public void insertProduct(string PID, string name, string Type, int quant, double buy, double sell, string modby)
		{
			string query = "INSERT INTO `product`(`PID`, `P_NAME`, `TYPE`, `QUANTITY`, `BUY_PRICE`, `SELL_PRICE`, `MOD_BY`, `Add_PDate`) VALUES('" + PID + "','" + name + "','" + Type + "','" + quant + "','" + buy + "','" + sell+ "','" + modby + "',current_timestamp());";

			dbc.ConnectDB();
			dbc.ExecuteQuery(query);
			dbc.DisConnectDB();
		}

		public void deleteProduct(string PID)
		{
			string query = "DELETE FROM `product` WHERE `PID`='" + PID + "';";

			dbc.ConnectDB();
			dbc.ExecuteQuery(query);
			dbc.DisConnectDB();
		}

		public void updateProduct(string PID, string name, string type, int quant, double bp, double sp, string mb)
		{
			string query = "UPDATE `product` SET `P_NAME`='" + name + "',`TYPE`='" + type + "',`QUANTITY`='" + quant + "',`BUY_PRICE`='" + bp + "',`SELL_PRICE`='" + sp + "',`MOD_BY`='" + mb + "' WHERE `PID` like '" + PID + "';";

			dbc.ConnectDB();
			dbc.ExecuteQuery(query);
			dbc.DisConnectDB();
		}

		public void updateProductOnSell(string PID, int quant)
		{
			string query = "UPDATE `product` SET `QUANTITY`='" + quant + "' WHERE `PID` like '" + PID + "';";

			dbc.ConnectDB();
			dbc.ExecuteQuery(query);
			dbc.DisConnectDB();
		}
	}
}
