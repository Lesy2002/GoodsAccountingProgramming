using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodsAccountingPractice1
{
    public partial class EditEmployee : Form
    {
        GoodsAccountingEntities db = Helper.GetContex();
        Users editEmploye;

        public EditEmployee(Users users)
        {
            InitializeComponent();

            editEmploye = users;

            editBtn.FlatAppearance.BorderSize = 0;
            editBtn.FlatStyle = FlatStyle.Flat;

            backBtn.FlatAppearance.BorderSize = 0;
            backBtn.FlatStyle = FlatStyle.Flat;

            this.KeyPreview = true;

            var list = db.Role;
            foreach (Role role in list)
                roleBox.Items.Add(role.Title);

            roleBox.Text = editEmploye.Role.Title;
            roleBox.SelectedIndex = editEmploye.IdRole - 1;
            nameBox.Text = editEmploye.FirstName;
            lastnameBox.Text = editEmploye.LastName;
            patronymicBox.Text = editEmploye.Patronymic;
            dateOfBirth.Value = editEmploye.DateOfBirhday;
            genderBox.Text = editEmploye.Gender;
            telephoneBox.Text = editEmploye.Telephone;
            loginBox.Text = editEmploye.Login;
            passwordBox.Text = editEmploye.Password;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            editEmploye.FirstName = nameBox.Text;
            editEmploye.LastName = lastnameBox.Text;
            editEmploye.Patronymic = patronymicBox.Text;
            editEmploye.DateOfBirhday = dateOfBirth.Value;
            editEmploye.Gender = genderBox.Text;
            editEmploye.Telephone = telephoneBox.Text;
            editEmploye.Login = loginBox.Text;
            editEmploye.Password = passwordBox.Text;
            editEmploye.IdRole = roleBox.SelectedIndex + 1;

            db.Entry(editEmploye).State = EntityState.Modified;
            db.SaveChanges();

            MessageBox.Show(this, "Данные успешно сохранены!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EditEmployee_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }
    }
}
