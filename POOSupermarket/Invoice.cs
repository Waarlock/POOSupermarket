namespace POOSupermarket
{
    public class Invoice : IPay
    {
       // private string _products;

        private List<Product> _products = new List<Product>();

        public Invoice() // (string Products)
        {
           // _products = new List<Product>();    
        }

        //public List<Product> Get_products()
        //{
        //    return _products;
        //}

        public decimal ValueToPay()
        {          
            decimal Value = 0;
            foreach (Product product in _products)
            {
            Value += product.ValueToPay() ;
            }
            return Value;
        }
        public Product AddProduct(Product product)
        {
            _products.Add(product);
            return product;
        } 

        public override string ToString()
        {
            Console.WriteLine("\nRECEIPT\n_______________________________________");

            //Console.WriteLine(string.Join(", ", _products));
            foreach (Product product in _products)
            {
                Console.WriteLine(product.ToString());
            }
            return $"                    ==================="+
               $"\nTOTAL:          {$"{ValueToPay():C2}",18}";
        }
    }
}