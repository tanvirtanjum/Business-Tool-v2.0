using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data.Common;
using System.Data;
using BTv2._0.entity;
using BTv2._0.Interface;


namespace BTv2._0.repository
{
    class NoteRepo : INoteRepo
    {
        DBC dbc;

        public NoteRepo()
        {
            dbc = new DBC();
        }

		public DataTable getTable(string owner)
		{
			string query = "SELECT `NoteID`, `NoteName`, `OwnerID` FROM `note` WHERE `OwnerID`='"+owner+"' ORDER BY `NoteID`;";
			
			dbc.ConnectDB();
			dbc.ExecuteQuery(query);
			DataTable dt = new DataTable();
			MySqlDataAdapter da = new MySqlDataAdapter(dbc.cmd);
			da.Fill(dt);
			dbc.DisConnectDB();
			return dt;
		}

		public Note getNote(int NID, string OID)
		{
			Note note = null;

			string query = "SELECT * FROM `note` WHERE `NoteID` like '" + NID + "' AND `OwnerID` like '" + OID + "';";

			dbc.ConnectDB();
			dbc.ExecuteQuery(query);

			var dr = dbc.cmd.ExecuteReader();

			if (dr.HasRows)
			{
				note = new Note();
				dr.Read();

				note.setNoteID(dr.GetInt32(0));
				note.setNoteName(dr.GetString(1));
				note.setOwnerID(dr.GetString(2));
				note.setText(dr.GetString(3));
			}

			dbc.DisConnectDB();

			return note;
		}

		public void insertNote(string NM, string OID, string text)
		{
			string query = "INSERT INTO `note`(`NoteName`, `OwnerID`, `Text`) VALUES ('"+NM+"','"+OID+"','"+text+"');";

			dbc.ConnectDB();
			dbc.ExecuteQuery(query);
			dbc.DisConnectDB();
		}

		public void updateNote(int NID, string notename, string note, string OID)
		{
			string query = "UPDATE `note` SET `NoteName`='" + notename + "',`Text`='" + note + "' WHERE `NoteID` like '" + NID + "' AND `OwnerID` like '" + OID + "';";

			dbc.ConnectDB();
			dbc.ExecuteQuery(query);
			dbc.DisConnectDB();
		}

		public void deleteNote(int NID, string OID)
		{
			string query = "DELETE FROM `note` WHERE `NoteID` like '" + NID + "' AND `OwnerID` like '" + OID + "';";

			dbc.ConnectDB();
			dbc.ExecuteQuery(query);
			dbc.DisConnectDB();
		}
	}
}
