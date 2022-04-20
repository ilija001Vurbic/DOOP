using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOOP_LV4
{
    class DiscountedItem : RentableDecorator
    {
        int discount;
        public DiscountedItem(IRentable rentable, int discount) : base(rentable) {
            this.discount = discount;
        }
        public override double CalculatePrice()
        {
            return base.CalculatePrice() * (1-discount/100.0);
        }
        public override String Description
        {
            get
            {
                return base.Description+" now at "+discount+"% off.";
            }
        }
    }
}
