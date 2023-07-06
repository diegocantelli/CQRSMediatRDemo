using CqrsMediatrDemo.Domain;

namespace CqrsMediatrDemo.Data
{
    public class FakeDataStore
    {
        private List<Product> _products;

        public FakeDataStore()
        {
            _products = new List<Product>()
            {
                new Product{ Id = 1, Name = "Test Product 1" },
                new Product{ Id = 2, Name = "Test Product 2" },
                new Product{ Id = 3, Name = "Test Product 3" }
            };
        }

        public IList<Product> GetAll()
        {
            return _products;
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public Product GetById(int id)
        {
            return _products.FirstOrDefault(x => x.Id == id);
        }

        public void EventOccured(Product product, string evt)
        {
            _products.Single(x => x.Id == product.Id).Name = $"{product.Name} evt: {evt}";
        }
    }
}
