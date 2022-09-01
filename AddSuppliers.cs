using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodsAccountingPractice1
{
    public partial class AddSuppliers : Form
    {
        GoodsAccountingEntities db = Helper.GetContex();

        public AddSuppliers()
        {
            InitializeComponent();

            addBtn.FlatAppearance.BorderSize = 0;
            addBtn.FlatStyle = FlatStyle.Flat;

            backBtn.FlatAppearance.BorderSize = 0;
            backBtn.FlatStyle = FlatStyle.Flat;

            this.KeyPreview = true;
        }

        private void AddSuppliers_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Suppliers newSuppliers = new Suppliers();

            newSuppliers.Title = titleBox.Text;
            newSuppliers.Address = addressBox.Text;
            newSuppliers.Inn = innBox.Text;
            newSuppliers.Telephone = telephoneBox.Text;

            db.Suppliers.Add(newSuppliers);
            db.SaveChanges();

            if (titleBox.Text == "")
            {
                MessageBox.Show(this, "Поле ''Название поставщика'' не заполнено!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(this, "Поставщик успешно добавлен!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
