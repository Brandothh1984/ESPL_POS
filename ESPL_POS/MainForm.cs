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

        Product prd = new Product();
        DataTable posTable = new DataTable();

        public MainForm()
        {
            //productSKU.Add("P123");

            

            InitializeComponent();

            posTable = createTable();

            //Product prd = new Product("P123", "Socks", 9.90, 5);
            //productList.Add(prd);

            //prd = new Product("P345", "Shirts", 10.90, 4);
            //productList.Add(prd);

            //prd = new Product("P234", "Skirts", 14.90, 3);
            //productList.Add(prd);
        }

        public DataTable createTable()
        {
            DataTable dTable = new DataTable();

            DataColumn dColumn = new DataColumn("ProductID", typeof(string));
            dTable.Columns.Add(dColumn);

            dColumn = new DataColumn("ProductName", typeof(string));
            dTable.Columns.Add(dColumn);

            dColumn = new DataColumn("Price", typeof(double));
            dTable.Columns.Add(dColumn);

            dColumn = new DataColumn("Qty", typeof(int));
            dTable.Columns.Add(dColumn);

            return dTable;
        }

        public DataTable addToTable(Product prd, DataTable dTable)
        {
            DataRow dRow;
            dRow = dTable.NewRow();

            dRow[0] = prd.ProductSKU;
            dRow[1] = prd.ProductName;
            dRow[2] = prd.Price;
            dRow[3] = 1;

            dTable.Rows.Add(dRow);

            return dTable;
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
                    //var findProduct = productList.Where(wh => wh.ProductSKU == txtProductID.Text);
                    var findProduct = prd.returnProductList(txtProductID.Text);

                    if (findProduct != null)
                    {

                        addToTable(findProduct, posTable);
                        //MessageBox.Show(findProduct.ProductName);
                        gridviewData.DataSource = posTable;
                        gridviewData.Refresh();


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
