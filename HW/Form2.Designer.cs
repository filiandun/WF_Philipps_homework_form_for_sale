namespace HW
{
    partial class Form2
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxProductName = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxProductDesciption = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBoxProductPrice = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.groupBoxProductName.SuspendLayout();
            this.groupBoxProductDesciption.SuspendLayout();
            this.groupBoxProductPrice.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(352, 261);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupBoxProductName
            // 
            this.groupBoxProductName.Controls.Add(this.textBox1);
            this.groupBoxProductName.Location = new System.Drawing.Point(13, 12);
            this.groupBoxProductName.Name = "groupBoxProductName";
            this.groupBoxProductName.Size = new System.Drawing.Size(415, 59);
            this.groupBoxProductName.TabIndex = 1;
            this.groupBoxProductName.TabStop = false;
            this.groupBoxProductName.Text = "Название";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(402, 20);
            this.textBox1.TabIndex = 0;
            // 
            // groupBoxProductDesciption
            // 
            this.groupBoxProductDesciption.Controls.Add(this.textBox2);
            this.groupBoxProductDesciption.Location = new System.Drawing.Point(13, 90);
            this.groupBoxProductDesciption.Name = "groupBoxProductDesciption";
            this.groupBoxProductDesciption.Size = new System.Drawing.Size(415, 59);
            this.groupBoxProductDesciption.TabIndex = 2;
            this.groupBoxProductDesciption.TabStop = false;
            this.groupBoxProductDesciption.Text = "Описание";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(7, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(402, 20);
            this.textBox2.TabIndex = 0;
            // 
            // groupBoxProductPrice
            // 
            this.groupBoxProductPrice.Controls.Add(this.textBox3);
            this.groupBoxProductPrice.Location = new System.Drawing.Point(12, 166);
            this.groupBoxProductPrice.Name = "groupBoxProductPrice";
            this.groupBoxProductPrice.Size = new System.Drawing.Size(415, 59);
            this.groupBoxProductPrice.TabIndex = 3;
            this.groupBoxProductPrice.TabStop = false;
            this.groupBoxProductPrice.Text = "Цена";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(7, 20);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(402, 20);
            this.textBox3.TabIndex = 0;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(12, 261);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "Готово";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 296);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBoxProductPrice);
            this.Controls.Add(this.groupBoxProductDesciption);
            this.Controls.Add(this.groupBoxProductName);
            this.Controls.Add(this.buttonCancel);
            this.MaximumSize = new System.Drawing.Size(456, 335);
            this.MinimumSize = new System.Drawing.Size(456, 335);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.groupBoxProductName.ResumeLayout(false);
            this.groupBoxProductName.PerformLayout();
            this.groupBoxProductDesciption.ResumeLayout(false);
            this.groupBoxProductDesciption.PerformLayout();
            this.groupBoxProductPrice.ResumeLayout(false);
            this.groupBoxProductPrice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBoxProductName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBoxProductDesciption;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBoxProductPrice;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonOK;
    }
}