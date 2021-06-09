using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Museo_pictorico_ppai.utils
{
    class ValidateTextBox
    {
        public void validateSoloLetras(object sender, KeyPressEventArgs v)
        {
            if (Char.IsLetter(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;


            }

        }


        public void ValidateSoloNumeros(object sender, KeyPressEventArgs v)
        {
            if (Char.IsDigit(v.KeyChar))
            {
                v.Handled = false;

            }
            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;


            }


        }

        public void validateLetrasNumeros(object sender, KeyPressEventArgs v)
        {
            if (Char.IsLetterOrDigit(v.KeyChar))
            {
                v.Handled = false;

            }
            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;


            }

        }

    }
}
