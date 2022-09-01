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
    public partial class ProductAdd : Form
    {
        GoodsAccountingEntities db = Helper.GetContex();
        InvoicesWindow InvoicesWindow;
        int idInvoce;
        public ProductAdd(int IdInvoce, InvoicesWindow invoicesWindow)
        {
            InitializeComponent();
            idInvoce = IdInvoce;
            InvoicesWindow = invoicesWindow;
            var list = db.GoodsDirectory;
            foreach (GoodsDirectory goods in list)
                titleBox.Items.Add(goods.Title);

            addBtn.FlatAppearance.BorderSize = 0;
            addBtn.FlatStyle = FlatStyle.Flat;

            editBtn.FlatAppearance.BorderSize = 0;
            editBtn.FlatStyle = FlatStyle.Flat;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            InvoiceGoodsList newproduct = new InvoiceGoodsList();
            newproduct.IdInvoice = idInvoce;
            newproduct.AmountProduct = countBox.Text;
            newproduct.IdProduct = titleBox.SelectedIndex + 1;
            db.InvoiceGoodsList.Add(newproduct);
            db.SaveChanges();
            MessageBox.Show(this, "Товар успешно добавлен!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            InvoicesWindow.productGrid.DataSource = db.InvoiceGoodsList.Where(x => x.IdInvoice == idInvoce).ToList();

        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
