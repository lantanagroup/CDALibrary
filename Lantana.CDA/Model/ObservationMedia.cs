using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lantana.CDA.Model
{
    public partial class ObservationMedia
    {
        public ObservationMedia()
        {
            this.classCodeField = "OBS";
            this.moodCodeField = "EVN";
        }

        public ObservationMedia(ED value)
            : this()
        {
            this.valueField = value;
        }
    }
}
