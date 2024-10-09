namespace Arka
{
    partial class AddQuantityForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuantityForm));
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            txtBoxQuantity = new TextBox();
            btnOk = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(684, 6);
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
            panel1.Location = new Point(-296, -6);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(717, 39);
            panel1.TabIndex = 14;
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
            // txtBoxQuantity
            // 
            txtBoxQuantity.BorderStyle = BorderStyle.None;
            txtBoxQuantity.Font = new Font("Poppins", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtBoxQuantity.Location = new Point(54, 97);
            txtBoxQuantity.Name = "txtBoxQuantity";
            txtBoxQuantity.Size = new Size(313, 41);
            txtBoxQuantity.TabIndex = 15;
            txtBoxQuantity.Text = "0";
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.FromArgb(0, 150, 136);
            btnOk.BackgroundImageLayout = ImageLayout.None;
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.Font = new Font("Poppins", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnOk.Location = new Point(313, 175);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(92, 46);
            btnOk.TabIndex = 29;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // AddQuantityForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(417, 233);
            Controls.Add(btnOk);
            Controls.Add(txtBoxQuantity);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddQuantityForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddQuantityForm";
            KeyDown += AddQuantityForm_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox txtBoxQuantity;
        private Button btnOk;
    }
}