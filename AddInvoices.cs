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
    public partial class AddInvoices : Form
    {
        GoodsAccountingEntities db = Helper.GetContex();
       
        InvoiceList InvoiceList;
        public AddInvoices(InvoiceList invoiceList)
        {
            InitializeComponent();
            
            InvoiceList = invoiceList;
           
            addBtn.FlatAppearance.BorderSize = 0;
            addBtn.FlatStyle = FlatStyle.Flat;

            cancelBtn.FlatAppearance.BorderSize = 0;
            cancelBtn.FlatStyle = FlatStyle.Flat;

            var list = db.Suppliers;
            foreach (Suppliers suppliers in list)
                supCmb.Items.Add(suppliers.Title);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Invoice newinvoice = new Invoice();

            newinvoice.ReceiptDate = ReceiptDateCmb.Value;
            
            newinvoice.IdSuppliers = supCmb.SelectedIndex + 13;
            
            db.Invoice.Add(newinvoice);
            db.SaveChanges();
            InvoiceList.InvoicesGrid.DataSource = db.Invoice.ToList();
            
            MessageBox.Show(this, "Накладная успешно добавлена!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
