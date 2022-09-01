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
    public partial class InvoicesWindow : Form
    {
        GoodsAccountingEntities db = Helper.GetContex();

        Invoice invoic;

        public InvoicesWindow(Invoice invoice)
        {
            InitializeComponent();

            invoic = invoice;

            datelbl.Text = invoic.ReceiptDate.ToString();
            Idlbl.Text = invoic.IdInvoice.ToString();
            supplbl.Text = invoic.Suppliers.Title;

            productGrid.DataSource = db.InvoiceGoodsList.Where(x=>x.IdInvoice == invoic.IdInvoice).ToList();

            productGrid.EnableHeadersVisualStyles = false;
            productGrid.Columns[0].HeaderCell.Style.ForeColor = Color.CornflowerBlue;
            productGrid.Columns[1].HeaderCell.Style.ForeColor = Color.CornflowerBlue;
            productGrid.Columns[2].HeaderCell.Style.ForeColor = Color.CornflowerBlue;
            productGrid.Columns[3].HeaderCell.Style.ForeColor = Color.CornflowerBlue;

            exitBtn.FlatAppearance.BorderSize = 0;
            exitBtn.FlatStyle = FlatStyle.Flat;

            addBtn.FlatAppearance.BorderSize = 0;
            addBtn.FlatStyle = FlatStyle.Flat;
        }

        private void InvoicesWindow_Load(object sender, EventArgs e)
        {
            productGrid.DataSource = db.InvoiceGoodsList.ToList();

            productGrid.Columns[0].HeaderText = "Id";
            productGrid.Columns[1].HeaderText = "Id накладной";
            productGrid.Columns[2].HeaderText = "Id товара";
            productGrid.Columns[3].HeaderText = "Количество";
            
            this.productGrid.Columns[4].Visible = false;
            this.productGrid.Columns[5].Visible = false;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            ProductAdd prAdd = new ProductAdd(invoic.IdInvoice, this);
            prAdd.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
