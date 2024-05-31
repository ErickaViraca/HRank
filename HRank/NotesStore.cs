using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HRank
{
    public class NotesStore
    {
        public string name
        {
            get;
            set;
        }
        public string state
        {
            get;
            set;
        }
        new List<NotesStore> notes;
        public NotesStore() {
            notes = new List<NotesStore>();
        }

        public void AddNote(string state, string name) {
            if (string.IsNullOrEmpty(name)) { throw new Exception(message: "Name cannot be empty"); }
            if (!Enum.IsDefined(typeof(States), state)) { throw new Exception($"Invalid state {state}"); }
            else {
                this.name = name;
                this.state = state;
                notes.Add(new NotesStore());
            }
        }
        public List<string> GetNotes(string state) {
            if (!Enum.IsDefined(typeof(States), state)) { throw new Exception($"Invalid state {state}"); }
            else {
                List<string> result = new List<string>();
                foreach (var note in notes) {
                    if (note.state == state) { 
                        result.Add(note.name);
                    }
                }
                return result;
            }
        }
    }

    public enum States
    {
        active,
        completed,
        others
    }

}
