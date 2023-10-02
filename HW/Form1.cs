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
    public partial class Form1 : Form
    {
        List<Product> products;

        public Form1()
        {
            InitializeComponent();

            this.products = new List<Product>();

            this.products.Add(new Product("Процессор Intel Core i3 13100f", "LGA 1700, OEM", 8990.0));
            this.products.Add(new Product("Процессор Intel Core i5 13400f", "LGA 1700, OEM", 12990.0));
            this.products.Add(new Product("Процессор Intel Core i7 13700kf", "LGA 1700, OEM", 23590.0));

            this.products.Add(new Product("Мать. плата DEXP H610M-HSV", "LGA 1700, Micro-ATX", 6390.0));
            this.products.Add(new Product("Мать. плата ASUS PRIME H610I-PLUS", "LGA 1700, Mini-ATX", 11790.0));
            this.products.Add(new Product("Мать. плата MSI Z790 GAMING PRO", "LGA 1700, Standart-ATX", 25990.0));

            foreach (Product p in products)
            {
                this.comboBoxProducts.Items.Add(p);
            }
        }



        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            int selectedIndex = this.comboBoxProducts.SelectedIndex;

            if (selectedIndex != -1)
            {
                this.listBoxCart.Items.Add($"{this.comboBoxProducts.SelectedItem}");
            }
            else
            {
                MessageBox.Show("Хотите добавить пустоту?\n\nЭто риторический вопрос.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDeleteFromCart_Click(object sender, EventArgs e)
        {
            if (this.listBoxCart.SelectedItems.Count > 0)
            {
                this.listBoxCart.Items.Remove(this.listBoxCart.SelectedItem);
            }
        }

        private void buttonClearCart_Click(object sender, EventArgs e)
        {
            if (this.listBoxCart.Items.Count != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите очистить всё корзину?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    this.listBoxCart.Items.Clear();
                }
            }
        }



        private void buttonAddNewProduct_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); // новая форма с новым товаром

            if (form2.ShowDialog() == DialogResult.OK)
            {
                this.products.Add(form2.Product); // добавляется новый товар в список товаров

                this.listBoxCart.Items.Add(form2.Product); // добавляется новый товар в спиcок в listBox
            }
        }

        private void buttonEditProduct_Click(object sender, EventArgs e)
        {
            int selectedIndex = this.comboBoxProducts.SelectedIndex; // индекс выбранного товара в listBox

            if (selectedIndex != -1)
            {
                Form2 form2 = new Form2(this.products[selectedIndex]); // новая форма с выбранным товаром из списка товаров

                if (form2.ShowDialog() == DialogResult.OK)
                {
                    this.products.RemoveAt(selectedIndex); // удаляется предыдущий товар из списка товаров
                    this.products.Insert(selectedIndex, form2.Product); // добавляется измененный товар по индексу в список товаров

                    this.comboBoxProducts.Items.RemoveAt(selectedIndex); // удаляется товар из списка в listBox
                    this.comboBoxProducts.Items.Insert(selectedIndex, form2.Product); // добавляется измененный товар в список в listBox
                }
            }

            this.comboBoxProducts.SelectedIndex = selectedIndex; // возвращается курсор на выделенный элемент
                                                         // (так как он сместится на другой: ведь фактически товар не редактируется, а заменяется на новый)
        }

        private void comboBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textBoxPriceOfOneProduct.Text = this.products[this.comboBoxProducts.SelectedIndex].Price.ToString();
        }

        private void buttonPunchCheck_Click(object sender, EventArgs e)
        {
            // НУЖНО ПЕРЕДЕЛАТЬ, ЧТОБЫ БЫЛО ДВА СПИСКА С ТОВАРАМИ, ОДИН ПОД КОРЗИНУ, ДРУГОЙ ПОД СПИСОК ТОВАРОВ
        }
    }
}
