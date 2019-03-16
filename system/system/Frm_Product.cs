using system.dal;
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
    public partial class Frm_Product : Form
    {
        public Frm_Product()
        {
            InitializeComponent();
        }

        private void Frm_Product_Load(object sender, EventArgs e)
        {
            this.productBindingSource.DataSource = dataContextFactory.DataContext.Products;
        }
    }
}
