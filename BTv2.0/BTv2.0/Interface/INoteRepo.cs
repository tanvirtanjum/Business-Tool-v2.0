using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BTv2._0.entity;

namespace BTv2._0.Interface
{
    interface INoteRepo
    {
		DataTable getTable(string owner);

		Note getNote(int NID, string OID);

		void insertNote(string NM, string OID, string text);

		void updateNote(int NID, string notename, string note, string OID);

		void deleteNote(int NID, string OID);
	}
}
