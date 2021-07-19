using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTv2._0.entity
{
    public class Note
    {
        private int NoteID;
        private string NoteName;
        private string OwnerID;
        private string text;
        public Note() { }
        public Note(int NoteID, string NoteName, string OwnerID, string text)
        {
            this.NoteID = NoteID;
            this.NoteName = NoteName;
            this.OwnerID = OwnerID;
            this.text = text;
        }

        public void setNoteID(int NoteID)
        {
            this.NoteID = NoteID;
        }

        public void setNoteName(string NoteName)
        {
            this.NoteName = NoteName;
        }

        public void setOwnerID(string OwnerID)
        {
            this.OwnerID = OwnerID;
        }

        public void setText(string text)
        {
            this.text = text;
        }

        public int getNoteID()
        {
            return NoteID;
        }

        public string getNoteName()
        {
            return NoteName;
        }

        public string getOwnerID()
        {
            return OwnerID;
        }

        public string getText()
        {
            return text;
        }
    }
}
