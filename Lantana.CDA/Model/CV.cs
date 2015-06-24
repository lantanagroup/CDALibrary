using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lantana.CDA.Model
{
    public partial class CV
    {
        public CV()
        {

        }

        public CV(string code, string codeSystem)
            : base(code, codeSystem)
        {

        }

        public CV(string code, string codeSystem, string codeSystemName, string displayName)
            : base(code, codeSystem, codeSystemName, displayName)
        {

        }
    }
}
