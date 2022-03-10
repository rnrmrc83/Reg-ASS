

using System.Linq;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using ShopReg.Models;


namespace ShopReg
{
    public partial class FormHome : Form
    {

        string connectionString = ConfigurationManager.ConnectionStrings["connectionString01"].ConnectionString;
        int productQtyDesidered = 1;
        string productCmbSelected = "";

        public FormHome()
        {
            InitializeComponent();
            InitializeAll();

        }

        private void InitializeAll()
        {
            //cmbFilter.Text = "Product Category";
            txtOrderQty.Text = "1";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    label2.Text = "Connected to DB";
                    label2.ForeColor = Color.Green;
                    con.Close();

                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can not open connection!!");
                    label2.Text = "Not Connected";
                    label2.ForeColor = Color.Red;
                }
            }

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                CalculatePurchasePrice.Enabled = false;
                try
                {
                    con.Open();
                    DbContext dc = new DbContext();
                    var qCombo = (from product in dc.Products
                                  where product.QtyAvailable > productQtyDesidered
                                  select new
                                  {
                                      IdCategory = product.IdCategory,
                                      Product = product.Description,

                                  }).Distinct();

                    cmbFilter.DataSource = qCombo.ToList();
                    cmbFilter.ValueMember = "Product";
                    cmbFilter.DisplayMember = "Product";
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                productCmbSelected = cmbFilter.Text.ToString();


            }
        }


        public void DisplayDefault()
        {
            
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    DbContext dc = new DbContext();
                    
                    dataGridViewProduct.DataSource = null;

                    var qProducts = (from t_product in dc.Products
                                     join t_supplier in dc.Suppliers on t_product.IdSupplier equals t_supplier.Id
                                     where t_product.QtyAvailable > productQtyDesidered && (t_product.Description == productCmbSelected)
                                     select new
                                     {
                                         IdProduct = t_product.Id,
                                         IdCategory = t_product.IdCategory,
                                         Product = t_product.Description,
                                         Price_Unit = t_product.PriceUnit,
                                         QuantityAvailble = t_product.QtyAvailable,
                                         Supplier = t_supplier.Name,
                                         ShippingMinDay =t_product.ShippingMinDay
                                     }).Distinct();


                    dataGridViewProduct.DataSource = qProducts.ToList();

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //LIST OF PRICE AND CONDITIONS
        private void ShowAllPriceCondition()
        {
            getProductQtyDesidered();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                               
                DbContext dcPriceList = new DbContext();
                var priceListConditions = (
                                  from t_priceList in dcPriceList.PriceLists
                                  join t_product  in dcPriceList.Products on t_priceList.IdProduct equals t_product.Id
                                  join t_supplier in dcPriceList.Suppliers on t_product.IdSupplier equals t_supplier.Id
                                 where (DateTime.Now > t_priceList.StartDate && DateTime.Now < t_priceList.EndDate)
                                 && (t_priceList.Discontinued == 0) &&(t_product.QtyAvailable >= + productQtyDesidered) && (t_product.Description == productCmbSelected)
                                  select new
                                 {
                                     Product_Id = t_priceList.IdProduct,
                                     Supplier = t_supplier.Name,
                                     Description = t_product.Description,
                                     Qty_Available = t_product.QtyAvailable,
                                     Ship_Day_Min =t_product.ShippingMinDay,
                                     Unit_Price = t_product.PriceUnit,
                                     Discount_Perc = t_priceList.Discount + "%",
                                     From_Date = t_priceList.StartDate,
                                     To_Date = t_priceList.EndDate,
                                     Type = t_priceList.IdDiscountType,
                                     Limit_Min = t_priceList.LowLimit,
                                     Limit_Max = t_priceList.HighLimit,
                                     Limit_Value = t_priceList.ValueLimit
                                     
                                 });


                dataGridViewBottom.DataSource = null;
                dataGridViewBottom.Refresh();
                dataGridViewBottom.DataSource = priceListConditions.ToList();

                
                
            }

        }

        private static DataTable RetriveDataQry(DataTable dataTbl, string connectionString, string queryString)
        {

            

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter sqlAdapter = new SqlDataAdapter();
                sqlAdapter.SelectCommand = new SqlCommand(queryString, connection);
                sqlAdapter.Fill(dataTbl);
                
                /*
                using (SqlCommand command = new SqlCommand("Select Name, City, Street from Supplier", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var rec = new List<string>();
                            for (int i = 0; i <= reader.FieldCount - 1; i++)
                            {
                                rec.Add(reader.GetString(i));
                            }
                            string combined = string.Join("|", rec);
                            ResultSet.Add(combined);
                        }
                    }
                }
                */
                connection.Close();
                return dataTbl;
            }
        }

                

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }


                      

        private void txtOrderQty_KeyPress(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtOrderQty.Text, "  ^ [0-9]"))
            {
                txtOrderQty.Text = "1";
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {

            getProductQtyDesidered();
            ShowAllPriceCondition();
            

            //query retrive products available qty
            DbContext dcPriceListTypeNR = new DbContext();
            var priceTypeNR = (from t_priceList in dcPriceListTypeNR.PriceLists
                                       join t_product in dcPriceListTypeNR.Products on t_priceList.IdProduct equals t_product.Id into ps
                                       from t_product in ps.DefaultIfEmpty()
                                       where (DateTime.Now > t_priceList.StartDate && DateTime.Now < t_priceList.EndDate)
                                       && (t_priceList.Discontinued == 0) && (t_priceList.IdDiscountType=="NR") && (t_product.QtyAvailable >= productQtyDesidered && (t_product.Description == productCmbSelected)
                                       && (productQtyDesidered >= t_priceList.LowLimit) && (productQtyDesidered <= t_priceList.HighLimit))
                                       select t_priceList);
                                       
            
            var priceNRList = priceTypeNR.ToList();
            dataGridViewListCalculatedPrice.DataSource = priceNRList;
            
            List<PriceList> list_P_NR = priceTypeNR.ToList<PriceList>();

            
            DbContext dcPriceListDiscountTypeValue = new DbContext();
            var priceTypeValue = (from t_priceList in dcPriceListDiscountTypeValue.PriceLists
                           join t_product in dcPriceListDiscountTypeValue.Products on t_priceList.IdProduct equals t_product.Id into ps
                           from t_product in ps.DefaultIfEmpty()
                           where (DateTime.Now > t_priceList.StartDate && DateTime.Now < t_priceList.EndDate)
                           && (t_priceList.Discontinued == 0) && ((t_priceList.IdDiscountType == "VAL") || (t_priceList.IdDiscountType == "TIME")) && (t_product.QtyAvailable >= productQtyDesidered) && (t_product.Description == productCmbSelected)
                                  select t_priceList
                         
                            );

            dataGridViewVAL.DataSource = null;
            dataGridViewVAL.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewVAL.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewVAL.Refresh();
            var priceVALList = priceTypeValue.ToList();
            dataGridViewVAL.DataSource = priceVALList;
            

            List<PriceList> list_P_VAL_TIME = priceTypeValue.ToList<PriceList>();



            // List<PurchaseOrderOrderItem> list_Calculate = new List<PurchaseOrderOrderItem>();



            // LIST OF PRODUCTS FILTERED
            DbContext dcProductContext= new DbContext();
            var productSelected = (from product in dcProductContext.Products
                             where product.QtyAvailable > productQtyDesidered && product.Description==productCmbSelected
                                   select product
                             );


            dataGridViewProduct.DataSource = null;
            dataGridViewProduct.AutoGenerateColumns = false;



            dataGridViewProduct.Columns.Clear();
            dataGridViewProduct.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Id",
                DataPropertyName = "Id",
                HeaderText = "Product_ID"
            });
            dataGridViewProduct.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Description",
                DataPropertyName = "Description",
                HeaderText = "Description"
            });
            dataGridViewProduct.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "PriceUnit",
                DataPropertyName = "PriceUnit",
                HeaderText = "Unit Price"
            });
            dataGridViewProduct.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "IdSupplier",
                DataPropertyName = "IdSupplier",
                HeaderText = "Supplier Code"
            });
            dataGridViewProduct.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "ShippingMinDay",
                DataPropertyName = "ShippingMinDay",
                HeaderText = "Shipping Min Days"
            });


            var productSelectedList = productSelected.ToList();
                     

            List<Product> list_P_Selected = productSelected.ToList<Product>();

            //List<PurchaseOrderOrderItem> list_Calculate = new List<PurchaseOrderOrderItem>();

            

            //Calculate Price + Conditions
            foreach (Product p in list_P_Selected)
            {
                p.PriceUnit *= productQtyDesidered;
                //Retrive valid PriceList for quanty desider
                foreach (PriceList d in list_P_NR.Where(x => x.IdProduct == p.Id)
                                                 .Where(y => y.IdDiscountType == "NR")
                                                 .Where(z => z.LowLimit<= productQtyDesidered)
                                                 .Where(w => w.HighLimit >= productQtyDesidered).ToList())
                {
                      p.PriceUnit = p.PriceUnit - (p.PriceUnit * (d.Discount / 100));

                }

                // Apply active Discount for a valid Limit achived
                foreach (PriceList d in list_P_VAL_TIME.Where(x =>  x.IdProduct == p.Id).Where(y => y.IdDiscountType == "VAL").ToList())
                // var  Price = qtyProd * p.Price * (1 - p.Discount / 100);
                {
                    if (p.PriceUnit >= d.ValueLimit)
                    {
                        p.PriceUnit = p.PriceUnit - (p.PriceUnit * (d.Discount / 100));
                    } 

                }

                // Apply active Discount-Time offer
                foreach (PriceList d in list_P_VAL_TIME.Where(x => x.IdProduct == p.Id).Where(y => y.IdDiscountType == "TIME").ToList())
                { 
                    p.PriceUnit = p.PriceUnit - (p.PriceUnit * (d.Discount / 100));
                }

            }
            dataGridViewProduct.DataSource = null;
            dataGridViewProduct.DataSource = productSelectedList.OrderBy(s => s.PriceUnit).ToList();


        }

        private void getProductQtyDesidered()
        {
            productCmbSelected = cmbFilter.Text.ToString();
            if (string.IsNullOrEmpty(this.txtOrderQty.Text))
            {
                productQtyDesidered = 1;
                txtOrderQty.Text = "1";

            }
            else
            {

                try
                {
                    productQtyDesidered = Convert.ToInt16(txtOrderQty.Text);
                    if (productQtyDesidered == 0)
                    {
                        productQtyDesidered = 1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            
        }

    

        private void cmbFilter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getProductQtyDesidered();
            //DisplayDefault();
            CalculatePurchasePrice.Enabled = true;
        }
    }
}