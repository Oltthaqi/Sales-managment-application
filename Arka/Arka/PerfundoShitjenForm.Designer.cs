namespace Arka
{
    partial class PerfundoShitjenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PerfundoShitjenForm));
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnEnd = new Button();
            btnExit = new Button();
            panel2 = new Panel();
            label4 = new Label();
            label3 = new Label();
            txtTotal = new TextBox();
            label1 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(763, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 33);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(54, 69, 79);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-323, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1014, 34);
            panel1.TabIndex = 13;
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
            // btnEnd
            // 
            btnEnd.BackColor = Color.FromArgb(0, 150, 136);
            btnEnd.BackgroundImageLayout = ImageLayout.None;
            btnEnd.FlatStyle = FlatStyle.Flat;
            btnEnd.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEnd.Location = new Point(313, 274);
            btnEnd.Name = "btnEnd";
            btnEnd.Size = new Size(123, 45);
            btnEnd.TabIndex = 28;
            btnEnd.Text = "Perfundo";
            btnEnd.UseVisualStyleBackColor = false;
            btnEnd.Click += btnEnd_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(0, 150, 136);
            btnExit.BackgroundImageLayout = ImageLayout.None;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.Location = new Point(36, 274);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(125, 45);
            btnExit.TabIndex = 29;
            btnExit.Text = "Cancel (ESC)";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(236, 239, 241);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtTotal);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(36, 54);
            panel2.Name = "panel2";
            panel2.Size = new Size(400, 185);
            panel2.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(287, 142);
            label4.Name = "label4";
            label4.Size = new Size(0, 42);
            label4.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(52, 142);
            label3.Name = "label3";
            label3.Size = new Size(60, 28);
            label3.TabIndex = 33;
            label3.Text = "kusur";
            // 
            // txtTotal
            // 
            txtTotal.BorderStyle = BorderStyle.None;
            txtTotal.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtTotal.Location = new Point(172, 63);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(181, 36);
            txtTotal.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(52, 71);
            label1.Name = "label1";
            label1.Size = new Size(58, 28);
            label1.TabIndex = 31;
            label1.Text = "CASH";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(271, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 48);
            label2.TabIndex = 0;
            label2.Text = "0.00";
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Location = new Point(36, 54);
            panel3.Name = "panel3";
            panel3.Size = new Size(400, 41);
            panel3.TabIndex = 0;
            // 
            // PerfundoShitjenForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 337);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(btnExit);
            Controls.Add(btnEnd);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PerfundoShitjenForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PerfundoShitjenForm";
            KeyDown += PerfundoShitjenForm_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnEnd;
        private Button btnExit;
        private Panel panel2;
        private Label label1;
        private TextBox txtTotal;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel3;
    }
}