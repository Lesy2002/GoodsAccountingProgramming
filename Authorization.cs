using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GoodsAccountingPractice1
{
    public partial class Authorization : Form
    {
        GoodsAccountingEntities db = Helper.GetContex();
        
        public Authorization()
        {
            InitializeComponent();

            entranceBtn.FlatAppearance.BorderSize = 0;
            entranceBtn.FlatStyle = FlatStyle.Flat;

            this.KeyPreview = true;
        }

        private void entranceBtn_Click(object sender, EventArgs e)
        {
            GoodsAccountingEntities db = Helper.GetContex();

            if (loginBox.Text == "" || passwordBox.Text == "")
            {
                MessageBox.Show(this, "Не заполненно одно из полей!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var user = db.Users.Where(u => u.Login == loginBox.Text).FirstOrDefault();

                if (user.Password == passwordBox.Text && user.Login == loginBox.Text)
                {
                    switch (user.IdRole)
                    {
                        case 1:
                            MenuAdmin form = new MenuAdmin(user);
                            form.Show();
                            this.Hide();
                            break;

                        case 2:
                            InvoiceList f = new InvoiceList(user);
                            f.Show();
                            this.Hide();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Не верно введён логин или пароль!");
                }
            }
        }

        private void Authorization_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }
    }
}
