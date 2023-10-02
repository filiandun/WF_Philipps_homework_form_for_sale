namespace HW
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxCart = new System.Windows.Forms.ListBox();
            this.groupBoxCart = new System.Windows.Forms.GroupBox();
            this.buttonClearCart = new System.Windows.Forms.Button();
            this.buttonDeleteFromCart = new System.Windows.Forms.Button();
            this.groupBoxProducts = new System.Windows.Forms.GroupBox();
            this.textBoxPriceOfOneProduct = new System.Windows.Forms.TextBox();
            this.buttonAddNewProduct = new System.Windows.Forms.Button();
            this.buttonEditProduct = new System.Windows.Forms.Button();
            this.buttonAddToCart = new System.Windows.Forms.Button();
            this.comboBoxProducts = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonPunchCheck = new System.Windows.Forms.Button();
            this.labelRub = new System.Windows.Forms.Label();
            this.labelPriceOfOneProduct = new System.Windows.Forms.Label();
            this.groupBoxCart.SuspendLayout();
            this.groupBoxProducts.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxCart
            // 
            this.listBoxCart.FormattingEnabled = true;
            this.listBoxCart.Location = new System.Drawing.Point(6, 19);
            this.listBoxCart.Name = "listBoxCart";
            this.listBoxCart.Size = new System.Drawing.Size(409, 238);
            this.listBoxCart.TabIndex = 0;
            // 
            // groupBoxCart
            // 
            this.groupBoxCart.Controls.Add(this.buttonClearCart);
            this.groupBoxCart.Controls.Add(this.buttonDeleteFromCart);
            this.groupBoxCart.Controls.Add(this.listBoxCart);
            this.groupBoxCart.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCart.Name = "groupBoxCart";
            this.groupBoxCart.Size = new System.Drawing.Size(421, 291);
            this.groupBoxCart.TabIndex = 1;
            this.groupBoxCart.TabStop = false;
            this.groupBoxCart.Text = "Корзина";
            // 
            // buttonClearCart
            // 
            this.buttonClearCart.Location = new System.Drawing.Point(296, 263);
            this.buttonClearCart.Name = "buttonClearCart";
            this.buttonClearCart.Size = new System.Drawing.Size(119, 23);
            this.buttonClearCart.TabIndex = 2;
            this.buttonClearCart.Text = "Очистить корзину";
            this.buttonClearCart.UseVisualStyleBackColor = true;
            this.buttonClearCart.Click += new System.EventHandler(this.buttonClearCart_Click);
            // 
            // buttonDeleteFromCart
            // 
            this.buttonDeleteFromCart.Location = new System.Drawing.Point(6, 262);
            this.buttonDeleteFromCart.Name = "buttonDeleteFromCart";
            this.buttonDeleteFromCart.Size = new System.Drawing.Size(119, 23);
            this.buttonDeleteFromCart.TabIndex = 1;
            this.buttonDeleteFromCart.Text = "Удалить выбранные";
            this.buttonDeleteFromCart.UseVisualStyleBackColor = true;
            this.buttonDeleteFromCart.Click += new System.EventHandler(this.buttonDeleteFromCart_Click);
            // 
            // groupBoxProducts
            // 
            this.groupBoxProducts.Controls.Add(this.labelRub);
            this.groupBoxProducts.Controls.Add(this.labelPriceOfOneProduct);
            this.groupBoxProducts.Controls.Add(this.textBoxPriceOfOneProduct);
            this.groupBoxProducts.Controls.Add(this.buttonAddNewProduct);
            this.groupBoxProducts.Controls.Add(this.buttonEditProduct);
            this.groupBoxProducts.Controls.Add(this.buttonAddToCart);
            this.groupBoxProducts.Controls.Add(this.comboBoxProducts);
            this.groupBoxProducts.Location = new System.Drawing.Point(685, 12);
            this.groupBoxProducts.Name = "groupBoxProducts";
            this.groupBoxProducts.Size = new System.Drawing.Size(398, 289);
            this.groupBoxProducts.TabIndex = 2;
            this.groupBoxProducts.TabStop = false;
            this.groupBoxProducts.Text = "Выбрать существующий товар";
            // 
            // textBoxPriceOfOneProduct
            // 
            this.textBoxPriceOfOneProduct.Location = new System.Drawing.Point(79, 54);
            this.textBoxPriceOfOneProduct.Name = "textBoxPriceOfOneProduct";
            this.textBoxPriceOfOneProduct.ReadOnly = true;
            this.textBoxPriceOfOneProduct.Size = new System.Drawing.Size(279, 20);
            this.textBoxPriceOfOneProduct.TabIndex = 0;
            // 
            // buttonAddNewProduct
            // 
            this.buttonAddNewProduct.Location = new System.Drawing.Point(7, 233);
            this.buttonAddNewProduct.Name = "buttonAddNewProduct";
            this.buttonAddNewProduct.Size = new System.Drawing.Size(384, 23);
            this.buttonAddNewProduct.TabIndex = 5;
            this.buttonAddNewProduct.Text = "Добавить новый";
            this.buttonAddNewProduct.UseVisualStyleBackColor = true;
            this.buttonAddNewProduct.Click += new System.EventHandler(this.buttonAddNewProduct_Click);
            // 
            // buttonEditProduct
            // 
            this.buttonEditProduct.Location = new System.Drawing.Point(7, 260);
            this.buttonEditProduct.Name = "buttonEditProduct";
            this.buttonEditProduct.Size = new System.Drawing.Size(384, 23);
            this.buttonEditProduct.TabIndex = 4;
            this.buttonEditProduct.Text = "Изменить выбранный";
            this.buttonEditProduct.UseVisualStyleBackColor = true;
            this.buttonEditProduct.Click += new System.EventHandler(this.buttonEditProduct_Click);
            // 
            // buttonAddToCart
            // 
            this.buttonAddToCart.Location = new System.Drawing.Point(6, 80);
            this.buttonAddToCart.Name = "buttonAddToCart";
            this.buttonAddToCart.Size = new System.Drawing.Size(386, 23);
            this.buttonAddToCart.TabIndex = 3;
            this.buttonAddToCart.Text = "Добавить в корзину";
            this.buttonAddToCart.UseVisualStyleBackColor = true;
            this.buttonAddToCart.Click += new System.EventHandler(this.buttonAddToCart_Click);
            // 
            // comboBoxProducts
            // 
            this.comboBoxProducts.FormattingEnabled = true;
            this.comboBoxProducts.Location = new System.Drawing.Point(7, 20);
            this.comboBoxProducts.Name = "comboBoxProducts";
            this.comboBoxProducts.Size = new System.Drawing.Size(384, 21);
            this.comboBoxProducts.TabIndex = 0;
            this.comboBoxProducts.SelectedIndexChanged += new System.EventHandler(this.comboBoxProducts_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Location = new System.Drawing.Point(439, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 46);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Цена за всё";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(228, 20);
            this.textBox2.TabIndex = 1;
            // 
            // buttonPunchCheck
            // 
            this.buttonPunchCheck.Location = new System.Drawing.Point(446, 31);
            this.buttonPunchCheck.Name = "buttonPunchCheck";
            this.buttonPunchCheck.Size = new System.Drawing.Size(228, 39);
            this.buttonPunchCheck.TabIndex = 3;
            this.buttonPunchCheck.Text = "Пробить чек";
            this.buttonPunchCheck.UseVisualStyleBackColor = true;
            this.buttonPunchCheck.Click += new System.EventHandler(this.buttonPunchCheck_Click);
            // 
            // labelRub
            // 
            this.labelRub.AutoSize = true;
            this.labelRub.Location = new System.Drawing.Point(364, 57);
            this.labelRub.Name = "labelRub";
            this.labelRub.Size = new System.Drawing.Size(27, 13);
            this.labelRub.TabIndex = 7;
            this.labelRub.Text = "руб.";
            // 
            // labelPriceOfOneProduct
            // 
            this.labelPriceOfOneProduct.AutoSize = true;
            this.labelPriceOfOneProduct.Location = new System.Drawing.Point(6, 57);
            this.labelPriceOfOneProduct.Name = "labelPriceOfOneProduct";
            this.labelPriceOfOneProduct.Size = new System.Drawing.Size(67, 13);
            this.labelPriceOfOneProduct.TabIndex = 6;
            this.labelPriceOfOneProduct.Text = "Цена за шт.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 314);
            this.Controls.Add(this.buttonPunchCheck);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxProducts);
            this.Controls.Add(this.groupBoxCart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxCart.ResumeLayout(false);
            this.groupBoxProducts.ResumeLayout(false);
            this.groupBoxProducts.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCart;
        private System.Windows.Forms.GroupBox groupBoxCart;
        private System.Windows.Forms.Button buttonClearCart;
        private System.Windows.Forms.Button buttonDeleteFromCart;
        private System.Windows.Forms.GroupBox groupBoxProducts;
        private System.Windows.Forms.Button buttonAddNewProduct;
        private System.Windows.Forms.Button buttonEditProduct;
        private System.Windows.Forms.Button buttonAddToCart;
        private System.Windows.Forms.ComboBox comboBoxProducts;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonPunchCheck;
        private System.Windows.Forms.TextBox textBoxPriceOfOneProduct;
        private System.Windows.Forms.Label labelRub;
        private System.Windows.Forms.Label labelPriceOfOneProduct;
    }
}

