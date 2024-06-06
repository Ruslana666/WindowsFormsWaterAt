using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsWaterAt
{
    public partial class FormReg : Form
    {
        public FormReg()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textFam.Text) ||
                string.IsNullOrEmpty(textName.Text) ||
                string.IsNullOrEmpty(textOtch.Text) ||
                string.IsNullOrEmpty(textLogin.Text) ||
                string.IsNullOrEmpty(textPassword.Text))
            {
                MessageBox.Show("Поля не должны быть пустыми!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (ModelWaterAtrEnt context = new ModelWaterAtrEnt())
            {
                var foundUser = context.Users.FirstOrDefault(x => x.login == textLogin.Text);

                if (foundUser != null)
                {
                    MessageBox.Show("Пользователь с таким логином уже существует! Попробуйте другой!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                context.Users.Add(new Users()
                {
                    fio = $"{textFam.Text} {textName.Text} {textOtch.Text}",
                    login = textLogin.Text,
                    password = textPassword.Text,
                });
                context.SaveChanges();
            }

            MessageBox.Show("Вы успешно зарегистрировались!", "Хорошо!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
