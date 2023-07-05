using CqrsMediatrDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
