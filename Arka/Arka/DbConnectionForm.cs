using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arka
{
    public partial class DbConnectionForm : Form
    {
        public DbConnectionForm()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (serverNametxtBox.Text != null && databasetxtBox.Text != null && userTxtBox.Text != null && passwordtxtbox.Text != null)
            {
                Properties.setting.Default.connection = $"Data Source={serverNametxtBox.Text}; Initial Catalog={databasetxtBox.Text}; Integrated Security=SSPI ";
                Properties.setting.Default.Save();
                SalesForm salesForm = new SalesForm();
                this.Hide();
                salesForm.Show();
            }
            else
            {
                MessageBox.Show("Error: Fill all fields");
            }
        }
    }
}
