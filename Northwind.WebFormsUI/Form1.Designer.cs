namespace Northwind.WebFormsUI
{
    partial class Form1
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
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.gbxCategroy = new System.Windows.Forms.GroupBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.gbxProductName = new System.Windows.Forms.GroupBox();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.gbxNewProduct = new System.Windows.Forms.GroupBox();
            this.tbxQuantityPerLimit = new System.Windows.Forms.TextBox();
            this.tbxStock = new System.Windows.Forms.TextBox();
            this.cbxCategoryId = new System.Windows.Forms.ComboBox();
            this.tbxUnitPrice = new System.Windows.Forms.TextBox();
            this.tbxProductName2 = new System.Windows.Forms.TextBox();
            this.lblQuantityPerUnit = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblCategoryID = new System.Windows.Forms.Label();
            this.lblProductName2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gbxUptade = new System.Windows.Forms.GroupBox();
            this.tbxQuantityPerLimitUpdate = new System.Windows.Forms.TextBox();
            this.tbxStockUpdate = new System.Windows.Forms.TextBox();
            this.cbxCategoryIdUpdate = new System.Windows.Forms.ComboBox();
            this.tbxUnitPriceUpdate = new System.Windows.Forms.TextBox();
            this.tbxProductNameUpdate = new System.Windows.Forms.TextBox();
            this.lblQunatityPerUnit = new System.Windows.Forms.Label();
            this.lblStockUpdate = new System.Windows.Forms.Label();
            this.lblUnitPriceUptade = new System.Windows.Forms.Label();
            this.lblCategoryIdUpdate = new System.Windows.Forms.Label();
            this.lblProductNameUpdate = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.gbxCategroy.SuspendLayout();
            this.gbxProductName.SuspendLayout();
            this.gbxNewProduct.SuspendLayout();
            this.gbxUptade.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProduct
            // 
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(12, 233);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.Size = new System.Drawing.Size(764, 122);
            this.dgwProduct.TabIndex = 0;
            this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
            // 
            // gbxCategroy
            // 
            this.gbxCategroy.Controls.Add(this.cbxCategory);
            this.gbxCategroy.Controls.Add(this.lblCategory);
            this.gbxCategroy.Location = new System.Drawing.Point(12, 12);
            this.gbxCategroy.Name = "gbxCategroy";
            this.gbxCategroy.Size = new System.Drawing.Size(764, 100);
            this.gbxCategroy.TabIndex = 1;
            this.gbxCategroy.TabStop = false;
            this.gbxCategroy.Text = "Kategoriye Göre Arama";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(110, 43);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(185, 21);
            this.cbxCategory.TabIndex = 1;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(6, 43);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(46, 13);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Kategori";
            // 
            // gbxProductName
            // 
            this.gbxProductName.Controls.Add(this.tbxProductName);
            this.gbxProductName.Controls.Add(this.lblProductName);
            this.gbxProductName.Location = new System.Drawing.Point(12, 127);
            this.gbxProductName.Name = "gbxProductName";
            this.gbxProductName.Size = new System.Drawing.Size(764, 100);
            this.gbxProductName.TabIndex = 2;
            this.gbxProductName.TabStop = false;
            this.gbxProductName.Text = "Ürün Adına Göre Arama";
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(110, 46);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(185, 20);
            this.tbxProductName.TabIndex = 2;
            this.tbxProductName.TextChanged += new System.EventHandler(this.tbxProductName_TextChanged);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(6, 54);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(48, 13);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Ürün Adı";
            // 
            // gbxNewProduct
            // 
            this.gbxNewProduct.Controls.Add(this.tbxQuantityPerLimit);
            this.gbxNewProduct.Controls.Add(this.tbxStock);
            this.gbxNewProduct.Controls.Add(this.cbxCategoryId);
            this.gbxNewProduct.Controls.Add(this.tbxUnitPrice);
            this.gbxNewProduct.Controls.Add(this.tbxProductName2);
            this.gbxNewProduct.Controls.Add(this.lblQuantityPerUnit);
            this.gbxNewProduct.Controls.Add(this.lblStock);
            this.gbxNewProduct.Controls.Add(this.lblUnitPrice);
            this.gbxNewProduct.Controls.Add(this.lblCategoryID);
            this.gbxNewProduct.Controls.Add(this.lblProductName2);
            this.gbxNewProduct.Location = new System.Drawing.Point(12, 390);
            this.gbxNewProduct.Name = "gbxNewProduct";
            this.gbxNewProduct.Size = new System.Drawing.Size(353, 187);
            this.gbxNewProduct.TabIndex = 3;
            this.gbxNewProduct.TabStop = false;
            this.gbxNewProduct.Text = "Yeni Ürün Ekle";
            // 
            // tbxQuantityPerLimit
            // 
            this.tbxQuantityPerLimit.Location = new System.Drawing.Point(86, 129);
            this.tbxQuantityPerLimit.Name = "tbxQuantityPerLimit";
            this.tbxQuantityPerLimit.Size = new System.Drawing.Size(185, 20);
            this.tbxQuantityPerLimit.TabIndex = 8;
            // 
            // tbxStock
            // 
            this.tbxStock.Location = new System.Drawing.Point(86, 103);
            this.tbxStock.Name = "tbxStock";
            this.tbxStock.Size = new System.Drawing.Size(185, 20);
            this.tbxStock.TabIndex = 7;
            // 
            // cbxCategoryId
            // 
            this.cbxCategoryId.FormattingEnabled = true;
            this.cbxCategoryId.Location = new System.Drawing.Point(86, 48);
            this.cbxCategoryId.Name = "cbxCategoryId";
            this.cbxCategoryId.Size = new System.Drawing.Size(185, 21);
            this.cbxCategoryId.TabIndex = 2;
            // 
            // tbxUnitPrice
            // 
            this.tbxUnitPrice.Location = new System.Drawing.Point(86, 75);
            this.tbxUnitPrice.Name = "tbxUnitPrice";
            this.tbxUnitPrice.Size = new System.Drawing.Size(185, 20);
            this.tbxUnitPrice.TabIndex = 6;
            // 
            // tbxProductName2
            // 
            this.tbxProductName2.Location = new System.Drawing.Point(86, 16);
            this.tbxProductName2.Name = "tbxProductName2";
            this.tbxProductName2.Size = new System.Drawing.Size(185, 20);
            this.tbxProductName2.TabIndex = 5;
            // 
            // lblQuantityPerUnit
            // 
            this.lblQuantityPerUnit.AutoSize = true;
            this.lblQuantityPerUnit.Location = new System.Drawing.Point(6, 133);
            this.lblQuantityPerUnit.Name = "lblQuantityPerUnit";
            this.lblQuantityPerUnit.Size = new System.Drawing.Size(59, 13);
            this.lblQuantityPerUnit.TabIndex = 4;
            this.lblQuantityPerUnit.Text = "Birim Adedi";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(6, 106);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(59, 13);
            this.lblStock.TabIndex = 3;
            this.lblStock.Text = "Stok Adedi";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(6, 75);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(29, 13);
            this.lblUnitPrice.TabIndex = 2;
            this.lblUnitPrice.Text = "Fiyat";
            // 
            // lblCategoryID
            // 
            this.lblCategoryID.AutoSize = true;
            this.lblCategoryID.Location = new System.Drawing.Point(6, 45);
            this.lblCategoryID.Name = "lblCategoryID";
            this.lblCategoryID.Size = new System.Drawing.Size(46, 13);
            this.lblCategoryID.TabIndex = 1;
            this.lblCategoryID.Text = "Kategori";
            // 
            // lblProductName2
            // 
            this.lblProductName2.AutoSize = true;
            this.lblProductName2.Location = new System.Drawing.Point(6, 16);
            this.lblProductName2.Name = "lblProductName2";
            this.lblProductName2.Size = new System.Drawing.Size(48, 13);
            this.lblProductName2.TabIndex = 0;
            this.lblProductName2.Text = "Ürün Adı";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(98, 545);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(185, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(509, 545);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(185, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // gbxUptade
            // 
            this.gbxUptade.Controls.Add(this.tbxQuantityPerLimitUpdate);
            this.gbxUptade.Controls.Add(this.tbxStockUpdate);
            this.gbxUptade.Controls.Add(this.cbxCategoryIdUpdate);
            this.gbxUptade.Controls.Add(this.tbxUnitPriceUpdate);
            this.gbxUptade.Controls.Add(this.tbxProductNameUpdate);
            this.gbxUptade.Controls.Add(this.lblQunatityPerUnit);
            this.gbxUptade.Controls.Add(this.lblStockUpdate);
            this.gbxUptade.Controls.Add(this.lblUnitPriceUptade);
            this.gbxUptade.Controls.Add(this.lblCategoryIdUpdate);
            this.gbxUptade.Controls.Add(this.lblProductNameUpdate);
            this.gbxUptade.Location = new System.Drawing.Point(423, 390);
            this.gbxUptade.Name = "gbxUptade";
            this.gbxUptade.Size = new System.Drawing.Size(353, 187);
            this.gbxUptade.TabIndex = 5;
            this.gbxUptade.TabStop = false;
            this.gbxUptade.Text = "Ürün Güncelleme";
            // 
            // tbxQuantityPerLimitUpdate
            // 
            this.tbxQuantityPerLimitUpdate.Location = new System.Drawing.Point(86, 129);
            this.tbxQuantityPerLimitUpdate.Name = "tbxQuantityPerLimitUpdate";
            this.tbxQuantityPerLimitUpdate.Size = new System.Drawing.Size(185, 20);
            this.tbxQuantityPerLimitUpdate.TabIndex = 8;
            // 
            // tbxStockUpdate
            // 
            this.tbxStockUpdate.Location = new System.Drawing.Point(86, 103);
            this.tbxStockUpdate.Name = "tbxStockUpdate";
            this.tbxStockUpdate.Size = new System.Drawing.Size(185, 20);
            this.tbxStockUpdate.TabIndex = 7;
            // 
            // cbxCategoryIdUpdate
            // 
            this.cbxCategoryIdUpdate.FormattingEnabled = true;
            this.cbxCategoryIdUpdate.Location = new System.Drawing.Point(86, 48);
            this.cbxCategoryIdUpdate.Name = "cbxCategoryIdUpdate";
            this.cbxCategoryIdUpdate.Size = new System.Drawing.Size(185, 21);
            this.cbxCategoryIdUpdate.TabIndex = 2;
            // 
            // tbxUnitPriceUpdate
            // 
            this.tbxUnitPriceUpdate.Location = new System.Drawing.Point(86, 75);
            this.tbxUnitPriceUpdate.Name = "tbxUnitPriceUpdate";
            this.tbxUnitPriceUpdate.Size = new System.Drawing.Size(185, 20);
            this.tbxUnitPriceUpdate.TabIndex = 6;
            // 
            // tbxProductNameUpdate
            // 
            this.tbxProductNameUpdate.Location = new System.Drawing.Point(86, 16);
            this.tbxProductNameUpdate.Name = "tbxProductNameUpdate";
            this.tbxProductNameUpdate.Size = new System.Drawing.Size(185, 20);
            this.tbxProductNameUpdate.TabIndex = 5;
            // 
            // lblQunatityPerUnit
            // 
            this.lblQunatityPerUnit.AutoSize = true;
            this.lblQunatityPerUnit.Location = new System.Drawing.Point(6, 133);
            this.lblQunatityPerUnit.Name = "lblQunatityPerUnit";
            this.lblQunatityPerUnit.Size = new System.Drawing.Size(59, 13);
            this.lblQunatityPerUnit.TabIndex = 4;
            this.lblQunatityPerUnit.Text = "Birim Adedi";
            // 
            // lblStockUpdate
            // 
            this.lblStockUpdate.AutoSize = true;
            this.lblStockUpdate.Location = new System.Drawing.Point(6, 106);
            this.lblStockUpdate.Name = "lblStockUpdate";
            this.lblStockUpdate.Size = new System.Drawing.Size(59, 13);
            this.lblStockUpdate.TabIndex = 3;
            this.lblStockUpdate.Text = "Stok Adedi";
            // 
            // lblUnitPriceUptade
            // 
            this.lblUnitPriceUptade.AutoSize = true;
            this.lblUnitPriceUptade.Location = new System.Drawing.Point(6, 75);
            this.lblUnitPriceUptade.Name = "lblUnitPriceUptade";
            this.lblUnitPriceUptade.Size = new System.Drawing.Size(29, 13);
            this.lblUnitPriceUptade.TabIndex = 2;
            this.lblUnitPriceUptade.Text = "Fiyat";
            // 
            // lblCategoryIdUpdate
            // 
            this.lblCategoryIdUpdate.AutoSize = true;
            this.lblCategoryIdUpdate.Location = new System.Drawing.Point(6, 45);
            this.lblCategoryIdUpdate.Name = "lblCategoryIdUpdate";
            this.lblCategoryIdUpdate.Size = new System.Drawing.Size(46, 13);
            this.lblCategoryIdUpdate.TabIndex = 1;
            this.lblCategoryIdUpdate.Text = "Kategori";
            // 
            // lblProductNameUpdate
            // 
            this.lblProductNameUpdate.AutoSize = true;
            this.lblProductNameUpdate.Location = new System.Drawing.Point(6, 16);
            this.lblProductNameUpdate.Name = "lblProductNameUpdate";
            this.lblProductNameUpdate.Size = new System.Drawing.Size(48, 13);
            this.lblProductNameUpdate.TabIndex = 0;
            this.lblProductNameUpdate.Text = "Ürün Adı";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(273, 361);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(185, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 589);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.gbxUptade);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbxNewProduct);
            this.Controls.Add(this.gbxProductName);
            this.Controls.Add(this.gbxCategroy);
            this.Controls.Add(this.dgwProduct);
            this.Name = "Form1";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.gbxCategroy.ResumeLayout(false);
            this.gbxCategroy.PerformLayout();
            this.gbxProductName.ResumeLayout(false);
            this.gbxProductName.PerformLayout();
            this.gbxNewProduct.ResumeLayout(false);
            this.gbxNewProduct.PerformLayout();
            this.gbxUptade.ResumeLayout(false);
            this.gbxUptade.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.GroupBox gbxCategroy;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.GroupBox gbxProductName;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.GroupBox gbxNewProduct;
        private System.Windows.Forms.Label lblQuantityPerUnit;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblCategoryID;
        private System.Windows.Forms.Label lblProductName2;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.TextBox tbxQuantityPerLimit;
        private System.Windows.Forms.TextBox tbxStock;
        private System.Windows.Forms.ComboBox cbxCategoryId;
        private System.Windows.Forms.TextBox tbxUnitPrice;
        private System.Windows.Forms.TextBox tbxProductName2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox gbxUptade;
        private System.Windows.Forms.TextBox tbxQuantityPerLimitUpdate;
        private System.Windows.Forms.TextBox tbxStockUpdate;
        private System.Windows.Forms.ComboBox cbxCategoryIdUpdate;
        private System.Windows.Forms.TextBox tbxUnitPriceUpdate;
        private System.Windows.Forms.TextBox tbxProductNameUpdate;
        private System.Windows.Forms.Label lblQunatityPerUnit;
        private System.Windows.Forms.Label lblStockUpdate;
        private System.Windows.Forms.Label lblUnitPriceUptade;
        private System.Windows.Forms.Label lblCategoryIdUpdate;
        private System.Windows.Forms.Label lblProductNameUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}

