namespace Arka
{
    partial class DbConnectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DbConnectionForm));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            serverNametxtBox = new TextBox();
            userTxtBox = new TextBox();
            passwordtxtbox = new TextBox();
            databasetxtBox = new TextBox();
            btnConnect = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(337, 47);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(288, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(49, 50);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // serverNametxtBox
            // 
            serverNametxtBox.Font = new Font("Poppins", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            serverNametxtBox.Location = new Point(83, 92);
            serverNametxtBox.Name = "serverNametxtBox";
            serverNametxtBox.Size = new Size(159, 48);
            serverNametxtBox.TabIndex = 1;
            // 
            // userTxtBox
            // 
            userTxtBox.Font = new Font("Poppins", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            userTxtBox.Location = new Point(83, 265);
            userTxtBox.Name = "userTxtBox";
            userTxtBox.Size = new Size(159, 48);
            userTxtBox.TabIndex = 2;
            // 
            // passwordtxtbox
            // 
            passwordtxtbox.Font = new Font("Poppins", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            passwordtxtbox.Location = new Point(83, 346);
            passwordtxtbox.Name = "passwordtxtbox";
            passwordtxtbox.Size = new Size(159, 48);
            passwordtxtbox.TabIndex = 3;
            // 
            // databasetxtBox
            // 
            databasetxtBox.Font = new Font("Poppins", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            databasetxtBox.Location = new Point(83, 181);
            databasetxtBox.Name = "databasetxtBox";
            databasetxtBox.Size = new Size(159, 48);
            databasetxtBox.TabIndex = 4;
            // 
            // btnConnect
            // 
            btnConnect.BackColor = Color.LightBlue;
            btnConnect.FlatStyle = FlatStyle.Popup;
            btnConnect.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnConnect.Location = new Point(231, 433);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(106, 47);
            btnConnect.TabIndex = 5;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = false;
            btnConnect.Click += btnConnect_Click;
            // 
            // DbConnectionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Silver;
            ClientSize = new Size(336, 479);
            ControlBox = false;
            Controls.Add(btnConnect);
            Controls.Add(databasetxtBox);
            Controls.Add(passwordtxtbox);
            Controls.Add(userTxtBox);
            Controls.Add(serverNametxtBox);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DbConnectionForm";
            Text = "DbConnectionForm";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox serverNametxtBox;
        private TextBox userTxtBox;
        private TextBox passwordtxtbox;
        private TextBox databasetxtBox;
        private Button btnConnect;
    }
}