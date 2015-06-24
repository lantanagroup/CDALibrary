﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CDALibrary.Core.Model
{
    public partial class Procedure
    {
        public Procedure()
        {
            this.classCodeField = "PROC";
        }

        public Procedure(ProcedureMoodCodes moodCode)
            : this()
        {
            this.moodCodeField = moodCode;
        }
    }
}
