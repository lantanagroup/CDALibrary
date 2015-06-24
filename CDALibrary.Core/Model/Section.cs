using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CDALibrary.Core.Model
{
    public partial class Section
    {
        public Section(CE code, ST title)
        {
            this.Code = code;
            this.Title = title;
        }

        public Section(CE code, string title)
            : this(code, new ST(title))
        {
        }

        public void AddEntries(params Entry[] entries)
        {
            this.Entries = new List<Entry>(entries);
        }

        public void AddEntries(params IClinicalStatement[] clinicalStatements)
        {
            this.Entries = new List<Entry>();

            foreach (IClinicalStatement currentStatement in clinicalStatements)
            {
                this.Entries.Add(new Entry(currentStatement));
            }
        }
    }
}
