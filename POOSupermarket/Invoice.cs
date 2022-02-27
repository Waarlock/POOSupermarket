namespace POOSupermarket
{
    public class Invoice : IPay
    {
       // private string _products;

        private List<Product> _products = new List<Product>();
        //public Invoice(string Products)
        //{

        //}

        //public List<Product> Get_products()
        //{
        //    return _products;
        //}

        public decimal ValueToPay()
        {
            decimal acumulator = 0;
            foreach (Product product in _products)
            {
            acumulator += product.ValueToPay();
            }
            return acumulator ;
        }
        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public override string ToString()

        {
            Console.WriteLine("\nRECEIPT\n_______________________________________");

            Console.WriteLine(string.Join("\n ", _products));
            //foreach (Product product in _products)
            //{
            //    Console.WriteLine(product.ToString());
            //}

            return $"                    ==================="+
               $"\nTOTAL:          {$"{ValueToPay():C2}",18}";
        }
    }
}