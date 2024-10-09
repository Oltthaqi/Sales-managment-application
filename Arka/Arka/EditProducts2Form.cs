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
    public partial class EditProducts2Form : Form
    {
        int id;
        string barcode;
        string price;
        string sasia;
        string produkti;
        public EditProducts2Form(int productId, string bar, string cmimi, string quantity, string prodName)
        {
            InitializeComponent();
            id = productId;
            txtBoxBarcode.Text = bar;
            txtBoxPrice.Text = cmimi;
            txtBoxQuantity.Text = quantity;
            txtBoxName.Text = prodName;
        }
        public void updateDb()
        {
            string updateQuery = "UPDATE products SET name = @name, barcode = @barcode, price = @price , quantity = @quantity WHERE id = @id";

            try
            {
                using (SqlConnection con = new SqlConnection(Properties.setting.Default.connection))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@name", txtBoxName.Text);
                        cmd.Parameters.AddWithValue("@barcode", txtBoxBarcode.Text);
                        cmd.Parameters.AddWithValue("@price", txtBoxPrice.Text);
                        cmd.Parameters.AddWithValue("@quantity", txtBoxQuantity.Text);
                        cmd.Parameters.AddWithValue("@id", id);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Success Product updated!");
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erorr:" + ex.Message);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            updateDb();
        }
    }
}
