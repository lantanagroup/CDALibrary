using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lantana.CDA.Model
{
    public partial class InfrastructureRootTypeId
    {
        public InfrastructureRootTypeId()
        {

        }

        public InfrastructureRootTypeId(string root, string extension)
            : base(root, extension)
        {

        }

        public InfrastructureRootTypeId(string root)
            : base(root)
        {

        }
    }
}
