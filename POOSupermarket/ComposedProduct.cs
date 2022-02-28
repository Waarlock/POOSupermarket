using System.Collections;

namespace POOSupermarket
{
    public class ComposedProduct : Product
    {

        public float Discount { get; set; }

        public int Quantity { get; set; }

        public ICollection Products { get; set; }

        private string asistant { get; set; }

        public decimal Value { get; set; }

        public override decimal ValueToPay()
        {
            Value = 0;
            foreach (Product product in Products)
            {
                float discount = 0;
                // decimal assist;
                //  assist = product.ValueToPay();
                discount = (float)product.ValueToPay()* Discount;
                Value += product.ValueToPay() - (decimal) discount;                  
            }
            return  Value;
        }

        public override string ToString()
        {
            asistant = null;
            foreach (Product productDiscount in Products)
            {
                asistant += productDiscount.Description + ", ";
            }
            return
            $"  {Id}  {Description}\t" +
            $"\n\tProducts...:\t{$"{asistant}",18}" +
            $"\n\tDiscount...:{$"{Discount:P2}",18}" +
            $"\n\tValue......:{$"{ValueToPay():C2}",18}"
            ;
        }
    }
}