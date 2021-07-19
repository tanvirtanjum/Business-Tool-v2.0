using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTv2._0.EssentialFunction
{
    sealed class Logic
    {
        public bool CheckNumber(String number)
        {
            double ok;
            bool result = Double.TryParse(number, out ok);
            return result;
        }

        public bool CheckIntNumber(String number)
        {
            int ok;
            bool result = Int32.TryParse(number, out ok);
            return result;
        }

        public double getObtainedAmmout(int quantity, double ammout)
        {
            return (quantity * ammout);
        }

        public double getProfit(int quantity, double sammout, double acammout)
        {
            return ((quantity * sammout) - (quantity * acammout));
        }

        public int getNewQuantity(int quantity, int sellQ)
        {
            return (quantity - sellQ);
        }
    }
}
