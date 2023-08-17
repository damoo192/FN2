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
    public partial class RulesForm : Form
    {
        public RulesForm()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("Roulette.png");
            pictureBox1.Size = pictureBox1.Image.Size;
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.Location = new Point(0, 0);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void RulesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
