using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodsAccountingPractice1
{
    public partial class ListSuppliersWindow : Form
    {

        public ListSuppliersWindow(Users authUser)
        {
            InitializeComponent();
           
            this.authUser = authUser;
                      
            listSuppliersGrid.EnableHeadersVisualStyles = false;
            listSuppliersGrid.Columns[0].HeaderCell.Style.ForeColor = Color.CornflowerBlue;
            listSuppliersGrid.Columns[1].HeaderCell.Style.ForeColor = Color.CornflowerBlue;
            listSuppliersGrid.Columns[2].HeaderCell.Style.ForeColor = Color.CornflowerBlue;
            listSuppliersGrid.Columns[3].HeaderCell.Style.ForeColor = Color.CornflowerBlue;
            listSuppliersGrid.Columns[4].HeaderCell.Style.ForeColor = Color.CornflowerBlue;

            exitBtn.FlatAppearance.BorderSize = 0;
            exitBtn.FlatStyle = FlatStyle.Flat;

            addBtn.FlatAppearance.BorderSize = 0;
            addBtn.FlatStyle = FlatStyle.Flat;

            editBtn.FlatAppearance.BorderSize = 0;
            editBtn.FlatStyle = FlatStyle.Flat;

            deleteBtn.FlatAppearance.BorderSize = 0;
            deleteBtn.FlatStyle = FlatStyle.Flat;

            lblUserName.Text = authUser.FirstName +" "+ authUser.LastName;
        }

        GoodsAccountingEntities db = Helper.GetContex();
        Users authUser;

        private void ListSuppliersWindow_Load(object sender, EventArgs e)
        {
            listSuppliersGrid.DataSource = db.Suppliers.ToList();

            listSuppliersGrid.Columns[0].HeaderText = "Id";
            listSuppliersGrid.Columns[1].HeaderText = "Название";
            listSuppliersGrid.Columns[2].HeaderText = "Адрес";
            listSuppliersGrid.Columns[3].HeaderText = "ИНН";
            listSuppliersGrid.Columns[4].HeaderText = "Телефон";
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddSuppliers form = new AddSuppliers();
            form.Show();
            this.Close();
        }

        private void deleteBtn_Click_1(object sender, EventArgs e)
        {
            int idSupp = int.Parse(listSuppliersGrid.CurrentRow.Cells[0].Value.ToString().Trim());

            var suppliers = db.Suppliers.Find(idSupp);
            db.Suppliers.Remove(suppliers);
            db.SaveChanges();
            listSuppliersGrid.DataSource = db.Suppliers.ToList();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
