using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTv2._0.EssentialFunction
{
    sealed class PasswordGenerator
    {
        public string Password()
        {
            Random random = new Random();
            int password = random.Next(1234, 9999);

            return password.ToString();          
        }
    }
}
