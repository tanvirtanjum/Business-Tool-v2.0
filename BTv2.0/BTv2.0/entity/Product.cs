using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTv2._0.entity
{
    public class Product
    {
        private string PID;
        private string P_NAME;
        private string TYPE;
        private int QUANTITY;
        private double BUYPRICE;
        private double SELLPRICE;
        private string Mod_By;
        private DateTime Add_PDate;

        public Product() { }

        public Product(string PID, string P_NAME, string TYPE, int QUANTITY, double BUYPRICE, double SELLPRICE, string Mod_By, DateTime Add_PDate)
        {
            this.PID = PID;
            this.P_NAME = P_NAME;
            this.TYPE = TYPE;
            this.QUANTITY = QUANTITY;
            this.BUYPRICE = BUYPRICE;
            this.SELLPRICE = SELLPRICE;
            this.Mod_By = Mod_By;
            this.Add_PDate = Add_PDate;
        }

        public void setPID(string PID)
        {
            this.PID = PID;
        }

        public void setP_NAME(string P_NAME)
        {
            this.P_NAME = P_NAME;
        }

        public void setTYPE(string TYPE)
        {
            this.TYPE = TYPE;
        }

        public void setQUANTITY(int QUANTITY)
        {
            this.QUANTITY = QUANTITY;
        }

        public void setBUYPRICE(double BUYPRICE)
        {
            this.BUYPRICE = BUYPRICE;
        }

        public void setSELLPRICE(double SELLPRICE)
        {
            this.SELLPRICE = SELLPRICE;
        }

        public void setMod_By(string Mod_By)
        {
            this.Mod_By = Mod_By;
        }

        public void setAdd_PDate(DateTime Add_PDate)
        {
            this.Add_PDate = Add_PDate;
        }

        public string getPID()
        {
            return PID;
        }

        public string getP_NAME()
        {
            return P_NAME;
        }

        public string getTYPE()
        {
            return TYPE;
        }

        public int getQUANTITY()
        {
            return QUANTITY;
        }

        public double getBUYPRICE()
        {
            return BUYPRICE;
        }

        public double getSELLPRICE()
        {
            return SELLPRICE;
        }

        public string getMod_By()
        {
            return Mod_By;
        }

        public DateTime getAdd_PDate()
        {
            return Add_PDate;
        }
    }
}
