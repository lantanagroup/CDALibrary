using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CDALibrary.Core.Model
{
    public partial class SubstanceAdministration
    {
        public SubstanceAdministration(SubstanceMoodCodes moodCode, Consumable consumable)
            : this()
        {
            this.MoodCode = moodCode;
            this.Consumable = consumable;
        }
    }
}
