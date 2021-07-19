using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTv2._0.entity
{
    public class Login
    {
        private string LID;
        private string PASS;
        private int SID;
        public Login() { }
        public Login(string LID, string PASS, int SID) 
        {
            this.LID = LID;
            this.PASS = PASS;
            this.SID = SID;
        }

        public void setLID(string LID)
        {
            this.LID = LID;
        }

        public void setPASS(string PASS)
        {
            this.PASS = PASS;
        }

        public void setSID(int SID)
        {
            this.SID = SID;
        }

        public string getLID()
        {
            return LID;
        }

        public string getPASS()
        {
            return PASS;
        }

        public int getSID()
        {
            return SID;
        }
    }
}
