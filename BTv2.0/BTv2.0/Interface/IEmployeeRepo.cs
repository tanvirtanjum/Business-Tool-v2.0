using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BTv2._0.entity;

namespace BTv2._0.Interface
{
    interface IEmployeeRepo
    {
		Employee getEmployee(string LID);

		Employee checkUser(string LID);

		DataTable getTable();

		void insertEmployee(string EmpID, string name, int did, double sal, string mob, string addedby);

		void deleteEmployee(string EmpID);

		void updateEmployee(string EmpID, string name, int did, double sal, string mob);
	}

}
