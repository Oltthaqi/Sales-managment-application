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
    public partial class AddQuantityForm : Form
    {
        public int QuantityAdded { get; private set; }
        public AddQuantityForm()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        public void addQuantity()
        {

            QuantityAdded = Convert.ToInt32(txtBoxQuantity.Text);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            addQuantity();
            this.Close();
        }

        private void AddQuantityForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            { 
                btnOk.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                pictureBox2_Click(pictureBox2, EventArgs.Empty);
            }
        }
    }
}
