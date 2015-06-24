﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lantana.CDA.Model
{
    public partial class Encounter
    {
        public Encounter()
        {
            this.classCodeField = "ENC";
        }

        public Encounter(EncounterMoodCodes moodCode)
            : this()
        {
            this.moodCodeField = moodCode;
        }
    }
}
