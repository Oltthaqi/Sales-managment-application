namespace Arka
{
    partial class ProductsForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsForm));
            btnSearch = new Button();
            label1 = new Label();
            txtBoxName = new TextBox();
            DGVProducts = new DataGridView();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)DGVProducts).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(0, 150, 136);
            btnSearch.BackgroundImageLayout = ImageLayout.None;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.Location = new Point(310, 65);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(79, 41);
            btnSearch.TabIndex = 34;
            btnSearch.Text = "Kerko";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(30, 39);
            label1.Name = "label1";
            label1.Size = new Size(78, 28);
            label1.TabIndex = 32;
            label1.Text = "Artikulli";
            // 
            // txtBoxName
            // 
            txtBoxName.BackColor = Color.White;
            txtBoxName.BorderStyle = BorderStyle.None;
            txtBoxName.Font = new Font("Poppins", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxName.Location = new Point(30, 70);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(196, 36);
            txtBoxName.TabIndex = 31;
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
            DGVProducts.Location = new Point(22, 125);
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
            DGVProducts.Size = new Size(1213, 610);
            DGVProducts.TabIndex = 30;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(54, 69, 79);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-58, -2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1330, 35);
            panel1.TabIndex = 29;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(1299, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 33);
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
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(424, 65);
            button1.Name = "button1";
            button1.Size = new Size(79, 41);
            button1.TabIndex = 35;
            button1.Text = "Fshij";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1271, 814);
            Controls.Add(button1);
            Controls.Add(btnSearch);
            Controls.Add(label1);
            Controls.Add(txtBoxName);
            Controls.Add(DGVProducts);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductsForm";
            Text = "ProductsForm";
            ((System.ComponentModel.ISupportInitialize)DGVProducts).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private Label label1;
        private TextBox txtBoxName;
        private DataGridView DGVProducts;
        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button button1;
    }
}