using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA.utils
{
    public class ValidarTextbox
    {
        public static void removeEspecial(object sender, KeyPressEventArgs e)
        {
            Regex reg = new Regex(@"[^a-zA-Z0-9\s]");
            if (reg.IsMatch(e.KeyChar.ToString()) && e.KeyChar != 08) //NUMERO E LETRA
            {
                e.Handled = true;
            }
        }
        public static void validarTexto(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-zA-ZéúíóáÉÚÍÓÁèùìòàÈÙÌÒÀõãñÕÃÑêûîôâÊÛÎÔÂëÿüïöäËYÜÏÖÄçÇ \s]"); //TODOS TEXTOS MENOS NUMERO
            if (regex.IsMatch(e.KeyChar.ToString()) && e.KeyChar != 08)
            {
                e.Handled = true;
                MessageBox.Show("São aceitas somente letras!");
            }
        }
        public static void validarNumero(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^Z0-9\s]");
            if (regex.IsMatch(e.KeyChar.ToString()) && e.KeyChar != 08 && e.KeyChar != ',') //com virgula
            {
                e.Handled = true;
                MessageBox.Show("São aceitos apenas números!");
            }
        }
    }
}
