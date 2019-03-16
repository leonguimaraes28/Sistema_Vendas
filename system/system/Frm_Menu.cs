using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace system
{
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Product frm = new Frm_Product();//frm é a variavel que pertence a classe da variavel frm_products
            frm.Show();
        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            Frm_Product frm = new Frm_Product();//frm é a variavel que pertence a classe da variavel frm_products
            frm.Show();
        }

        private void btn_category_Click(object sender, EventArgs e)
        {
            Frm_Category frm = new Frm_Category();
            frm.Show();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Category frm = new Frm_Category();
            frm.Show();
        }
    }
}
