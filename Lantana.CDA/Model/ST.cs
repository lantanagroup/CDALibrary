using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lantana.CDA.Model
{
    public partial class ST
    {
        public ST()
        {

        }

        public ST(string text)
        {
            this.Text = new string[] { text };
        }
    }
}
