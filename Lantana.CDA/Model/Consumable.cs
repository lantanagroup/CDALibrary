using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CDALibrary.Core.Model
{
    public partial class Consumable
    {
        public Consumable(ManufacturedProduct product)
        {
            this.ManufacturedProduct = product;
        }
    }
}
