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
    public partial class ListEmployeesWindow : Form
    {

        public ListEmployeesWindow(Users authUser)
        {
            InitializeComponent();

            this.authUser = authUser;

            listUsersGrid.EnableHeadersVisualStyles = false;
            listUsersGrid.Columns[0].HeaderCell.Style.ForeColor = Color.CornflowerBlue;
            listUsersGrid.Columns[1].HeaderCell.Style.ForeColor = Color.CornflowerBlue;
            listUsersGrid.Columns[2].HeaderCell.Style.ForeColor = Color.CornflowerBlue;
            listUsersGrid.Columns[3].HeaderCell.Style.ForeColor = Color.CornflowerBlue;
            listUsersGrid.Columns[4].HeaderCell.Style.ForeColor = Color.CornflowerBlue;
            listUsersGrid.Columns[5].HeaderCell.Style.ForeColor = Color.CornflowerBlue;
            listUsersGrid.Columns[6].HeaderCell.Style.ForeColor = Color.CornflowerBlue;
            listUsersGrid.Columns[7].HeaderCell.Style.ForeColor = Color.CornflowerBlue;
            listUsersGrid.Columns[8].HeaderCell.Style.ForeColor = Color.CornflowerBlue;
            listUsersGrid.Columns[9].HeaderCell.Style.ForeColor = Color.CornflowerBlue;

            lblUserName.Text = authUser.FirstName + " " + authUser.LastName;

            exitBtn.FlatAppearance.BorderSize = 0;
            exitBtn.FlatStyle = FlatStyle.Flat;

            addBtn.FlatAppearance.BorderSize = 0;
            addBtn.FlatStyle = FlatStyle.Flat;

            editBtn.FlatAppearance.BorderSize = 0;
            editBtn.FlatStyle = FlatStyle.Flat;

            deleteBtn.FlatAppearance.BorderSize = 0;
            deleteBtn.FlatStyle = FlatStyle.Flat;

            lblUserName.Text = authUser.FirstName + " " + authUser.LastName;
        }

        GoodsAccountingEntities db = Helper.GetContex();
        Users authUser;

        private void ListEmployeesWindow_Load(object sender, EventArgs e)
        {
            listUsersGrid.DataSource = db.Users.ToList();

            listUsersGrid.Columns[0].HeaderText = "Id";
            listUsersGrid.Columns[1].HeaderText = "Имя";
            listUsersGrid.Columns[2].HeaderText = "Фамилия";
            listUsersGrid.Columns[3].HeaderText = "Отчество";
            listUsersGrid.Columns[4].HeaderText = "Дата рождения";
            listUsersGrid.Columns[5].HeaderText = "Пол";
            listUsersGrid.Columns[6].HeaderText = "Телефон";
            listUsersGrid.Columns[7].HeaderText = "Логин";
            listUsersGrid.Columns[8].HeaderText = "Пароль";
            listUsersGrid.Columns[9].HeaderText = "Должность";

            listUsersGrid.Columns[0].Width = 30;
            listUsersGrid.Columns[1].Width = 70;
            listUsersGrid.Columns[2].Width = 80;
            listUsersGrid.Columns[3].Width = 90;
            listUsersGrid.Columns[4].Width = 90;
            listUsersGrid.Columns[5].Width = 60;
            listUsersGrid.Columns[6].Width = 90;
            listUsersGrid.Columns[7].Width = 90;
            listUsersGrid.Columns[8].Width = 90;
            listUsersGrid.Columns[9].Width = 70;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int idEmpl = int.Parse(listUsersGrid.CurrentRow.Cells[0].Value.ToString().Trim());

            var employees = db.Users.Find(idEmpl);
            db.Users.Remove(employees);
            db.SaveChanges();
            listUsersGrid.DataSource = db.Users.ToList();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddEmployee form = new AddEmployee();
            form.Show();
            this.Close();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            int idEmpl = int.Parse(listUsersGrid.CurrentRow.Cells[0].Value.ToString().Trim());
            var employee = db.Users.Find(idEmpl);

            EditEmployee editEmployee = new EditEmployee(employee);
            editEmployee.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
