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

        List<Product> productList = new List<Product>();

        public Product(string sku, string pName, double pr, int _qty)
        {
            productSKU = sku;
            productName = pName;
            price = pr;
            qty = _qty;
        }

        public Product() {
            Product prd = new Product("P123", "Socks", 9.90, 5);
            productList.Add(prd);

            prd = new Product("P345", "Shirts", 10.90, 4);
            productList.Add(prd);

            prd = new Product("P234", "Skirts", 14.90, 3);
            productList.Add(prd);
        }

        public List<Product> returnProductList()
        {
            return productList;
        }

        public List<Product> returnProductListBySKUID(string sku)
        {
            return productList.Where(wh => wh.productSKU == sku).ToList();
        }

        public Product returnProductList(string sku)
        {
            return productList.Where(wh => wh.productSKU == sku).SingleOrDefault();
        }

    }
}
