using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CDALibrary.Core.Logic;

namespace CDALibrary.Core.Model
{
    public partial class RegionOfInterest
    {
        public RegionOfInterest(II id, RegionOfInterestCodes code, RegionOfInterestvalue value)
            : this()
        {
            using (new ClinicalDocumentDesigner())
            {
                this.Ids.Add(id);
                this.Code = new CS(code.ToString());
                this.Value = new RegionOfInterestvalue[] { value };
            }
        }
    }
}
