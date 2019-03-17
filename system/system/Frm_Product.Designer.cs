namespace system
{
    partial class Frm_Product
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
            this.components = new System.ComponentModel.Container();
            this.cb_provider = new System.Windows.Forms.ComboBox();
            this.lbl_provider = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_new = new System.Windows.Forms.Button();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.lbl_category = new System.Windows.Forms.Label();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_description = new System.Windows.Forms.Label();
            this.tb_description = new System.Windows.Forms.TextBox();
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProviderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSubCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_provider
            // 
            this.cb_provider.FormattingEnabled = true;
            this.cb_provider.Location = new System.Drawing.Point(616, 100);
            this.cb_provider.Name = "cb_provider";
            this.cb_provider.Size = new System.Drawing.Size(271, 24);
            this.cb_provider.TabIndex = 20;
            // 
            // lbl_provider
            // 
            this.lbl_provider.AutoSize = true;
            this.lbl_provider.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_provider.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_provider.Location = new System.Drawing.Point(508, 104);
            this.lbl_provider.Name = "lbl_provider";
            this.lbl_provider.Size = new System.Drawing.Size(71, 20);
            this.lbl_provider.TabIndex = 19;
            this.lbl_provider.Text = "Provider";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descriptionDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.idCategoryDataGridViewTextBoxColumn,
            this.idProviderDataGridViewTextBoxColumn,
            this.idSubCategoryDataGridViewTextBoxColumn,
            this.rEFDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(43, 260);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(925, 247);
            this.dataGridView1.TabIndex = 30;
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_new.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_new.Location = new System.Drawing.Point(108, 180);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(166, 48);
            this.btn_new.TabIndex = 21;
            this.btn_new.Text = "New Product";
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // cb_category
            // 
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Location = new System.Drawing.Point(174, 107);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(271, 24);
            this.cb_category.TabIndex = 18;
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_category.Location = new System.Drawing.Point(70, 107);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(76, 20);
            this.lbl_category.TabIndex = 17;
            this.lbl_category.Text = "Category";
            // 
            // tb_price
            // 
            this.tb_price.Location = new System.Drawing.Point(616, 29);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(271, 22);
            this.tb_price.TabIndex = 16;
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.Location = new System.Drawing.Point(528, 29);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(48, 20);
            this.lbl_price.TabIndex = 15;
            this.lbl_price.Text = "Price";
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_description.Location = new System.Drawing.Point(51, 31);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(95, 20);
            this.lbl_description.TabIndex = 13;
            this.lbl_description.Text = "Description";
            // 
            // tb_description
            // 
            this.tb_description.Location = new System.Drawing.Point(174, 31);
            this.tb_description.Name = "tb_description";
            this.tb_description.Size = new System.Drawing.Size(271, 22);
            this.tb_description.TabIndex = 15;
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_register.Location = new System.Drawing.Point(317, 180);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(166, 48);
            this.btn_register.TabIndex = 27;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = false;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_delete.Location = new System.Drawing.Point(532, 180);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(166, 48);
            this.btn_delete.TabIndex = 28;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_exit.Location = new System.Drawing.Point(738, 180);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(166, 48);
            this.btn_exit.TabIndex = 29;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 150;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price €";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 50;
            // 
            // idCategoryDataGridViewTextBoxColumn
            // 
            this.idCategoryDataGridViewTextBoxColumn.DataPropertyName = "IdCategory";
            this.idCategoryDataGridViewTextBoxColumn.HeaderText = "IdCategory";
            this.idCategoryDataGridViewTextBoxColumn.Name = "idCategoryDataGridViewTextBoxColumn";
            this.idCategoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idProviderDataGridViewTextBoxColumn
            // 
            this.idProviderDataGridViewTextBoxColumn.DataPropertyName = "IdProvider";
            this.idProviderDataGridViewTextBoxColumn.HeaderText = "IdProvider";
            this.idProviderDataGridViewTextBoxColumn.Name = "idProviderDataGridViewTextBoxColumn";
            this.idProviderDataGridViewTextBoxColumn.ReadOnly = true;
            this.idProviderDataGridViewTextBoxColumn.Width = 50;
            // 
            // idSubCategoryDataGridViewTextBoxColumn
            // 
            this.idSubCategoryDataGridViewTextBoxColumn.DataPropertyName = "IdSubCategory";
            this.idSubCategoryDataGridViewTextBoxColumn.HeaderText = "IdSubCategory";
            this.idSubCategoryDataGridViewTextBoxColumn.Name = "idSubCategoryDataGridViewTextBoxColumn";
            this.idSubCategoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.idSubCategoryDataGridViewTextBoxColumn.Width = 50;
            // 
            // rEFDataGridViewTextBoxColumn
            // 
            this.rEFDataGridViewTextBoxColumn.DataPropertyName = "REF";
            this.rEFDataGridViewTextBoxColumn.HeaderText = "REF";
            this.rEFDataGridViewTextBoxColumn.Name = "rEFDataGridViewTextBoxColumn";
            this.rEFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(system.dal.Product);
            // 
            // Frm_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1027, 536);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.tb_description);
            this.Controls.Add(this.cb_provider);
            this.Controls.Add(this.lbl_provider);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.cb_category);
            this.Controls.Add(this.lbl_category);
            this.Controls.Add(this.tb_price);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_description);
            this.Name = "Frm_Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Frm_Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_provider;
        private System.Windows.Forms.Label lbl_provider;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.ComboBox cb_category;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.TextBox tb_description;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProviderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSubCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
    }
}