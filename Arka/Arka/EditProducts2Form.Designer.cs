namespace Arka
{
    partial class EditProducts2Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProducts2Form));
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnAddProducts = new Button();
            txtBoxBarcode = new TextBox();
            txtBoxPrice = new TextBox();
            txtBoxQuantity = new TextBox();
            txtBoxName = new TextBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(365, 50);
            label4.Name = "label4";
            label4.Size = new Size(55, 28);
            label4.TabIndex = 20;
            label4.Text = "Emri:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(94, 183);
            label3.Name = "label3";
            label3.Size = new Size(73, 28);
            label3.TabIndex = 19;
            label3.Text = "Cmimi:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(365, 183);
            label2.Name = "label2";
            label2.Size = new Size(63, 28);
            label2.TabIndex = 18;
            label2.Text = "Sasia:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(94, 50);
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
            btnAddProducts.Location = new Point(492, 395);
            btnAddProducts.Name = "btnAddProducts";
            btnAddProducts.Size = new Size(165, 56);
            btnAddProducts.TabIndex = 16;
            btnAddProducts.Text = "Ndrysho Produktin";
            btnAddProducts.UseVisualStyleBackColor = false;
            btnAddProducts.Click += btnAddProducts_Click;
            // 
            // txtBoxBarcode
            // 
            txtBoxBarcode.BackColor = Color.White;
            txtBoxBarcode.BorderStyle = BorderStyle.None;
            txtBoxBarcode.Font = new Font("Poppins", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxBarcode.Location = new Point(94, 81);
            txtBoxBarcode.Name = "txtBoxBarcode";
            txtBoxBarcode.Size = new Size(196, 36);
            txtBoxBarcode.TabIndex = 15;
            // 
            // txtBoxPrice
            // 
            txtBoxPrice.BackColor = Color.White;
            txtBoxPrice.BorderStyle = BorderStyle.None;
            txtBoxPrice.Font = new Font("Poppins", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxPrice.Location = new Point(94, 214);
            txtBoxPrice.Name = "txtBoxPrice";
            txtBoxPrice.Size = new Size(196, 36);
            txtBoxPrice.TabIndex = 14;
            // 
            // txtBoxQuantity
            // 
            txtBoxQuantity.BackColor = Color.White;
            txtBoxQuantity.BorderStyle = BorderStyle.None;
            txtBoxQuantity.Font = new Font("Poppins", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxQuantity.Location = new Point(365, 214);
            txtBoxQuantity.Name = "txtBoxQuantity";
            txtBoxQuantity.Size = new Size(196, 36);
            txtBoxQuantity.TabIndex = 13;
            // 
            // txtBoxName
            // 
            txtBoxName.BackColor = Color.White;
            txtBoxName.BorderStyle = BorderStyle.None;
            txtBoxName.Font = new Font("Poppins", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxName.Location = new Point(365, 81);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(196, 36);
            txtBoxName.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(54, 69, 79);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(657, 31);
            panel1.TabIndex = 11;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Dock = DockStyle.Right;
            pictureBox2.Location = new Point(630, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(27, 31);
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
            // EditProducts2Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(657, 450);
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
            Name = "EditProducts2Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditProducts2Form";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnAddProducts;
        private TextBox txtBoxBarcode;
        private TextBox txtBoxPrice;
        private TextBox txtBoxQuantity;
        private TextBox txtBoxName;
        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}