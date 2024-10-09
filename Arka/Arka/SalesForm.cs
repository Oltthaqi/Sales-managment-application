using DocumentFormat.OpenXml.Spreadsheet;
using IronXL;
using System.Data.SqlClient;



namespace Arka
{
    public partial class SalesForm : Form
    {
        public int rowProducts = 0;
        public int _id = 1;
        public List<Tuple<int, int>> productids = new List<Tuple<int, int>>();
        public double Total;
        public int saleCounter = 1;
        int addedQuantity = 0;

        int rowCounter = Properties.setting.Default.rowCounter;



        public SalesForm()
        {
            InitializeComponent();
            fillColumnName();

            DateTime dateTime = DateTime.Now;
            string formateddate = dateTime.ToString("MM-dd-yyyy");
            label1.Text = "DATA: " + formateddate;
            lblVersion.Text = "Version: Beta";
            string ditaJaves = "";
            switch (dateTime.DayOfWeek.ToString())
            {
                case "Monday":
                    ditaJaves = "E Hene";
                    break;
                case "Tuesday":
                    ditaJaves = "E Marte";
                    break;
                case "Wednesday":
                    ditaJaves = "E Merkure";
                    break;
                case "Thursday":
                    ditaJaves = "E Enjte";
                    break;
                case "Friday":
                    ditaJaves = "E Premte";
                    break;
                case "Saturday":
                    ditaJaves = "E Shtune";
                    break;
                case "Sunday":
                    ditaJaves = "E Diele";
                    break;
                default:
                    ditaJaves = "Ditë e panjohur";
                    break;
            }

            lblDitaEJaves.Text ="Dita: " + ditaJaves;
              
            Properties.setting.Default.date = dateTime.Day;
            
            DGVProducts.ReadOnly = true;

            if (Properties.setting.Default.date >= Properties.setting.Default.nextDay)
            {
                saleCounter = 1;
                WorkBook workbook  = WorkBook.Create(ExcelFileFormat.XLSX);
                Properties.setting.Default.rowCounter = 2;
                rowCounter = Properties.setting.Default.rowCounter;

                WorkSheet sheet  = workbook.CreateWorkSheet("Shitjet");
                WorkSheet sheet1 = workbook.CreateWorkSheet("Rreshtat");


                sheet["A1"].Value = "num";
                sheet["B1"].Value = "shitja";
                sheet["C1"].Value = "Ora";
                sheet["D1"].Value = "total";


                sheet1["A1"].Value = "num";
                sheet1["B1"].Value = "shitja";
                sheet1["C1"].Value = "Ora";
                sheet1["D1"].Value = "Artikulli";
                sheet1["E1"].Value = "Cmimi";
                sheet1["F1"].Value = "sasia";

                sheet["A1"].Style.Font.Bold = true;
                sheet["B1"].Style.Font.Bold = true;
                sheet["C1"].Style.Font.Bold = true;
                sheet["D1"].Style.Font.Bold = true;

                sheet1["A1"].Style.Font.Bold = true;
                sheet1["B1"].Style.Font.Bold = true;
                sheet1["C1"].Style.Font.Bold = true;
                sheet1["D1"].Style.Font.Bold = true;
                sheet1["E1"].Style.Font.Bold = true;
                sheet1["F1"].Style.Font.Bold = true;


                sheet["A1"].Style.Font.Height = 14;
                sheet["B1"].Style.Font.Height = 14;
                sheet["C1"].Style.Font.Height = 14;
                sheet["D1"].Style.Font.Height = 14;

                sheet1["A1"].Style.Font.Height = 14;
                sheet1["B1"].Style.Font.Height = 14;
                sheet1["C1"].Style.Font.Height = 14;
                sheet1["D1"].Style.Font.Height = 14;
                sheet1["E1"].Style.Font.Height = 14;
                sheet1["F1"].Style.Font.Height = 14;


                workbook.SaveAs($"C:\\Users\\Admin\\Desktop\\excelsheet\\Raporti-{formateddate}.xlsx");
            }
            else
            {
                saleCounter = Properties.setting.Default.saleCount;
            }
            Properties.setting.Default.nextDay = dateTime.Day + 1;
            Properties.setting.Default.Save();
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


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxBarcodeScanner.Text.Length == 13)
            {
                string prodId = "";
                string prodBarcode = "";
                string prodName = "";
                string prodPrice = "";

                string getProductBarcodeQuery = "SELECT barcode from products where barcode = @barcode";
                string getProductNameQuery = "SELECT name FROM products where barcode = @barcode";
                string getProductPriceQuery = "SELECT price FROM products where barcode = @barcode";
                string getProductId = "SELECT id FROM products where barcode = @barcode";
                try
                {


                    using (SqlConnection con = new SqlConnection(Properties.setting.Default.connection))
                    {

                        con.Open();


                        using (SqlCommand cmd = new SqlCommand(getProductId, con))
                        {
                            cmd.Parameters.AddWithValue("@barcode", txtBoxBarcodeScanner.Text);
                            var result = cmd.ExecuteScalar();
                            if (result == null)
                            {
                                MessageBox.Show("Product not found");
                                txtBoxBarcodeScanner.Text = "";
                                return;
                            }
                            else
                            {
                                prodId = result.ToString();
                            }
                        }

                        using (SqlCommand cmd = new SqlCommand(getProductBarcodeQuery, con))
                        {
                            cmd.Parameters.AddWithValue("@barcode", txtBoxBarcodeScanner.Text);
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
                        using (SqlCommand cmd = new SqlCommand(getProductNameQuery, con))
                        {
                            cmd.Parameters.AddWithValue("@barcode", txtBoxBarcodeScanner.Text);
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
                        using (SqlCommand cmd = new SqlCommand(getProductPriceQuery, con))
                        {
                            cmd.Parameters.AddWithValue("@barcode", txtBoxBarcodeScanner.Text);
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
                    }
                    var row = CheckBarcode();
                    if (row == null)
                    {
                        if (prodId != null && prodBarcode != null && prodName != null && prodPrice != null)
                        {
                            DGVProducts.Rows.Add();
                            DGVProducts.Rows[rowProducts].Cells["ID"].Value = _id;
                            DGVProducts.Rows[rowProducts].Cells["Cmimi"].Value = prodPrice;
                            DGVProducts.Rows[rowProducts].Cells["produktId"].Value = prodId;
                            DGVProducts.Rows[rowProducts].Cells["Barkodi"].Value = prodBarcode;
                            DGVProducts.Rows[rowProducts].Cells["produkti"].Value = prodName;
                            DGVProducts.Rows[rowProducts].Cells["sasia"].Value = 1;
                            int quantity = Convert.ToInt32(DGVProducts.Rows[rowProducts].Cells["sasia"].Value);
                            productids.Add(System.Tuple.Create(Convert.ToInt32(prodId), quantity));
                            rowProducts++;
                            _id++;
                            txtBoxBarcodeScanner.Text = "";
                            generateSum();
                        }
                        else
                        {
                            MessageBox.Show("Product not found!");
                            txtBoxBarcodeScanner.Text = "";
                        }
                    }
                    else
                    {
                        row.Cells["sasia"].Value = Convert.ToInt32(row.Cells["sasia"].Value) + 1;
                        txtBoxBarcodeScanner.Text = "";
                        int quantity = Convert.ToInt32(row.Cells["sasia"].Value);
                        for (int i = 0; i < productids.Count; i++)
                        {
                            if (productids[i].Item1 == Convert.ToInt32(prodId))
                            {

                                int currentQuantity = productids[i].Item2;
                                int newQuantity = quantity;

                                productids[i] = System.Tuple.Create(Convert.ToInt32(prodId), newQuantity);
                                break;
                            }
                        }
                        generateSum();
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }
            }
        }
        public DataGridViewRow CheckBarcode()
        {
            string barcode = txtBoxBarcodeScanner.Text;
            foreach (DataGridViewRow row in DGVProducts.Rows)
            {
                if (!row.IsNewRow)
                {

                    string existingBarcode = row.Cells["Barkodi"].Value?.ToString();


                    if (existingBarcode == barcode)
                    {
                        return row;

                    }
                }

            }

            return null;
        }

        public void generateSum()
        {
            double totalPrice = 0.00;
            try
            {
                using (SqlConnection con = new SqlConnection(Properties.setting.Default.connection))
                {
                    con.Open();
                    string queryPrice = "SELECT price from products where id = @id";

                    using (SqlCommand cmd = new SqlCommand(queryPrice, con))
                    {
                        for (int i = 0; i < rowProducts; i++)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@id", productids[i].Item1);
                            var result = cmd.ExecuteScalar();
                            totalPrice += Math.Round(Convert.ToDouble((decimal)result) * productids[i].Item2, 2);

                        }
                    }
                }
                labelTotal.Text = totalPrice.ToString("F2") + "€";
                Total = totalPrice;
            }
            catch (Exception ex)
            {

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShtypShitjen_Click(object sender, EventArgs e)
        {
            PerfundoShitjenForm perfundoShitjenForm = new PerfundoShitjenForm(Total);
            DialogResult result = perfundoShitjenForm.ShowDialog(); 

            if (result == DialogResult.OK)
            {
                DialogResult dialogResult = MessageBox.Show(
                    "Doni ta perfundoni shitjen?",
                    "Title",
                    MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    if (rowProducts > 0)
                    {
                        string InsertOrderHeaderQuery = @"INSERT INTO salesHeader (saleId, dateCreated, total) 
                                                 VALUES (@saleId, @dateCreated, @total)";
                        string InsertSaleLineQuery = @"INSERT INTO saleLine (saleId, dateCreated, productName, productPrice, quantity) 
                                             VALUES (@saleId, @dateCreated, @productName, @productPrice, @quantity)";
                        int rowsAffected = 0;

                        DateTime dateTime = DateTime.Now;
                        string saleId = "PO-" + dateTime.Day + "-" + saleCounter;
                        string formateddate = dateTime.ToString("MM-dd-yyyy");

                        try
                        {
                            WorkBook workBook = WorkBook.Load($"C:\\Users\\Admin\\Desktop\\excelsheet\\Raporti-{formateddate}.xlsx");
                            WorkSheet sheet = workBook.GetWorkSheet("Shitjet");
                            WorkSheet sheet1 = workBook.GetWorkSheet("Rreshtat");
                            string time = dateTime.ToString("HH:mm");
                            using (SqlConnection con = new SqlConnection(Properties.setting.Default.connection))
                            {
                                con.Open();
                                using (SqlCommand cmd = new SqlCommand(InsertOrderHeaderQuery, con))
                                {
                                    cmd.Parameters.AddWithValue("@saleId", saleId);
                                    cmd.Parameters.AddWithValue("@dateCreated", dateTime.Date);
                                    cmd.Parameters.AddWithValue("@total", Total);

                                   

                                    sheet["A" + rowCounter].Value = (rowCounter - 1).ToString(); 
                                    sheet["B" + rowCounter].Value = saleId;
                                    sheet["C" + rowCounter].Value = time;
                                    sheet["D" + rowCounter].Value = Total + "€";
                                    cmd.ExecuteScalar();
                                }

                                foreach (var product in productids)
                                {
                                    string productName;
                                    decimal productPrice;
                                    string productNameQuery = @"SELECT name FROM products WHERE id = @id";
                                    string productPriceQuery = @"SELECT price FROM products WHERE id = @id";

                                    using (SqlCommand cmd = new SqlCommand(productNameQuery, con))
                                    {
                                        cmd.Parameters.AddWithValue("@id", product.Item1);
                                        productName = (string)cmd.ExecuteScalar();
                                    }

                                    using (SqlCommand cmd = new SqlCommand(productPriceQuery, con))
                                    {
                                        cmd.Parameters.AddWithValue("@id", product.Item1);
                                        productPrice = (decimal)cmd.ExecuteScalar();
                                    }

                                    using (SqlCommand cmd = new SqlCommand(InsertSaleLineQuery, con))
                                    {
                                        cmd.Parameters.AddWithValue("@saleId", saleId);
                                        cmd.Parameters.AddWithValue("@dateCreated", dateTime);
                                        cmd.Parameters.AddWithValue("@productName", productName);
                                        cmd.Parameters.AddWithValue("@productPrice", productPrice);
                                        cmd.Parameters.AddWithValue("@quantity", product.Item2);

                                        sheet1["A" + rowCounter].Value = (rowCounter-1).ToString();
                                        sheet1["B" + rowCounter].Value = saleId;
                                        sheet1["C" + rowCounter].Value = time;
                                        sheet1["D" + rowCounter].Value = productName;
                                        sheet1["E" + rowCounter].Value = productPrice + "€";
                                        sheet1["F" + rowCounter].Value = product.Item2;
                                        rowCounter++;
                                        Properties.setting.Default.rowCounter++;
                                        workBook.SaveAs($"C:\\Users\\Admin\\Desktop\\excelsheet\\Raporti-{formateddate}.xlsx");

                                        rowsAffected = cmd.ExecuteNonQuery();
                                    }

                                    if (rowsAffected > 0)
                                    {
                                        int _quantity;
                                        string updateStockQuery = "UPDATE products SET quantity = @newQuantity WHERE id = @id";
                                        string productQuantityQuery = "SELECT quantity FROM products WHERE id = @id";

                                        using (SqlCommand cmd = new SqlCommand(productQuantityQuery, con))
                                        {
                                            cmd.Parameters.AddWithValue("@id", product.Item1);
                                            _quantity = (int)cmd.ExecuteScalar();
                                        }

                                        int quant = _quantity - product.Item2;
                                        using (SqlCommand cmd = new SqlCommand(updateStockQuery, con))
                                        {
                                            cmd.Parameters.AddWithValue("@id", product.Item1);
                                            cmd.Parameters.AddWithValue("@newQuantity", quant);
                                             var res = cmd.ExecuteNonQuery();
                                        }
                                    }
                                }

                                if (rowsAffected > 0)
                                {
                                    rowsAffected = 0;
                                    productids.Clear();
                                    saleCounter++;
                                    Properties.setting.Default.saleCount = saleCounter;
                                    Properties.setting.Default.Save();
                                    _id = 1;
                                    DGVProducts.Rows.Clear();
                                    Total = 0;
                                    rowProducts = 0;
                                    labelTotal.Text = "0.00€";
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
                        MessageBox.Show("Error: No products scanned");
                    }
                }
            }
        }


        public void deleteRow()
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show(
                "Doni ta fshini rreshtin ?",
                "Title",
                MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int rowIndex = DGVProducts.SelectedRows[0].Index;

                    DGVProducts.Rows.RemoveAt(rowIndex);
                    rowProducts--;
                    _id--;
                    productids.RemoveAt(rowIndex);
                    generateSum();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        public void updateQuantity(int quant)
        {
            try
            {
                if (DGVProducts.SelectedRows.Count > 0)
                {
                    int rowIndex = DGVProducts.SelectedRows[0].Index;

                    int productId = Convert.ToInt32(DGVProducts.Rows[rowIndex].Cells["ProduktId"].Value);
                    int currentQuantity = Convert.ToInt32(DGVProducts.Rows[rowIndex].Cells["sasia"].Value);

                    int newQuantity = currentQuantity + quant;
                    DGVProducts.Rows[rowIndex].Cells["sasia"].Value = newQuantity;

                    for (int i = 0; i < productids.Count; i++)
                    {
                        if (productids[i].Item1 == productId)
                        {

                            productids[i] = System.Tuple.Create(productId, newQuantity);
                            break;
                        }
                    }

                    generateSum();
                }
                else
                {
                    MessageBox.Show("Please select a row to update the quantity.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating quantity: " + ex.Message);
            }
        }


        private void SalesForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                btnShtypShitjen.PerformClick();

            }
            else if (e.KeyCode == Keys.Delete)
            {
                deleteRow();
            }
            else if (e.KeyCode == Keys.F3)
            {
                btnAddProducts.PerformClick();
            }
            else if (e.KeyCode == Keys.F4)
            {
                btnEditProducts.PerformClick();
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnSales.PerformClick();
            }
            else if (e.KeyCode == Keys.F9)
            {
                btnAddQuantity.PerformClick();
            }
            else if (e.KeyCode == Keys.F6)
            {
               btnProductsForm.PerformClick();
            }
        }

        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            AddProductsForm addProductsForm = new AddProductsForm();
            addProductsForm.ShowDialog();
        }

        private void btnEditProducts_Click(object sender, EventArgs e)
        {
            EditProductsForm editProductsForm = new EditProductsForm();
            editProductsForm.ShowDialog();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            ShitjetForm shitjetForm = new ShitjetForm();
            shitjetForm.ShowDialog();
        }

        private void btnAddQuantity_Click(object sender, EventArgs e)
        {
            AddQuantityForm addQuantityForm = new AddQuantityForm();
            addQuantityForm.ShowDialog();
            int quantityAdded = addQuantityForm.QuantityAdded;
            if (quantityAdded > 0)
            {

                updateQuantity(quantityAdded);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteRow();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductsForm productsForm = new ProductsForm();
            productsForm.ShowDialog();
        }
    }
}
