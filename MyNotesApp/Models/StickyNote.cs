using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotesApp.Models
{
    class StickyNote
    {
        /// <summary>
        /// Person the note is for
        /// </summary>
        public Person NoteIsFor { get; set; }
        /// <summary>
        /// The text on the note
        /// </summary>
        public string NoteText { get; set; }


    }
}
