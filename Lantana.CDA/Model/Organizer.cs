using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lantana.CDA.Model
{
    public partial class Organizer
    {
        public Organizer()
        {
            this.moodCodeField = "EVN";
        }

        public Organizer(OrganizerClassCodes classCode, CS statusCode)
            : this()
        {
            this.classCodeField = classCode;
            this.statusCodeField = statusCode;
        }
    }
}
