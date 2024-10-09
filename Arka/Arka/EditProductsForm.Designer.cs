namespace Arka
{
    partial class EditProductsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProductsForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            label4 = new Label();
            label1 = new Label();
            btnAddProducts = new Button();
            txtBoxBarcode = new TextBox();
            txtBoxName = new TextBox();
            panel1 = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnSearch = new Button();
            DGVProducts = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVProducts).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(418, 52);
            label4.Name = "label4";
            label4.Size = new Size(55, 28);
            label4.TabIndex = 20;
            label4.Text = "Emri:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(147, 52);
            label1.Name = "label1";
            label1.Size = new Size(87, 28);
            label1.TabIndex = 17;
            label1.Text = "Barcode:";
            // 
            // btnAddProducts
            // 
            btnAddProducts.BackColor = Color.FromArgb(0, 150, 136);
            btnAddProducts.BackgroundImageLayout = ImageLayout.None;
            btnAddProducts.FlatStyle = FlatStyle.Flat;
            btnAddProducts.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddProducts.Location = new Point(628, 440);
            btnAddProducts.Name = "btnAddProducts";
            btnAddProducts.Size = new Size(162, 56);
            btnAddProducts.TabIndex = 16;
            btnAddProducts.Text = "Ndrysho artikullin";
            btnAddProducts.UseVisualStyleBackColor = false;
            btnAddProducts.Click += btnAddProducts_Click;
            // 
            // txtBoxBarcode
            // 
            txtBoxBarcode.BackColor = Color.White;
            txtBoxBarcode.BorderStyle = BorderStyle.None;
            txtBoxBarcode.Font = new Font("Poppins", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxBarcode.Location = new Point(147, 83);
            txtBoxBarcode.Name = "txtBoxBarcode";
            txtBoxBarcode.Size = new Size(196, 36);
            txtBoxBarcode.TabIndex = 15;
            txtBoxBarcode.TextChanged += txtBoxBarcode_TextChanged;
            // 
            // txtBoxName
            // 
            txtBoxName.BackColor = Color.White;
            txtBoxName.BorderStyle = BorderStyle.None;
            txtBoxName.Font = new Font("Poppins", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxName.Location = new Point(418, 83);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(196, 36);
            txtBoxName.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(54, 69, 79);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-592, -1);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1382, 31);
            panel1.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(595, 4);
            label2.Name = "label2";
            label2.Size = new Size(141, 26);
            label2.TabIndex = 22;
            label2.Text = "Zgjedh Produktin";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(1355, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(27, 29);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(1893, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 31);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(0, 150, 136);
            btnSearch.BackgroundImageLayout = ImageLayout.None;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.Location = new Point(646, 78);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(79, 41);
            btnSearch.TabIndex = 22;
            btnSearch.Text = "Kerko";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // DGVProducts
            // 
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
            DGVProducts.Location = new Point(12, 146);
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
            DGVProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVProducts.Size = new Size(764, 260);
            DGVProducts.TabIndex = 23;
            // 
            // EditProductsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 495);
            Controls.Add(DGVProducts);
            Controls.Add(btnSearch);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(btnAddProducts);
            Controls.Add(txtBoxBarcode);
            Controls.Add(txtBoxName);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditProductsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditProductsForm";
            KeyDown += EditProductsForm_KeyDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label1;
        private Button btnAddProducts;
        private TextBox txtBoxBarcode;
        private TextBox txtBoxName;
        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label2;
        private Button btnSearch;
        private DataGridView DGVProducts;
    }
}