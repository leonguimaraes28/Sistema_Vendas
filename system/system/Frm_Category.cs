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
                MessageBox.Show("Category has been registered","Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            if (DialogResult.Yes == MessageBox.Show("Delete the Category "+selectedCategoryName.ToString()+"?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                if (this.categoryHasProducts(getCategory))//verifica se a categoria selecionada tem produtos associados
                    MessageBox.Show("Category cannot be removed, since it has been associated to products", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    this.categoryBindingSource.RemoveCurrent();
                    dataContextFactory.DataContext.SubmitChanges();
                    MessageBox.Show("Category has been removed!","Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.categoryBindingSource.CancelEdit();
        }

        public Category getCategory
        {
            get
            {
                return (Category)this.categoryBindingSource.Current;//retorna a categoria selecionada
            }
        }

        private bool categoryHasProducts(Category ctg)//metodo que verifica se a categoria atual possui produtos associados
        {
            var getProducts = dataContextFactory.DataContext.Products.Where(x => x.IdCategory == ctg.IdCategory);
            if (getProducts.Count() > 0)
                return true;
            else
                return false;
        }

       public override string ToString()//sem o override ToString() a classe aparece como "system.dal.Category"
        {
            return base.ToString();
        }


        public Category selectedCategoryName
        {
            get
            {

                return (Category)this.categoryBindingSource.Current;//retorna a categoria selecionada
            }
        }

    }

}
