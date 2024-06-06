using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsWaterAt
{
    public static class Global
    {
        public static Users AuthUser { get; set; }

        public static Tickets CurrentTicket { get; set; }

        public static void InvokeControl(Control control, Action method)
        {
            if (control.IsHandleCreated) control.Invoke(method);
            else method();
        }
    }
}
