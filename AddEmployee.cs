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
    public partial class AddEmployee : Form
    {
        GoodsAccountingEntities db = Helper.GetContex();

        public AddEmployee()
        {
            InitializeComponent();

            addBtn.FlatAppearance.BorderSize = 0;
            addBtn.FlatStyle = FlatStyle.Flat;

            backBtn.FlatAppearance.BorderSize = 0;
            backBtn.FlatStyle = FlatStyle.Flat;

            this.KeyPreview = true;

            var list = db.Role;
            foreach (Role role in list)
                roleBox.Items.Add(role.Title);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddEmployee_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Users newUsers = new Users();

            newUsers.FirstName = nameBox.Text;
            newUsers.LastName = lastnameBox.Text;
            newUsers.Patronymic = patronymicBox.Text;
            newUsers.DateOfBirhday = dateOfBirth.Value;
            if (genderBox.SelectedText == "")
            {
                newUsers.Gender = "жен";
            }
            else
            {
                newUsers.Gender = "муж";
            }
            newUsers.Telephone = telephoneBox.Text;
            newUsers.Login = loginBox.Text;
            newUsers.Password = passwordBox.Text;
            newUsers.IdRole = roleBox.SelectedIndex + 1;

            db.Users.Add(newUsers);
            db.SaveChanges();

            MessageBox.Show(this, "Сотрудник успешно добавлен!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
