using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nasa.Classes;

namespace Nasa.Janelas
{
    public partial class FormMov : Form
    {
        public FormMov()
        {
            InitializeComponent();
        }

        //Aciona quando o componente 'txt_MoviPriRobo' está em foco e uma tecla está pressionada
        private void txt_MoviPriTratamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Chama método da classe de tratamento para permitir ou não, o que foi digitado.
            ControlChar.txtUsar("LMR", e, btn_MoverRoboUm);
        }

        //Aciona quando o componente 'txt_MoviSegRobo' está em foco e uma tecla está pressionada
        private void txt_MoviSegTratamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Chama método da classe de tratamento para permitir ou não, o que foi digitado.
            ControlChar.txtUsar("LMR", e, btn_MoverRoboDois);
        }

        //Aciona quando o componente 'txt_PosiEntrada' está em foco e uma tecla está pressionada
        private void txt_PosiEntrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Chama método da classe de tratamento para permitir ou não, o que foi digitado.
            ControlChar.txtNum(e);
            //Chama método da classe de tratamento para adicionar uma vírgula no texto do componente 'txt_PosiEntrada' quando for digitada a sua segunda posição.
            ControlChar.txtTransXY(e, txt_PosiEntrada);
        }
        //Aciona quando o componente 'txt_PosiEntrada' está em foco e uma tecla pressionada se encontra para cima
        private void txt_PosiEntrada_KeyUp(object sender, KeyEventArgs e)
        {
            //Chama método da classe de tratamento para observar se o texto do componente 'txt_PosiEntrada' é coerente ao o valor a ser passado. Se não for deleta a incoerência.
            ControlChar.txtDelXY(txt_PosiEntrada);
        }

        //Aciona quando o componente 'txt_PosiPriRobo' está em foco e uma tecla está pressionada
        private void txt_PosiPriRobo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Condição para saber qual método da classe de tratamento passar
            if (txt_PosiPriRobo.Text.Count() <= 2)
                ControlChar.txtNum(e, btn_MoverRoboUm);
            else
                ControlChar.txtUsar("NSEW", e, btn_MoverRoboUm);

            //Chama método da classe de tratamento para adicionar uma vírgula no texto do componente 'txt_PosiPriRobo' quando for digitada a sua segunda posição.
            ControlChar.txtTransXY(e, txt_PosiPriRobo);
        }
        //Aciona quando o componente 'txt_PosiPriRobo' está em foco e uma tecla pressionada se encontra para cima
        private void txt_PosiPriRobo_KeyUp(object sender, KeyEventArgs e)
        {
            //Chama método da classe de tratamento para observar se o texto do componente 'txt_PosiPriRobo' é coerente ao o valor a ser passado. Se não for deleta a incoerência.
            ControlChar.txtDelXYRobo(txt_PosiPriRobo);
        }

        //Aciona quando o componente 'txt_PosiSegRobo' está em foco e uma tecla está pressionada
        private void txt_PosiSegRobo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Condição para saber qual método da classe de tratamento passar
            if (txt_PosiSegRobo.Text.Count() <= 2)
                ControlChar.txtNum(e, btn_MoverRoboDois);
            else
                ControlChar.txtUsar("NSEW", e, btn_MoverRoboDois);

            //Chama método da classe de tratamento para adicionar uma vírgula no texto do componente 'txt_PosiSegRobo' quando for digitada a sua segunda posição.
            ControlChar.txtTransXY(e, txt_PosiSegRobo);
        }
        //Aciona quando o componente 'txt_PosiSegRobo' está em foco e uma tecla pressionada se encontra para cima
        private void txt_PosiSegRobo_KeyUp(object sender, KeyEventArgs e)
        {
            //Chama método da classe de tratamento para observar se o texto do componente 'txt_PosiSegRobo' é coerente ao o valor a ser passado. Se não for deleta a incoerência.
            ControlChar.txtDelXYRobo(txt_PosiSegRobo);
        }

        //Aciona quando é clicado o componente 'btn_MoverRoboUm'
        private void btn_MoverRoboUm_Click(object sender, EventArgs e)
        {
            /* Condição para saber se os dados foram preenchidos corretamente,
             * se sim chamar um método de classe para adicionar o resultado onde o objeto se encontra atualmente no componente 'lbx_Resultado'.
             */
            if (txt_PosiEntrada.Text.Count() == 3 && txt_PosiPriRobo.Text.Count() == 4 && txt_MoviPriRobo.Text.Count() != 0)
            {
                lbx_Resultado.Items.Add("O robo 1 se encontra em: " + Robo.PosicaoFinal(txt_PosiPriRobo.Text,txt_MoviPriRobo.Text));
            }
            else
                MessageBox.Show("Dados incompletos, preencha corretamente a posição de entrada, a posição do robô 1 e sua movimentação!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //Aciona quando é clicado o componente 'btn_MoverRoboDois'
        private void btn_MoverRoboDois_Click(object sender, EventArgs e)
        {
            /* Condição para saber se os dados foram preenchidos corretamente,
             * se sim chamar um método de classe para adicionar o resultado onde o objeto se encontra atualmente no componente 'lbx_Resultado'.
             */
            if (txt_PosiEntrada.Text.Count() == 3 && txt_PosiSegRobo.Text.Count() == 4 && txt_MoviSegRobo.Text.Count() != 0)
            {
                lbx_Resultado.Items.Add("O robo 2 se encontra em: " + Robo.PosicaoFinal(txt_PosiSegRobo.Text, txt_MoviSegRobo.Text));
            }
            else
                MessageBox.Show("Dados incompletos, preencha corretamente a posição de entrada, a posição do robô 2 e sua movimentação!","Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
