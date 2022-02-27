namespace POOSupermarket
{
    public abstract class Product : IPay
    {
        public string Description { get; set; }

        public int Id { get; set; }

        public decimal Price { get; set; }

        public float Tax { get; set; }

        public abstract decimal ValueToPay();

        public override string ToString()
        {
            return $"  {Id}  {Description}\n\t" +
                $"Price......:{$"{Price:C2}",18} \n\t" +
                $"Tax........:{$"{Tax:P2}",18}"
                ;
        }
    }
}
