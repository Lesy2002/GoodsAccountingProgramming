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
    public partial class InvoiceList : Form
    {
        GoodsAccountingEntities db = Helper.GetContex();

        Users authuser;

        public InvoiceList(Users user)
        {
            InitializeComponent();

            InvoicesGrid.DataSource = db.Invoice.ToList();

            InvoicesGrid.EnableHeadersVisualStyles = false;
            InvoicesGrid.Columns[0].HeaderCell.Style.ForeColor = Color.CornflowerBlue;
            InvoicesGrid.Columns[1].HeaderCell.Style.ForeColor = Color.CornflowerBlue;
            InvoicesGrid.Columns[2].HeaderCell.Style.ForeColor = Color.CornflowerBlue;

            exitBtn.FlatAppearance.BorderSize = 0;
            exitBtn.FlatStyle = FlatStyle.Flat;

            addBtn.FlatAppearance.BorderSize = 0;
            addBtn.FlatStyle = FlatStyle.Flat;

            openBtn.FlatAppearance.BorderSize = 0;
            openBtn.FlatStyle = FlatStyle.Flat;
        }

        private void InvoiceList_Load(object sender, EventArgs e)
        {
            InvoicesGrid.Columns[0].HeaderText = "Id";
            InvoicesGrid.Columns[1].HeaderText = "Дата оформления";
            InvoicesGrid.Columns[2].HeaderText = "Id поставщика";

            this.InvoicesGrid.Columns[3].Visible = false;
            this.InvoicesGrid.Columns[4].Visible = false;
            this.InvoicesGrid.Columns[5].Visible = false;
            this.InvoicesGrid.Columns[6].Visible = false;
            this.InvoicesGrid.Columns[7].Visible = false;
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            int idInv = int.Parse(InvoicesGrid.CurrentRow.Cells[0].Value.ToString().Trim());
            var invoices = db.Invoice.Find(idInv);

            

            InvoicesWindow fm = new InvoicesWindow(invoices);
            fm.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Authorization fm = new Authorization();
            fm.Show();
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddInvoices form = new AddInvoices(this);
            form.Show();
        }
    }
}
