namespace Arka
{
    partial class ShitjetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShitjetForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            DGVProducts = new DataGridView();
            btnSearch = new Button();
            label4 = new Label();
            label1 = new Label();
            txtBoxSaleId = new TextBox();
            DTPSales = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVProducts).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(1297, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 33);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(54, 69, 79);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-56, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1330, 35);
            panel1.TabIndex = 12;
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
            DGVProducts.Location = new Point(24, 127);
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
            DGVProducts.TabIndex = 13;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(0, 150, 136);
            btnSearch.BackgroundImageLayout = ImageLayout.None;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.Location = new Point(529, 75);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(79, 41);
            btnSearch.TabIndex = 27;
            btnSearch.Text = "Kerko";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(303, 41);
            label4.Name = "label4";
            label4.Size = new Size(56, 28);
            label4.TabIndex = 26;
            label4.Text = "Date:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(32, 41);
            label1.Name = "label1";
            label1.Size = new Size(29, 28);
            label1.TabIndex = 25;
            label1.Text = "ID";
            // 
            // txtBoxSaleId
            // 
            txtBoxSaleId.BackColor = Color.White;
            txtBoxSaleId.BorderStyle = BorderStyle.None;
            txtBoxSaleId.Font = new Font("Poppins", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxSaleId.Location = new Point(32, 72);
            txtBoxSaleId.Name = "txtBoxSaleId";
            txtBoxSaleId.Size = new Size(196, 36);
            txtBoxSaleId.TabIndex = 24;
            // 
            // DTPSales
            // 
            DTPSales.CalendarFont = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            DTPSales.Location = new Point(291, 81);
            DTPSales.Name = "DTPSales";
            DTPSales.Size = new Size(200, 23);
            DTPSales.TabIndex = 28;
            // 
            // ShitjetForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1271, 814);
            Controls.Add(DTPSales);
            Controls.Add(btnSearch);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(txtBoxSaleId);
            Controls.Add(DGVProducts);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ShitjetForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ShitjetForm";
            KeyDown += ShitjetForm_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private DataGridView DGVProducts;
        private Button btnSearch;
        private Label label4;
        private Label label1;
        private TextBox txtBoxSaleId;
        private DateTimePicker DTPSales;
    }
}