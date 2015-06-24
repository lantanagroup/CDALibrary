using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CDALibrary.Core.Logic;

namespace CDALibrary.Core.Model
{
    public partial class Custodian
    {
        public Custodian(II organizationId, ON organizationName)
        {
            using (new ClinicalDocumentDesigner())
            {
                this.AssignedCustodian.RepresentedCustodianOrganization.Ids.Add(organizationId);
                this.AssignedCustodian.RepresentedCustodianOrganization.Name = organizationName;
            }
        }

        public Custodian(II organizationId, string organizationName)
            : this(organizationId, new ON(organizationName))
        {
        }
    }
}
