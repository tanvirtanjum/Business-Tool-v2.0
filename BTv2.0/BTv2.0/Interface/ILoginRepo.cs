using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BTv2._0.entity;

namespace BTv2._0.Interface
{
    interface ILoginRepo
    {
		Login getLogin(string LID, string PASS);
		Login checkUser(string LID);

		void updateLoginPass(string LID, string newPass);

		void insertLogin(string LID, int SID, string PASS);

		void deleteLogin(string LID);

		void updateLoginSID(string LID, int SID);
		
	}
}
