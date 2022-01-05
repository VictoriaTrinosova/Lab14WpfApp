using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14WpfApp
{
    public enum CategoryProducts
    {
        Food,
        Householdappliances
    }
    public class Products
    {
        public string NameProduct { get; set; }
        public int PriceProduct { get; set; }
        public string PictureProduct { get; set; }
        public CategoryProducts CategoryProduct { get; set; }
    }
}
