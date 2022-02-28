namespace POOSupermarket
{
    public class VariablePriceProduct : Product
    {
        public string Measurement { get; set; }

        public float Quantity { get; set; }

        public override decimal ValueToPay()
        {
            return (Price * (decimal)Tax + Price) * (decimal) Quantity;
        }
        public override string ToString()
        {
            return$"{base.ToString()}" +
                $"\n\tQuantity...:{$"{Quantity:N2}",18}"+
                $"\n\tMeasurement.:{$"{Measurement:N2}",18}"+                
                $"\n\tValue......:{$"{ValueToPay():C2}",18}";
        }
    }
}