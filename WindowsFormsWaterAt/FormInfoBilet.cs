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
    public partial class FormInfoBilet : Form
    {
        public FormInfoBilet()
        {
            InitializeComponent();

            Global.InvokeControl(labelId, () => { labelId.Text = Global.CurrentTicket.id.ToString(); });

            UpdateServices();
        }

        private void UpdateServices()
        {
            checkListServices.ClearSelected();
            checkListServices.Items.Clear();

            int totalSum = 0;

            using (ModelWaterAtrEnt context = new ModelWaterAtrEnt())
            {
                var ticket = context.Tickets.FirstOrDefault(x => x.id == Global.CurrentTicket.id);

                foreach (var tInfo in ticket.TicketsInfo.ToArray())
                {
                    checkListServices.Items.Add(tInfo.Services);
                    totalSum += tInfo.Services.price;
                }

                labelDate.Text = ticket.timeCreated.ToString("dd-MM-yyyy HH:mm:ss");
            }

            for (int i = 0; i < checkListServices.Items.Count; i++)
            {
                checkListServices.SetItemChecked(i, true);
                checkListServices.SetItemCheckState(i, CheckState.Indeterminate);
            }

            Global.InvokeControl(labelSum, () => { labelSum.Text = $"{totalSum} руб."; });
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
