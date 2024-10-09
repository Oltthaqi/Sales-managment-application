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
    public partial class AddProductsForm : Form
    {
        public AddProductsForm()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            if (txtBoxBarcode.Text != "" || txtBoxName.Text != "" || txtBoxPrice.Text != "" || txtBoxQuantity.Text != "")
            {
                int exists = 0;
                string checkProductsExists = @"SELECT COUNT(*) FROM [products] WHERE barcode = @barcode";

                string insertQuery = @"
                INSERT INTO [MarketValbona].[dbo].[products] 
                ([barcode],[name],[price],[quantity]) 
                VALUES (@barcode, @name, @price, @quantity);";

                try
                {
                    using (SqlConnection conn = new SqlConnection(Properties.setting.Default.connection))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(checkProductsExists, conn))
                        {
                            cmd.Parameters.AddWithValue("@barcode", txtBoxBarcode.Text);
                            var result = cmd.ExecuteScalar();
                            exists =(int) result;
                        }
                        if (exists == 0)
                        {
                            using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@barcode", txtBoxBarcode.Text); 
                                cmd.Parameters.AddWithValue("@name", txtBoxName.Text); 
                                cmd.Parameters.AddWithValue("@price", txtBoxPrice.Text); 
                                cmd.Parameters.AddWithValue("@quantity", txtBoxQuantity.Text);
                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0) 
                                    {
                                    txtBoxBarcode.Text = "";
                                    txtBoxName.Text = "";
                                    txtBoxPrice.Text = "";
                                    txtBoxQuantity.Text = "";
                                    MessageBox.Show("Produkti u regjistrua!");
                                    }

                            }
                        }
                        else
                        {
                            txtBoxBarcode.Text = "";
                            txtBoxName.Text = "";
                            txtBoxPrice.Text = "";
                            txtBoxQuantity.Text = "";
                            MessageBox.Show("Produkti egziston!");
                        }
                    }
                }
                catch (Exception ex) { 
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Mbushi te gjitha te dhenat!");
            }
        }
    }
}
