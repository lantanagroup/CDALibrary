using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CDALibrary.Core.Logic;

namespace CDALibrary.Core.Model
{
    public partial class RecordTarget
    {
        public RecordTarget(II id)
        {
            using (new ClinicalDocumentDesigner())
            {
                this.PatientRole.Ids.Add(id);
            }
        }
    }
}
