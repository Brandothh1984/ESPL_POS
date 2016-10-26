using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ESPL_POS
{   

    public partial class MainForm : Form
    {

        List<Product> productList = new List<Product>();

        public MainForm()
        {
            //productSKU.Add("P123");

            

            InitializeComponent();

            Product prd = new Product("P123", "Socks", 9.90, 5);
            productList.Add(prd);

            prd = new Product("P345", "Shirts", 10.90, 4);
            productList.Add(prd);

            prd = new Product("P234", "Skirts", 14.90, 3);
            productList.Add(prd);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProductID.Text == "")
                {
                    MessageBox.Show("Enter product ID");
                }
                else
                {
                    var findProduct = productList.Where(wh => wh.ProductSKU == txtProductID.Text);
                    if (findProduct.Any())
                    {
                        MessageBox.Show(findProduct.SingleOrDefault().ProductName);
                        //gridviewData.DataSource = findProduct;
                        //gridviewData.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Item not found!");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
