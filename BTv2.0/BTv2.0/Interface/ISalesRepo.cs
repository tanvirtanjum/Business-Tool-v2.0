using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BTv2._0.entity;

namespace BTv2._0.Interface
{
    interface ISalesRepo
    {
		Sales getSale(int SLID);

		DataTable getTable();

		int getLastID();

		string getDateTime(int SLID);

	    void insertSales(string PID, int quant, double obm, double profit, string name, string mob, string EmpID);
	}
}
