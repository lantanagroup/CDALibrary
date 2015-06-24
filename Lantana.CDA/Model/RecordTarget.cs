using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Lantana.CDA.Logic;

namespace Lantana.CDA.Model
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
