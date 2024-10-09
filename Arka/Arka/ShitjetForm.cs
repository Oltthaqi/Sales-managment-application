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
    public partial class ShitjetForm : Form
    {
        public ShitjetForm()
        {
            InitializeComponent();
            fillColumnName();
            LoadSalesHeaders();
            DGVProducts.ReadOnly = true;
            this.KeyPreview = true;
        }
        public void fillColumnName()
        {

            DGVProducts.Columns.Add("ID", "ID");
            DGVProducts.Columns.Add("saleId", "saleId");
            DGVProducts.Columns.Add("dateCreated", "dateCreated");
            DGVProducts.Columns.Add("salesPerson", "salesPerson");
            DGVProducts.Columns.Add("total", "total");

            DGVProducts.Columns[0].Name = "ID";
            DGVProducts.Columns[1].Name = "saleId";
            DGVProducts.Columns[2].Name = "date";
            DGVProducts.Columns[3].Name = "salesPerson";
            DGVProducts.Columns[4].Name = "total";

            DGVProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void LoadSalesHeaders()
        {
            DateTime dateTime = DateTime.Today;

            string selectQuery = "  SELECT ID, saleId, dateCreated, salesPerson, total FROM salesHeader where CAST(dateCreated AS DATE) = @dateTime  ";

            try
            {
                using (SqlConnection con = new SqlConnection(Properties.setting.Default.connection))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(selectQuery, con))
                    {
                        cmd.Parameters.Add(new SqlParameter("@dateTime", SqlDbType.Date)).Value = dateTime.Date;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (!reader.HasRows)
                            {
                                MessageBox.Show("No sales headers found.");
                            }
                            else
                            {
                                DGVProducts.Rows.Clear();

                                while (reader.Read())
                                {

                                    string id = reader["ID"].ToString();
                                    string saleId = reader["saleId"].ToString();
                                    string dateCreated = Convert.ToDateTime(reader["dateCreated"]).ToString("dd/MM/yyyy");
                                    string salesPerson = reader["salesPerson"].ToString();
                                    string total = reader["total"].ToString();


                                    int rowIndex = DGVProducts.Rows.Add();
                                    DGVProducts.Rows[rowIndex].Cells["ID"].Value = id;
                                    DGVProducts.Rows[rowIndex].Cells["saleId"].Value = saleId;
                                    DGVProducts.Rows[rowIndex].Cells["date"].Value = dateCreated;
                                    DGVProducts.Rows[rowIndex].Cells["salesPerson"].Value = salesPerson;
                                    DGVProducts.Rows[rowIndex].Cells["total"].Value = total;
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtBoxSaleId.Text == "")
            {
                DateTime selectedDate = DTPSales.Value;
                string formattedDate = selectedDate.ToString("yyyy-MM-dd");

                string selectQuery = "  SELECT ID, saleId, dateCreated, salesPerson, total FROM salesHeader where CAST(dateCreated AS DATE) = @dateTime  ";

                try
                {
                    using (SqlConnection con = new SqlConnection(Properties.setting.Default.connection))
                    {
                        con.Open();

                        using (SqlCommand cmd = new SqlCommand(selectQuery, con))
                        {
                            cmd.Parameters.Add(new SqlParameter("@dateTime", SqlDbType.Date)).Value = formattedDate;
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (!reader.HasRows)
                                {
                                    MessageBox.Show("No sales headers found.");
                                }
                                else
                                {
                                    DGVProducts.Rows.Clear();

                                    while (reader.Read())
                                    {

                                        string id = reader["ID"].ToString();
                                        string saleId = reader["saleId"].ToString();
                                        string dateCreated = Convert.ToDateTime(reader["dateCreated"]).ToString("dd/MM/yyyy");
                                        string salesPerson = reader["salesPerson"].ToString();
                                        string total = reader["total"].ToString();


                                        int rowIndex = DGVProducts.Rows.Add();
                                        DGVProducts.Rows[rowIndex].Cells["ID"].Value = id;
                                        DGVProducts.Rows[rowIndex].Cells["saleId"].Value = saleId;
                                        DGVProducts.Rows[rowIndex].Cells["date"].Value = dateCreated;
                                        DGVProducts.Rows[rowIndex].Cells["salesPerson"].Value = salesPerson;
                                        DGVProducts.Rows[rowIndex].Cells["total"].Value = total;
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
            else if (txtBoxSaleId.Text != "")
            {
                string selectQuery = "  SELECT ID, saleId, dateCreated, salesPerson, total FROM salesHeader where saleId like @saleId  ";

                try
                {
                    using (SqlConnection con = new SqlConnection(Properties.setting.Default.connection))
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand(selectQuery, con))
                        {
                            cmd.Parameters.Add(new SqlParameter("@saleId", "%" + txtBoxSaleId.Text + "%"));
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (!reader.HasRows)
                                {
                                    MessageBox.Show("No sales headers found.");
                                }
                                else
                                {
                                    DGVProducts.Rows.Clear();

                                    while (reader.Read())
                                    {

                                        string id = reader["ID"].ToString();
                                        string saleId = reader["saleId"].ToString();
                                        string dateCreated = Convert.ToDateTime(reader["dateCreated"]).ToString("dd/MM/yyyy");
                                        string salesPerson = reader["salesPerson"].ToString();
                                        string total = reader["total"].ToString();


                                        int rowIndex = DGVProducts.Rows.Add();
                                        DGVProducts.Rows[rowIndex].Cells["ID"].Value = id;
                                        DGVProducts.Rows[rowIndex].Cells["saleId"].Value = saleId;
                                        DGVProducts.Rows[rowIndex].Cells["date"].Value = dateCreated;
                                        DGVProducts.Rows[rowIndex].Cells["salesPerson"].Value = salesPerson;
                                        DGVProducts.Rows[rowIndex].Cells["total"].Value = total;
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
        }

        private void ShitjetForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                pictureBox2_Click(pictureBox2 , EventArgs.Empty);
            }
        }
    }
}
