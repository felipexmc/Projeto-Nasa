using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nasa.Classes
{
    class ControlChar
    {
        /*Este metódo faz:
        * 
        * - Pega o valor digitado no teclado pelo o usuário e filtra só deixando,
        *   ser inserido em um componente valores que forem passados pelo parametro x
        *   
        * - Pega o valor digitado no teclado pelo o usuário e se ele for o botão enter,
        *   ele iria clicar em um componente Button passado por parâmetro
        *   
        * - Ele tem como parametro:
        *   x(Guarda tudo aquilo que poderá ser digitado em um componente pelo usuário)
        *   e(Guarda a tecla pressionada pelo usuario).
        *   btn(Guarda o botão que será clicado caso o usuário digite enter).
        * 
        */
        public static void txtUsar(string x, KeyPressEventArgs e, Button btn)
        {
            if (!(x.Contains(e.KeyChar.ToString().ToUpper())) && e.KeyChar != 08 && e.KeyChar != (char)Keys.Enter)
            {
                e.Handled = true;
                MessageBox.Show("Digito invalido, por favor tente novamente. Valores permitidos: "+x, "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (e.KeyChar == (char)Keys.Enter)
                btn.PerformClick();
        }

        /*Este metódo faz:
         * 
         * - Pega o valor digitado no teclado pelo o usuário e filtra só deixando,
         *   ser inserido em um componente valores como números.
         *   
         * - Pega o valor digitado no teclado pelo o usuário e se ele for o botão enter,
         *   ele iria clicar em um componente Button passado por parâmetro
         *   
         * - Ele tem como parametro: 
         *   e(Guarda a tecla pressionada pelo usuario).
         *   btn(Guarda o botão que será clicado caso o usuário digite enter).
         * 
         */
        public static void txtNum(KeyPressEventArgs e, Button btn)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != (char)Keys.Enter)
            {
                e.Handled = true;
                MessageBox.Show("Digito invalido, para prosseguir por favor digite um número válido!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (e.KeyChar == (char)Keys.Enter)
                btn.PerformClick();
        }

        /*Este metódo faz:
         * 
         * - Pega o valor digitado no teclado pelo o usuário e filtra só deixando,
         *   ser inserido em um componente valores como números.
         *   
         *   
         * - Ele tem como parametro: 
         *   e(Guarda a tecla pressionada pelo usuario).
         * 
         */
        public static void txtNum(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != (char)Keys.Enter)
            {
                e.Handled = true;
                MessageBox.Show("Digito invalido, para prosseguir por favor digite um número válido!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /*Este metódo faz:
         * 
         * - Pega o valor digitado no teclado pelo o usuário e acrescenta uma vírgula,
         *   caso o texto do componente textbox 'txt' só tenha um caracter.
         *   
         *   
         * - Ele tem como parametro: 
         *   e(Guarda a tecla pressionada pelo usuario).
         *   txt(Guarda o textbox que será avaliado).
         * 
         */
        public static void txtTransXY(KeyPressEventArgs e, TextBox txt)
        {
            if (txt.Text.Count() == 1 && e.KeyChar != 08)
            {
                txt.Text = txt.Text + ",";
                txt.SelectionStart = txt.Text.Length + 1;
            }
        }

        /*Este metódo faz:
         * 
         * - Analisa o texto do componente TextBox passado por parâmetro e deleta informações
         *   incoerentes.  
         *   
         * - Ele tem como parametro: 
         *   txt(Guarda o textbox que será avaliado).
         * 
         */
        public static void txtDelXY(TextBox txt)
        {
            if (txt.Text == ",")
            {
                txt.Clear();
                MessageBox.Show("Valor incoerente, texto apagado!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txt.Text.Count() != 0 && !(txt.Text.Contains(",")))
            {
                txt.Text = txt.Text.ToString()[0].ToString();
                txt.SelectionStart = txt.Text.Length + 1;
            }
        }

        /*Este metódo faz:
         * 
         * - Analisa o texto do componente TextBox passado por parâmetro e deleta informações
         *   incoerentes.  
         *   
         * - Ele tem como parametro: 
         *   txt(Guarda o textbox que será avaliado).
         * 
         */
        public static void txtDelXYRobo(TextBox txt)
        {
            if (txt.Text.Count() > 0)
            {
                if (txt.Text == "," || txt.Text.ToString()[0].ToString() == ",")
                {
                    txt.Clear();
                    MessageBox.Show("Valor incoerente, texto apagado!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txt.Text.Count() != 0 && !(txt.Text.Contains(",")) || txt.Text.Count() == 3 && (txt.Text.Contains("N") || txt.Text.Contains("S") || txt.Text.Contains("E") || txt.Text.Contains("W")))
                {
                    txt.Text = txt.Text.ToString()[0].ToString();
                    txt.SelectionStart = txt.Text.Length + 1;
                }
            }
        }
    }
}
