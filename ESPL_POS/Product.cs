using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPL_POS
{
    public class Product
    {
        string productSKU;

        public string ProductSKU
        {
            get { return productSKU; }
            set { productSKU = value; }
        }


        string productName;

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }


        double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        int qty;

        public int Qty
        {
            get { return qty; }
            set { qty = value; }
        }



        public Product(string sku, string pName, double pr, int _qty)
        {
            productSKU = sku;
            productName = pName;
            price = pr;
            qty = _qty;
        }

        public Product() { }
    }
}
