using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadachaWPF14._1
{
    public class Product
    {
        public string Name { get; set; }
        public int Cost { get; set; }
        public string Image { get; set; }
        public ProductCategories Category { get; set; }
    }
    public enum ProductCategories
    {
        Food,
        Appliances
    }
}
