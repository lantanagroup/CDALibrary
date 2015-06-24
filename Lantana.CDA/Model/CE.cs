using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lantana.CDA.Model
{
    public partial class CE
    {
        public CE(string code, string codeSystem, string codeSystemName, string displayName)
            : base(code, codeSystem, codeSystemName, displayName)
        {

        }

        public CE(string code, string codeSystem)
            : base(code, codeSystem)
        {

        }

        public CE()
        {

        }
    }
}
