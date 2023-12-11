using System;
using System.Collections.Generic;
using System.Text;

namespace Notatki.Model {
    public class NoteModel {
        public Guid ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
