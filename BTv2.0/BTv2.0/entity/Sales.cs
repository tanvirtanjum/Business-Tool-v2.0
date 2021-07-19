using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTv2._0.entity
{
    public class Sales
    {
        private int SLID;
        private string PID;
        private int QUANT;
        private double OB_AMMOUNT;
        private double PROFIT;
        private string C_NAME;
        private string C_MOB;
        private string SOLD_BY;
        private DateTime Sell_SDate;

        public Sales() { }

        public Sales(int SLID, string PID,int QUANT, double OB_AMMOUNT, double PROFIT, string C_NAME, string C_MOB, string SOLD_BY, DateTime Sell_SDate)
        {
            this.SLID = SLID;
            this.PID = PID;
            this.QUANT = QUANT;
            this.OB_AMMOUNT = OB_AMMOUNT;
            this.PROFIT = PROFIT;
            this.C_NAME = C_NAME;
            this.C_MOB = C_MOB;
            this.SOLD_BY = SOLD_BY;
            this.Sell_SDate = Sell_SDate;
        }

        public void setSLID(int SLID)
        {
            this.SLID = SLID;
        }

        public void setPID(string PID)
        {
            this.PID = PID;
        }

        public void setQUANT(int QUANT)
        {
            this.QUANT = QUANT;
        }

        public void setOB_AMMOUNT(double OB_AMMOUNT)
        {
            this.OB_AMMOUNT = OB_AMMOUNT;
        }

        public void setPROFIT(double PROFIT)
        {
            this.PROFIT = PROFIT;
        }

        public void setC_NAME(string C_NAME)
        {
            this.C_NAME = C_NAME;
        }

        public void setC_MOB(string C_MOB)
        {
            this.C_MOB = C_MOB;
        }

        public void setSOLD_BY(string SOLD_BY)
        {
            this.SOLD_BY = SOLD_BY;
        }

        public void setSell_SDate(DateTime Sell_SDate)
        {
            this.Sell_SDate = Sell_SDate;
        }

        public int getSLID()
        {
            return SLID;
        }

        public string getPID()
        {
            return PID;
        }

        public int getQUANT()
        {
            return QUANT;
        }

        public double getOB_AMMOUNT()
        {
            return OB_AMMOUNT;
        }

        public double getPROFIT()
        {
            return PROFIT;
        }

        public string getC_NAME()
        {
            return C_NAME;
        }

        public string getC_MOB()
        {
            return C_MOB;
        }

        public string getSOLD_BY()
        {
            return SOLD_BY;
        }

        public DateTime getSell_SDate()
        {
            return Sell_SDate;
        }
    }
}
