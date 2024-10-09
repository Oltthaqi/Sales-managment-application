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
    public partial class PerfundoShitjenForm : Form
    {

        string total;
        public PerfundoShitjenForm(double Total)
        {
            InitializeComponent();
            this.KeyPreview = true;
            total = Total.ToString("F2");
            label2.Text = total + " €";   
            txtTotal.Text = total + " €";
            label4.Text = "0.00 €";

        }
        public void generateChange()
        {
            double _total = Convert.ToDouble(total);
            double cash = Convert.ToDouble(txtTotal.Text.Replace("€", "").Trim());
            double change =  cash - _total;

            label4.Text = change.ToString("F2") + " €";
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txtTotal.Text.Replace("€", "").Trim()) - Convert.ToDouble(total) >= 0)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Error: totali nuk mund te jet me i madh se sa parat ne dor");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PerfundoShitjenForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                {
                 generateChange();
                }else if(e.KeyCode == Keys.Escape) { btnExit.PerformClick(); }
        }
    }
}
