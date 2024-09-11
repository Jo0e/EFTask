using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDatabase.Model
{
    public class Sale
    {
        public int SaleId { get; set; }
        public DateTime Date { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<Customer> Customers { get; set; }
        public  ICollection<Store> Stores { get; set; }
    }
}
