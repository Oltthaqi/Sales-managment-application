namespace Arka
{
    partial class AddProductsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductsForm));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            txtBoxName = new TextBox();
            txtBoxQuantity = new TextBox();
            txtBoxPrice = new TextBox();
            txtBoxBarcode = new TextBox();
            btnAddProducts = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(54, 69, 79);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-571, -2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1372, 31);
            panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(1144, 2);
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
            // txtBoxName
            // 
            txtBoxName.BackColor = Color.White;
            txtBoxName.BorderStyle = BorderStyle.None;
            txtBoxName.Font = new Font("Poppins", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxName.Location = new Point(330, 81);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(196, 36);
            txtBoxName.TabIndex = 2;
            // 
            // txtBoxQuantity
            // 
            txtBoxQuantity.BackColor = Color.White;
            txtBoxQuantity.BorderStyle = BorderStyle.None;
            txtBoxQuantity.Font = new Font("Poppins", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxQuantity.Location = new Point(330, 214);
            txtBoxQuantity.Name = "txtBoxQuantity";
            txtBoxQuantity.Size = new Size(196, 36);
            txtBoxQuantity.TabIndex = 3;
            // 
            // txtBoxPrice
            // 
            txtBoxPrice.BackColor = Color.White;
            txtBoxPrice.BorderStyle = BorderStyle.None;
            txtBoxPrice.Font = new Font("Poppins", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxPrice.Location = new Point(59, 214);
            txtBoxPrice.Name = "txtBoxPrice";
            txtBoxPrice.Size = new Size(196, 36);
            txtBoxPrice.TabIndex = 4;
            // 
            // txtBoxBarcode
            // 
            txtBoxBarcode.BackColor = Color.White;
            txtBoxBarcode.BorderStyle = BorderStyle.None;
            txtBoxBarcode.Font = new Font("Poppins", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxBarcode.Location = new Point(59, 81);
            txtBoxBarcode.Name = "txtBoxBarcode";
            txtBoxBarcode.Size = new Size(196, 36);
            txtBoxBarcode.TabIndex = 5;
            // 
            // btnAddProducts
            // 
            btnAddProducts.BackColor = Color.FromArgb(0, 150, 136);
            btnAddProducts.BackgroundImageLayout = ImageLayout.None;
            btnAddProducts.FlatStyle = FlatStyle.Flat;
            btnAddProducts.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddProducts.Location = new Point(475, 395);
            btnAddProducts.Name = "btnAddProducts";
            btnAddProducts.Size = new Size(126, 56);
            btnAddProducts.TabIndex = 6;
            btnAddProducts.Text = "Add products";
            btnAddProducts.UseVisualStyleBackColor = false;
            btnAddProducts.Click += btnAddProducts_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(59, 50);
            label1.Name = "label1";
            label1.Size = new Size(87, 28);
            label1.TabIndex = 7;
            label1.Text = "Barcode:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(330, 183);
            label2.Name = "label2";
            label2.Size = new Size(63, 28);
            label2.TabIndex = 8;
            label2.Text = "Sasia:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(59, 183);
            label3.Name = "label3";
            label3.Size = new Size(73, 28);
            label3.TabIndex = 9;
            label3.Text = "Cmimi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(330, 50);
            label4.Name = "label4";
            label4.Size = new Size(55, 28);
            label4.TabIndex = 10;
            label4.Text = "Emri:";
            // 
            // AddProductsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 242, 253);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(600, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAddProducts);
            Controls.Add(txtBoxBarcode);
            Controls.Add(txtBoxPrice);
            Controls.Add(txtBoxQuantity);
            Controls.Add(txtBoxName);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddProductsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddProductsForm";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox txtBoxName;
        private TextBox txtBoxQuantity;
        private TextBox txtBoxPrice;
        private TextBox txtBoxBarcode;
        private Button btnAddProducts;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}