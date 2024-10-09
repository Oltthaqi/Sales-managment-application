using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arka
{
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
            fillColumnName();
            LoadProducts();
        }

        public void fillColumnName()
        {

            DGVProducts.Columns.Add("ID", "ID");
            DGVProducts.Columns.Add("barcode", "barcode");
            DGVProducts.Columns.Add("name", "name");
            DGVProducts.Columns.Add("price", "price");
            DGVProducts.Columns.Add("quantity", "quantity");

            DGVProducts.Columns[0].Name = "ID";
            DGVProducts.Columns[1].Name = "barcode";
            DGVProducts.Columns[2].Name = "name";
            DGVProducts.Columns[3].Name = "price";
            DGVProducts.Columns[4].Name = "quantity";

            DGVProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void LoadProducts()
        {
            string selectQuery = "  SELECT ID, barcode, name, price, quantity FROM products";

            try
            {
                using (SqlConnection con = new SqlConnection(Properties.setting.Default.connection))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(selectQuery, con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (!reader.HasRows)
                            {
                                MessageBox.Show("No products found.");
                            }
                            else
                            {
                                DGVProducts.Rows.Clear();

                                while (reader.Read())
                                {

                                    string id = reader["ID"].ToString();
                                    string barcode = reader["barcode"].ToString();
                                    string name = reader["name"].ToString();
                                    string price = reader["price"].ToString();
                                    string quantity = reader["quantity"].ToString();


                                    int rowIndex = DGVProducts.Rows.Add();
                                    DGVProducts.Rows[rowIndex].Cells["ID"].Value = id;
                                    DGVProducts.Rows[rowIndex].Cells["barcode"].Value = barcode;
                                    DGVProducts.Rows[rowIndex].Cells["name"].Value = name;
                                    DGVProducts.Rows[rowIndex].Cells["price"].Value = price;
                                    DGVProducts.Rows[rowIndex].Cells["quantity"].Value = quantity;
                                    rowIndex++;
                                }
                            }
                        }
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string selectQuery = "  SELECT ID, barcode, name, price, quantity FROM products where name like @name";

            try
            {
                using (SqlConnection con = new SqlConnection(Properties.setting.Default.connection))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(selectQuery, con))
                    {
                        cmd.Parameters.Add(new SqlParameter("@name", "%" + txtBoxName.Text + "%"));
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (!reader.HasRows)
                            {
                                MessageBox.Show("No products found.");
                            }
                            else
                            {
                                DGVProducts.Rows.Clear();

                                while (reader.Read())
                                {

                                    string id = reader["ID"].ToString();
                                    string barcode = reader["barcode"].ToString();
                                    string name = reader["name"].ToString();
                                    string price = reader["price"].ToString();
                                    string quantity = reader["quantity"].ToString();


                                    int rowIndex = DGVProducts.Rows.Add();
                                    DGVProducts.Rows[rowIndex].Cells["ID"].Value = id;
                                    DGVProducts.Rows[rowIndex].Cells["barcode"].Value = barcode;
                                    DGVProducts.Rows[rowIndex].Cells["name"].Value = name;
                                    DGVProducts.Rows[rowIndex].Cells["price"].Value = price;
                                    DGVProducts.Rows[rowIndex].Cells["quantity"].Value = quantity;
                                    rowIndex++;
                                }
                            }
                        }
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DGVProducts.SelectedRows.Count > 0)
            {
                int _Id = Convert.ToInt32(DGVProducts.SelectedRows[0].Cells["ID"].Value);
                string deleteProductQuery = "DELETE FROM products where id = @id";

                try
                {
                    using (SqlConnection con = new SqlConnection(Properties.setting.Default.connection))
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand(deleteProductQuery, con))
                        {
                            cmd.Parameters.AddWithValue("@id" , _Id);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                LoadProducts();
                                MessageBox.Show("Produkti eshte fshir!");
                            }
                        }
                    }
                }
                catch (Exception ex) 
                { 
                MessageBox.Show("Error:" + ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Please select a row.");
            }
        }
    }
}
