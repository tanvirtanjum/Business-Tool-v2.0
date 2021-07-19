using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTv2._0.entity;

namespace BTv2._0.Interface
{
    interface IProductRepo
    {
		Product getProduct(string PID);

		Product checkProduct(string PID);

		Product checkProductByType(string type);

		DataTable getTable();

		DataTable getTableByType(string type);

		void insertProduct(string PID, string name, string Type, int quant, double buy, double sell, string modby);

		void deleteProduct(string PID);

		void updateProduct(string PID, string name, string type, int quant, double bp, double sp, string mb);

		void updateProductOnSell(string PID, int quant);
		
	}
}
