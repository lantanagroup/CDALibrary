using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lantana.CDA.Model
{
    public partial class Observation
    {
        public Observation()
        {

        }

        public Observation(ActClassObservationClassCodes classCode, ObservationMoodCodes moodCode, CD code)
        {
            this.classCodeField = classCode.ToString();
            this.moodCodeField = moodCode;
            this.codeField = code;
        }
    }
}
