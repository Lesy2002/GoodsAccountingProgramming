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
    public partial class MenuAdmin : Form
    {
        Users authUser;
        public MenuAdmin(Users user)
        {
            InitializeComponent();

            listEmployeesBtn.FlatAppearance.BorderSize = 0;
            listEmployeesBtn.FlatStyle = FlatStyle.Flat;

            listSuppliersBtn.FlatAppearance.BorderSize = 0;
            listSuppliersBtn.FlatStyle = FlatStyle.Flat;
            authUser = user;
        }

        private void addSuppliersBtn_Click(object sender, EventArgs e)
        {
            AddSuppliers form = new AddSuppliers();
            form.Show();
        }

        private void listSuppliersBtn_Click(object sender, EventArgs e)
        {
            ListSuppliersWindow form = new ListSuppliersWindow(authUser);
            form.Show();
        }

        private void entranceBtn_Click_1(object sender, EventArgs e)
        {
            Authorization form = new Authorization();
            form.Show();
            this.Close();
        }

        private void MenuAdmin_Load(object sender, EventArgs e)
        {

        }

        private void listEmployeesBtn_Click(object sender, EventArgs e)
        {
            ListEmployeesWindow form = new ListEmployeesWindow(authUser);
            form.Show();
        }
    }
}
