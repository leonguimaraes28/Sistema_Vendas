namespace system
{
    partial class Frm_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_product = new System.Windows.Forms.Button();
            this.btn_category = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1027, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsToolStripMenuItem,
            this.categoryToolStripMenuItem});
            this.insertToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(65, 27);
            this.insertToolStripMenuItem.Text = "Insert";
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(216, 28);
            this.productsToolStripMenuItem.Text = "Product";
            this.productsToolStripMenuItem.Click += new System.EventHandler(this.productsToolStripMenuItem_Click);
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(216, 28);
            this.categoryToolStripMenuItem.Text = "Category";
            this.categoryToolStripMenuItem.Click += new System.EventHandler(this.categoryToolStripMenuItem_Click);
            // 
            // btn_product
            // 
            this.btn_product.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_product.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_product.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_product.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_product.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_product.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_product.Image = ((System.Drawing.Image)(resources.GetObject("btn_product.Image")));
            this.btn_product.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_product.Location = new System.Drawing.Point(65, 102);
            this.btn_product.Name = "btn_product";
            this.btn_product.Size = new System.Drawing.Size(287, 77);
            this.btn_product.TabIndex = 1;
            this.btn_product.Text = "Product";
            this.btn_product.UseVisualStyleBackColor = false;
            this.btn_product.Click += new System.EventHandler(this.btn_product_Click);
            // 
            // btn_category
            // 
            this.btn_category.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_category.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_category.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_category.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_category.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_category.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_category.Image = ((System.Drawing.Image)(resources.GetObject("btn_category.Image")));
            this.btn_category.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_category.Location = new System.Drawing.Point(65, 233);
            this.btn_category.Name = "btn_category";
            this.btn_category.Size = new System.Drawing.Size(287, 77);
            this.btn_category.TabIndex = 2;
            this.btn_category.Text = "Category";
            this.btn_category.UseVisualStyleBackColor = false;
            this.btn_category.Click += new System.EventHandler(this.btn_category_Click);
            // 
            // Frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1027, 536);
            this.Controls.Add(this.btn_category);
            this.Controls.Add(this.btn_product);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.Button btn_product;
        private System.Windows.Forms.Button btn_category;
    }
}

