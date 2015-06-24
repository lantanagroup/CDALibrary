using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lantana.CDA.Model
{
    public partial class Consumable
    {
        public Consumable(ManufacturedProduct product)
        {
            this.ManufacturedProduct = product;
        }
    }
}
