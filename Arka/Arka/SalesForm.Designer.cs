namespace Arka
{
    partial class SalesForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            DGVProducts = new DataGridView();
            txtBoxBarcodeScanner = new TextBox();
            labelTotal = new Label();
            btnShtypShitjen = new Button();
            btnAddProducts = new Button();
            btnEditProducts = new Button();
            btnSales = new Button();
            btnAddQuantity = new Button();
            btnDelete = new Button();
            btnProductsForm = new Button();
            lblDitaEJaves = new Label();
            lblVersion = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVProducts).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(54, 69, 79);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-4, -4);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1942, 36);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(1892, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 31);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.WhiteSmoke;
            label1.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(21, 51);
            label1.Name = "label1";
            label1.Size = new Size(0, 28);
            label1.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(1374, 32);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(24, 1077);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Location = new Point(647, 2);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(338, 140);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel4.BackColor = Color.FromArgb(189, 189, 189);
            panel4.Location = new Point(-21, 220);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(1942, 27);
            panel4.TabIndex = 2;
            // 
            // DGVProducts
            // 
            DGVProducts.AllowUserToResizeColumns = false;
            DGVProducts.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(227, 242, 253);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            DGVProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DGVProducts.BackgroundColor = Color.FromArgb(236, 239, 241);
            DGVProducts.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(227, 242, 253);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DGVProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DGVProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(227, 242, 253);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DGVProducts.DefaultCellStyle = dataGridViewCellStyle3;
            DGVProducts.GridColor = Color.LightGray;
            DGVProducts.Location = new Point(12, 251);
            DGVProducts.Margin = new Padding(3, 2, 3, 2);
            DGVProducts.Name = "DGVProducts";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(227, 242, 253);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            DGVProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            DGVProducts.RowHeadersWidth = 51;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(227, 242, 253);
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            DGVProducts.RowsDefaultCellStyle = dataGridViewCellStyle5;
            DGVProducts.RowTemplate.Height = 29;
            DGVProducts.Size = new Size(1356, 650);
            DGVProducts.TabIndex = 3;
            // 
            // txtBoxBarcodeScanner
            // 
            txtBoxBarcodeScanner.BackColor = Color.White;
            txtBoxBarcodeScanner.BorderStyle = BorderStyle.FixedSingle;
            txtBoxBarcodeScanner.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxBarcodeScanner.ForeColor = Color.Black;
            txtBoxBarcodeScanner.Location = new Point(1415, 257);
            txtBoxBarcodeScanner.Margin = new Padding(3, 2, 3, 2);
            txtBoxBarcodeScanner.Name = "txtBoxBarcodeScanner";
            txtBoxBarcodeScanner.Size = new Size(494, 31);
            txtBoxBarcodeScanner.TabIndex = 4;
            txtBoxBarcodeScanner.TextChanged += textBox1_TextChanged;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.BackColor = Color.FromArgb(247, 247, 247);
            labelTotal.Font = new Font("Segoe UI", 99.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelTotal.ForeColor = Color.FromArgb(76, 175, 80);
            labelTotal.Location = new Point(1383, 35);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(418, 175);
            labelTotal.TabIndex = 5;
            labelTotal.Text = "0.00€";
            // 
            // btnShtypShitjen
            // 
            btnShtypShitjen.Location = new Point(73, 918);
            btnShtypShitjen.Name = "btnShtypShitjen";
            btnShtypShitjen.Size = new Size(175, 80);
            btnShtypShitjen.TabIndex = 6;
            btnShtypShitjen.Text = "F2";
            btnShtypShitjen.UseVisualStyleBackColor = true;
            btnShtypShitjen.Click += btnShtypShitjen_Click;
            // 
            // btnAddProducts
            // 
            btnAddProducts.ForeColor = SystemColors.ControlText;
            btnAddProducts.Location = new Point(248, 918);
            btnAddProducts.Name = "btnAddProducts";
            btnAddProducts.Size = new Size(175, 80);
            btnAddProducts.TabIndex = 7;
            btnAddProducts.Text = "Shtoni Produkte (F3)";
            btnAddProducts.UseVisualStyleBackColor = true;
            btnAddProducts.Click += btnAddProducts_Click;
            // 
            // btnEditProducts
            // 
            btnEditProducts.ForeColor = SystemColors.ControlText;
            btnEditProducts.Location = new Point(423, 918);
            btnEditProducts.Name = "btnEditProducts";
            btnEditProducts.Size = new Size(175, 80);
            btnEditProducts.TabIndex = 8;
            btnEditProducts.Text = "Ndrysho produckte (F4)";
            btnEditProducts.UseVisualStyleBackColor = true;
            btnEditProducts.Click += btnEditProducts_Click;
            // 
            // btnSales
            // 
            btnSales.ForeColor = SystemColors.ControlText;
            btnSales.Location = new Point(598, 918);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(175, 80);
            btnSales.TabIndex = 9;
            btnSales.Text = "Shitjet (F5)";
            btnSales.UseVisualStyleBackColor = true;
            btnSales.Click += btnSales_Click;
            // 
            // btnAddQuantity
            // 
            btnAddQuantity.ForeColor = SystemColors.ControlText;
            btnAddQuantity.Location = new Point(948, 918);
            btnAddQuantity.Name = "btnAddQuantity";
            btnAddQuantity.Size = new Size(175, 80);
            btnAddQuantity.TabIndex = 10;
            btnAddQuantity.Text = "Shto sasi (F9)";
            btnAddQuantity.UseVisualStyleBackColor = true;
            btnAddQuantity.Click += btnAddQuantity_Click;
            // 
            // btnDelete
            // 
            btnDelete.ForeColor = SystemColors.ControlText;
            btnDelete.Location = new Point(1123, 918);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(175, 80);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Fshij produkt (delete)";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnProductsForm
            // 
            btnProductsForm.ForeColor = SystemColors.ControlText;
            btnProductsForm.Location = new Point(773, 918);
            btnProductsForm.Name = "btnProductsForm";
            btnProductsForm.Size = new Size(175, 80);
            btnProductsForm.TabIndex = 12;
            btnProductsForm.Text = "Produktet (F6)";
            btnProductsForm.UseVisualStyleBackColor = true;
            btnProductsForm.Click += button1_Click;
            // 
            // lblDitaEJaves
            // 
            lblDitaEJaves.AutoSize = true;
            lblDitaEJaves.BackColor = Color.WhiteSmoke;
            lblDitaEJaves.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDitaEJaves.ForeColor = Color.Black;
            lblDitaEJaves.Location = new Point(21, 103);
            lblDitaEJaves.Name = "lblDitaEJaves";
            lblDitaEJaves.Size = new Size(0, 28);
            lblDitaEJaves.TabIndex = 14;
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.BackColor = Color.WhiteSmoke;
            lblVersion.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblVersion.ForeColor = Color.Black;
            lblVersion.Location = new Point(21, 159);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(0, 28);
            lblVersion.TabIndex = 15;
            // 
            // SalesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1919, 1060);
            ControlBox = false;
            Controls.Add(lblVersion);
            Controls.Add(lblDitaEJaves);
            Controls.Add(label1);
            Controls.Add(btnProductsForm);
            Controls.Add(btnDelete);
            Controls.Add(btnAddQuantity);
            Controls.Add(btnSales);
            Controls.Add(btnEditProducts);
            Controls.Add(btnAddProducts);
            Controls.Add(btnShtypShitjen);
            Controls.Add(panel2);
            Controls.Add(labelTotal);
            Controls.Add(txtBoxBarcodeScanner);
            Controls.Add(DGVProducts);
            Controls.Add(panel4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "SalesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            KeyDown += SalesForm_KeyDown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGVProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private DataGridView DGVProducts;
        private TextBox txtBoxBarcodeScanner;
        private Label labelTotal;
        private PictureBox pictureBox1;
        private Button btnShtypShitjen;
        private Button btnAddProducts;
        private Button btnEditProducts;
        private Button btnSales;
        private Button btnAddQuantity;
        private Button btnDelete;
        private Button btnProductsForm;
        private Label label1;
        private Label lblDitaEJaves;
        private Label lblVersion;
    }
}
