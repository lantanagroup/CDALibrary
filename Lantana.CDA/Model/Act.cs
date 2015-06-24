using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lantana.CDA.Model
{
    public partial class Act
    {
        public Act()
        {

        }

        public Act(ActClassCodes classCode, ActMoodCodes moodCode, CE code)
        {
            this.classCodeField = classCode;
            this.moodCodeField = moodCode;
            this.codeField = code;
        }
    }
}
