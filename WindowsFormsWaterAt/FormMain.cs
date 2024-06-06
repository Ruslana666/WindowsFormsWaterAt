using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsWaterAt
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            CheckDefaultValues();
        }

        private void CheckDefaultValues()
        {
            using (ModelWaterAtrEnt context = new ModelWaterAtrEnt())
            {
                if (context.Services.Count() <= 0)
                {
                    context.Services.Add(new Services()
                    {
                        name = "Водная горка",
                        price = 1000,
                    });

                    context.Services.Add(new Services()
                    {
                        name = "Водные лыжи",
                        price = 2000,
                    });

                    context.Services.Add(new Services()
                    {
                        name = "Трамплин",
                        price = 3000,
                    });

                    context.Services.Add(new Services()
                    {
                        name = "Серфинг",
                        price = 4000,
                    });

                    context.Services.Add(new Services()
                    {
                        name = "Детская горка",
                        price = 5000,
                    });


                    context.SaveChanges();
                }

                if (context.Users.Count() <= 0)
                {
                    string[] fios = new string[] {
                        "Блохин Максим Иванович",
                        "Спиридонова Евгения Давидовна",
                        "Черкасова Ульяна Ивановна",
                        "Шилов Михаил Степанович",
                        "Серова Марьям Никитична",
                        "Владимиров Константин Маркович",
                        "Кузьмина Елизавета Игоревна",
                        "Комарова Кристина Артёмовна",
                        "Никитина Дарина Степановна",
                        "Дроздов Иван Даниилович"
                    };

                    context.Users.Add(new Users()
                    {
                        fio = "admin",
                        login = "admin",
                        password = "admin"
                    });

                    for (int i = 0; i < fios.Length; i++)
                    {
                        context.Users.Add(new Users()
                        {
                            fio = fios[i],
                            login = "user" + i,
                            password = new string(fios[i].Replace(" ", "").Reverse().ToArray()),
                        });
                    }

                    context.SaveChanges();
                }

                if (context.Tickets.Count() <= 0)
                {
                    var users = context.Users.ToList();

                    Random rdm = new Random();

                    for (int i = 0; i < 100; i++)
                    {
                        context.Tickets.Add(new Tickets()
                        {
                            idUser = users[rdm.Next(0, users.Count)].id,
                            timeCreated = DateTime.Now.AddDays(rdm.Next(1, 100) * -1),
                        });
                    }

                    context.SaveChanges();
                }

                if (context.TicketsInfo.Count() <= 0)
                {
                    Random rdm = new Random();
                    var allService = context.Services.ToList();
                    var allTickets = context.Tickets.ToList();

                    for (int i = 0; i < allTickets.Count; i++)
                    {
                        context.TicketsInfo.Add(new TicketsInfo()
                        {
                            idTicket = allTickets[i].id,
                            idService = allService[rdm.Next(0, allService.Count)].id,
                        });
                    }

                    context.SaveChanges();
                }

            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string login = textLogin.Text;
            string password = textPassword.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Поля не должны быть пустыми!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (ModelWaterAtrEnt context = new ModelWaterAtrEnt())
            {
                var user = context.Users.FirstOrDefault(x => x.login == login && x.password == password);
                if (user == null)
                {
                    MessageBox.Show("Неверный логин или пароль!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Global.AuthUser = user;
            }

            MessageBox.Show("Вы вошли!", "Хорошо!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            textLogin.Text = "";
            textPassword.Text = "";

            this.Hide();

            using (FormBilet form = new FormBilet())
            {
                if (form.ShowDialog() != DialogResult.OK)
                {
                    this.Show();
                    return;
                }
            }

            using (FormInfoBilet form = new FormInfoBilet())
            {
                form.ShowDialog();
            }

            this.Show();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            this.Hide();

            using (FormReg form = new FormReg())
            {
                form.ShowDialog(this);
            }

            this.Show();
        }
    }
}
