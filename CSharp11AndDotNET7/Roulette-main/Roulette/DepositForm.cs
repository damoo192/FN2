using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roulette
{
    public partial class DepositForm : Form
    {
        public int amount;
        public DepositForm()
        {
            InitializeComponent();
        }

        private void nudAmount_Validating(object sender, CancelEventArgs e)
        {
            if (int.Parse(nudAmount.Text) <= 0)
            {
                errorProvider1.SetError(nudAmount, "Amount has to be higher than 0!");
                e.Cancel = true;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void depositBtn_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                amount = int.Parse(nudAmount.Text);
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
