using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lantana.CDA.Model
{
    public partial class ON
    {
        public ON()
        {

        }

        public ON(string name)
        {
            this.Text = new string[] { name };
        }
    }
}
