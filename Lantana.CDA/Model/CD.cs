using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lantana.CDA.Model
{
    public partial class CD
    {
        public CD(string code, string codeSystem, string codeSystemName, string displayName)
        {
            this.Code = code;
            this.CodeSystem = codeSystem;
            this.CodeSystemName = codeSystemName;
            this.DisplayName = displayName;
        }

        public CD(string code, string codeSystem)
        {
            this.Code = code;
            this.CodeSystem = codeSystem;
        }

        public CD()
        {

        }
    }
}
