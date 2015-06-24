using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CDALibrary.Core.Model
{
    public partial class CS
    {
        public CS()
        {

        }

        public CS(string code)
        {
            this.Code = code;
        }

        public CS(string code, string codeSystem)
            : base(code, codeSystem)
        {
        }

        public CS(string code, string codeSystem, string codeSystemName, string displayName)
            : base(code, codeSystem, codeSystemName, displayName)
        {
        }

        public CS(string code, string codeSystem, string codeSystemName, string displayName, string originalText)
            : base(code, codeSystem, codeSystemName, displayName)
        {
            this.OriginalText = new ED()
            {
                Text = new string[] { originalText }
            };
        }
    }
}
