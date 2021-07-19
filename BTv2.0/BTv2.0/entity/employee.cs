using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTv2._0.entity
{
    class Employee
    {
        private string EmpID;
        private string E_NAME;
        private int DID;
        private double SAL;
        private string E_MOB;
        private DateTime Join_Date; //Have to convert in DD/MM/YYYY
        private string Added_By;

        public Employee() { }

        public Employee(string EmpID, string E_NAME, int DID, double SAL, string E_MOB, DateTime Join_Date, string Added_By)
        {
            this.EmpID = EmpID;
            this.E_NAME = E_NAME;
            this.DID = DID;
            this.SAL = SAL;
            this.E_MOB = E_MOB;
            this.Join_Date = Join_Date;
            this.Added_By = Added_By;
        }

        public void setEmpID(string EmpID)
        {
            this.EmpID = EmpID;
        }

        public void setE_NAME(string E_NAME)
        {
            this.E_NAME = E_NAME;
        }

        public void setDID(int DID)
        {
            this.DID = DID;
        }

        public void setSAL(double SAL)
        {
            this.SAL = SAL;
        }

        public void setE_MOB(string E_MOB)
        {
            this.E_MOB = E_MOB;
        }

        public void setJoin_Date(DateTime Join_Date)
        {
            this.Join_Date = Join_Date;
        }

        public void setAdded_by(string Added_By)
        {
            this.Added_By = Added_By;
        }

        public string getEmpID()
        {
            return EmpID;
        }

        public string getE_NAME()
        {
            return E_NAME;
        }

        public int getDID()
        {
            return DID;
        }

        public double getSAL()
        {
            return SAL;
        }

        public string getE_MOB()
        {
            return E_MOB;
        }

        public DateTime getJoin_Date()
        {
            return Join_Date;
        }

        public string getAdded_By()
        {
            return Added_By;
        }
    }
}
