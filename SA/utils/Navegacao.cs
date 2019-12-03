using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA.utils
{
    public class Navegacao
    {
        public static void voltar(Form origem)
        {
            new TelaLogin().Show();
            origem.Visible = false;
        }

        public static void voltarDashboard(Form origem)
        {
            new TelaDashboard().Show();
            origem.Visible = false;
        }
    }
}
