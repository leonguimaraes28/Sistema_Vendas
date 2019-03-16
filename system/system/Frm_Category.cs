using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using system.dal;

namespace system
{
    public partial class Frm_Category : Form
    {
        public Frm_Category()
        {
            InitializeComponent();

        }

        private void Frm_Category_Load(object sender, EventArgs e)
        {
            this.categoryBindingSource.DataSource = dataContextFactory.DataContext.Categories;//no evento load do formulário vai ser inseridos os dados 
        }

        private void btn_newCategory_Click(object sender, EventArgs e)
        {   //metodo que permite adicionar

            this.categoryBindingSource.AddNew();//this é o objeto, quando é criada a conexao é gerado o bindingsource, addnew é propriedade que permite adicionar
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                this.categoryBindingSource.EndEdit();
                dataContextFactory.DataContext.SubmitChanges();
                MessageBox.Show("Category has been registered");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            if (DialogResult.Yes == MessageBox.Show("Do You Want Delete this Category?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                this.categoryBindingSource.RemoveCurrent();
                dataContextFactory.DataContext.SubmitChanges();

                //COMO DELETAR SEM OS CONFLITOS DE CHAVES ESTRANGEIRAS????
            }
        }

        private bool checkData()
        {
            if (!string.IsNullOrEmpty(tb_category.Text.Trim()))
                return true;
            else
            {
                MessageBox.Show("Category field cannot be empty!");
                tb_category.Focus();
                return false;
            }
        }


    }
}
