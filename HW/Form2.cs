using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW
{
    public partial class Form2 : Form
    {
        Product product;

        public Form2() // для добавления нового товара
        {
            InitializeComponent();

            this.product = null;
        }

        public Form2(Product product) // для изменение существующего товара
        {
            InitializeComponent();

            this.product = product;

            this.textBox1.Text = product.Name; // это всё нужно, чтобы в полях редактирования товара отображались предыдущие значения (типо действительно редактируется)
            this.textBox2.Text = product.Description; //
            this.textBox3.Text = Convert.ToString(product.Price); // 
        }

        public Product Product
        {
            get
            {
                return this.product;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.textBox1.Text) && !String.IsNullOrEmpty(this.textBox2.Text) && !String.IsNullOrEmpty(this.textBox3.Text)) // проверка на не пустоту строк
            {
                this.product = new Product(this.textBox1.Text, this.textBox2.Text, Convert.ToDouble(this.textBox3.Text));

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Ошибка, заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
