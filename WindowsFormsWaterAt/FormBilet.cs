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
    public partial class FormBilet : Form
    {
        private int _totalSum = 0;

        public FormBilet()
        {
            InitializeComponent();
            checkListServices.ClearSelected();

            labelFio.Text = Global.AuthUser.fio;

            UpdateServices();

            Global.InvokeControl(labelSum, () => { labelSum.Text = $"{_totalSum} руб."; });
        }

        private void UpdateServices()
        {
            checkListServices.ClearSelected();
            checkListServices.Items.Clear();

            using (ModelWaterAtrEnt context = new ModelWaterAtrEnt())
            {
                foreach (var service in context.Services.ToArray())
                {
                    checkListServices.Items.Add(service);
                }
            }
        }

        private void CalcSum(bool check, int value)
        {
            if (check) _totalSum += value;
            else _totalSum -= value;

            Global.InvokeControl(labelSum, () => { labelSum.Text = $"{_totalSum} руб."; });
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (_totalSum <= 0)
            {
                MessageBox.Show("Нужно что-то выбрать!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(mTextCard1.Text) ||
                string.IsNullOrEmpty(mTextCard2.Text) ||
                string.IsNullOrEmpty(mTextCard3.Text) ||
                string.IsNullOrEmpty(mTextCard4.Text) ||

                string.IsNullOrEmpty(mTextDate.Text) ||
                string.IsNullOrEmpty(mTextCVV.Text))
            {
                MessageBox.Show("Данные карты не до конца заполнены!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Вы уверены что хотите купить этот билет?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No) return;

            using (ModelWaterAtrEnt context = new ModelWaterAtrEnt())
            {
                List<Services> services = new List<Services>();

                for (int i = 0; i < checkListServices.Items.Count; i++)
                {
                    if (!checkListServices.GetItemChecked(i)) continue;
                    services.Add(((Services)checkListServices.Items[i]));
                }

                Tickets ticket = new Tickets()
                {
                    idUser = Global.AuthUser.id,
                    timeCreated = DateTime.Now,
                };

                context.Tickets.Add(ticket);
                context.SaveChanges();

                for (int i = 0; i < services.Count; i++)
                {
                    context.TicketsInfo.Add(new TicketsInfo()
                    {
                        idTicket = ticket.id,
                        idService = services[i].id,
                    });
                }

                Global.CurrentTicket = ticket;

                context.SaveChanges();
            }

            MessageBox.Show("Вы купили билет!", "Хорошо!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void checkListServices_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Console.WriteLine($"{e.NewValue}, {e.Index}, {e.CurrentValue}");
            Services service = ((Services)checkListServices.Items[e.Index]);
            CalcSum(e.NewValue == CheckState.Checked, service.price);
            
        }
    }
}
