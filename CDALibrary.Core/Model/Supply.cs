﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CDALibrary.Core.Model
{
    public partial class Supply
    {
        public Supply(SupplyClassCodes classCode, SubstanceMoodCodes moodCode)
        {
            this.ClassCode = classCode;
            this.MoodCode = moodCode;
        }
    }
}
