using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arka
{
    public partial class EditProductsForm : Form
    {

        int productId;
        string barcode;
        string cmimi;
        string sasia;
        string produkti;
        int counterForName;
        int _id = 1;
        int rowCounter = 0;
        public EditProductsForm()
        {
            InitializeComponent();
            DGVProducts.ReadOnly = true;
            fillColumnName();
            this.KeyPreview = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void fillColumnName()
        {

            DGVProducts.Columns.Add("ID", "ID");
            DGVProducts.Columns.Add("ProduktId", "ProduktId");
            DGVProducts.Columns.Add("Barkodi", "Barkodi");
            DGVProducts.Columns.Add("Produkti", "Produkti");
            DGVProducts.Columns.Add("Cmimi", "Cmimi");
            DGVProducts.Columns.Add("sasia", "sasia");

            DGVProducts.Columns[0].Name = "ID";
            DGVProducts.Columns[1].Name = "ProduktId";
            DGVProducts.Columns[2].Name = "Barkodi";
            DGVProducts.Columns[3].Name = "Produkti";
            DGVProducts.Columns[4].Name = "Cmimi";
            DGVProducts.Columns[5].Name = "sasia";
            DGVProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void searchedProds()
        {
            string querycount = @"SELECT COUNT(*) FROM [products] WHERE name like @name";
            try
            {
                using (SqlConnection con = new SqlConnection(Properties.setting.Default.connection))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(querycount, con))
                    {
                        cmd.Parameters.AddWithValue("@name", "%" + txtBoxName.Text + "%");
                        var result = cmd.ExecuteScalar();
                        counterForName = (int)result;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }
        public void zgjedhProduktinByName()
        {
            string searchText = "%" + txtBoxName.Text + "%";
            string getProductQuery = "SELECT id, barcode, name, price , quantity FROM products WHERE name LIKE @name";

            try
            {
                using (SqlConnection con = new SqlConnection(Properties.setting.Default.connection))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(getProductQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@name", searchText);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (!reader.HasRows)
                            {
                                MessageBox.Show("Product not found");
                            }
                            else
                            {
                                while (reader.Read())
                                {
                                    string prodId = reader["id"].ToString();
                                    string prodBarcode = reader["barcode"].ToString();
                                    string prodName = reader["name"].ToString();
                                    string prodPrice = reader["price"].ToString();
                                    string prodQuantity = reader["quantity"].ToString();

                                    DGVProducts.Rows.Add();
                                    DGVProducts.Rows[rowCounter].Cells["ID"].Value = _id;
                                    DGVProducts.Rows[rowCounter].Cells["Cmimi"].Value = prodPrice;
                                    DGVProducts.Rows[rowCounter].Cells["produktId"].Value = prodId;
                                    DGVProducts.Rows[rowCounter].Cells["Barkodi"].Value = prodBarcode;
                                    DGVProducts.Rows[rowCounter].Cells["produkti"].Value = prodName;
                                    DGVProducts.Rows[rowCounter].Cells["sasia"].Value = prodQuantity;
                                    rowCounter++;
                                    _id++;
                                }
                            }
                        }
                    }

                    con.Close();
                }


                //txtBoxName.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void txtBoxBarcode_TextChanged(object sender, EventArgs e)
        {

            if (txtBoxBarcode.Text.Length == 13)
            {
                string prodId = "";
                string prodBarcode = "";
                string prodName = "";
                string prodPrice = "";
                string prodQuantity = "";

                string getProductBarcodeQuery = "SELECT barcode from products where barcode = @barcode";
                string getProductNameQuery = "SELECT name FROM products where barcode = @barcode";
                string getProductPriceQuery = "SELECT price FROM products where barcode = @barcode";
                string getProductId = "SELECT id FROM products where barcode = @barcode";
                string getProductQuantityQuery = @"SELECT quantity FROM products where barcode = @barcode";
                try
                {


                    using (SqlConnection con = new SqlConnection(Properties.setting.Default.connection))
                    {

                        con.Open();

                        using (SqlCommand cmd = new SqlCommand(getProductNameQuery, con))
                        {
                            cmd.Parameters.AddWithValue("@barcode", txtBoxBarcode.Text);
                            var result = cmd.ExecuteScalar();
                            if (result == null)
                            {
                                MessageBox.Show("Product not found");
                            }
                            else
                            {

                                prodName = result.ToString();

                            }
                        }

                        if (prodName != "")
                        {
                            using (SqlCommand cmd = new SqlCommand(getProductId, con))
                            {
                                cmd.Parameters.AddWithValue("@barcode", txtBoxBarcode.Text);
                                var result = cmd.ExecuteScalar();
                                if (result == null)
                                {
                                    MessageBox.Show("Product not found");

                                }
                                else
                                {
                                    prodId = result.ToString();
                                }
                            }

                            using (SqlCommand cmd = new SqlCommand(getProductBarcodeQuery, con))
                            {
                                cmd.Parameters.AddWithValue("@barcode", txtBoxBarcode.Text);
                                var result = cmd.ExecuteScalar();
                                if (result == null)
                                {
                                    MessageBox.Show("Product not found");
                                }
                                else
                                {
                                    prodBarcode = result.ToString();


                                }
                            }

                            using (SqlCommand cmd = new SqlCommand(getProductPriceQuery, con))
                            {
                                cmd.Parameters.AddWithValue("@barcode", txtBoxBarcode.Text);
                                var result = cmd.ExecuteScalar();
                                if (result == null)
                                {
                                    MessageBox.Show("Product not found");
                                }
                                else
                                {
                                    prodPrice = result.ToString();
                                }
                            }
                            using (SqlCommand cmd = new SqlCommand(getProductQuantityQuery, con))
                            {
                                cmd.Parameters.AddWithValue("@barcode", txtBoxBarcode.Text);
                                var result = cmd.ExecuteScalar();
                                if (result == null)
                                {
                                    MessageBox.Show("Product not found");
                                }
                                else
                                {
                                    prodQuantity = result.ToString();
                                }
                            }
                        }

                        if (prodId != null && prodBarcode != null && prodName != null && prodPrice != null && prodQuantity != null)
                        {
                            DGVProducts.Rows.Add();
                            DGVProducts.Rows[0].Cells["ID"].Value = 1;
                            DGVProducts.Rows[0].Cells["Cmimi"].Value = prodPrice;
                            DGVProducts.Rows[0].Cells["produktId"].Value = prodId;
                            DGVProducts.Rows[0].Cells["Barkodi"].Value = prodBarcode;
                            DGVProducts.Rows[0].Cells["produkti"].Value = prodName;
                            DGVProducts.Rows[0].Cells["sasia"].Value = prodQuantity;
                            int quantity = Convert.ToInt32(DGVProducts.Rows[0].Cells["sasia"].Value);

                            txtBoxBarcode.Text = "";

                        }
                        else
                        {
                            MessageBox.Show("Product not found!");
                            txtBoxBarcode.Text = "";
                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }
            }
        }

        public void getProdId()
        {
            DialogResult dialogResult = MessageBox.Show(
            "Doni ta Ndryshoni Produktin ?",
            "Title",
            MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int rowIndex = DGVProducts.SelectedRows[0].Index;
                productId = Convert.ToInt32(DGVProducts.Rows[rowIndex].Cells["produktId"].Value);
                barcode = DGVProducts.Rows[rowIndex].Cells["Barkodi"].Value.ToString();
                cmimi = DGVProducts.Rows[rowIndex].Cells["Cmimi"].Value.ToString();
                sasia = DGVProducts.Rows[rowIndex].Cells["sasia"].Value.ToString();
                produkti = DGVProducts.Rows[rowIndex].Cells["Produkti"].Value.ToString();
                DGVProducts.Rows.Clear();
                _id = 1;
                rowCounter = 0;

                EditProducts2Form editProducts2Form = new EditProducts2Form(productId, barcode, cmimi, sasia, produkti);
                editProducts2Form.ShowDialog();
            }
        }



        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            if (DGVProducts.SelectedRows.Count > 0 && DGVProducts.SelectedRows[0].Cells["id"].Value?.ToString() != null)
            {
                getProdId();
            }
            else
            {
                MessageBox.Show("Error: Selektoni nje rresht!");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _id = 1;
            rowCounter = 0;
            DGVProducts.Rows.Clear();
            searchedProds();
            zgjedhProduktinByName();
        }

        private void EditProductsForm_KeyDown(object sender, KeyEventArgs e)
        {
             if (e.KeyCode == Keys.Escape)
            {
                pictureBox2_Click(pictureBox2 , EventArgs.Empty);
            }
        }
    }
}
