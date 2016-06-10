using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasa.Classes
{
    class Robo
    {
        /*Este metódo faz:
         * 
         * - Um cálculo pegando atributos de posição, direção e sequência de movimentos a serem feitos pelo objeto,
         *   retornando em tipo string a nova atual localização do objeto em questão no plano cartesiano, bem como
         *   a sua nova direção atual.
         *   
         * - Tem como parâmetro: 
         * 
         * - Um vetor inteiro 'xy' que representa a posição inicial do objeto;
         * - Uma string 'ponteiro' que representa a direção, na qual o objeto se encontra apontado;
         * - Uma string 'movimentos' que representa o conjunto de instruções de movimentação, passadas para o objeto;
         * 
         */
        private static string Movimentacao(int[]xy, string ponteiro, string movimentos)
        {
            string posicaoFinal = ""; //Variável guarda o resultado final do cálculo
            int bussola = 0; //Variável indica a direção do objeto

            /* 
             * Aqui é informado o valor de direção em números onde:
             * Norte = 4;
             * Oeste = 3;
             * Sul = 2;
             * Leste = 1;
            */
            switch (ponteiro)
            {
                case "N":
                    bussola = 4;
                    break;
                case "W":
                    bussola = 3;
                    break;
                case "S":
                    bussola = 2;
                    break;
                case "E":
                    bussola = 1;
                    break;
            }

            /* 
             * A seguir uma estrutura de repetição na qual só se encerra, após repetir sua estrutura
             * pelo número total de comandos contidos na variável movimentos.
            */
            for (int i = 0; i < movimentos.Length; i++)
            {
                if (movimentos[i].ToString() == "L")
                {
                    bussola--;
                }
                if (movimentos[i].ToString() == "R")
                {
                    bussola++;
                }
                if (movimentos[i].ToString() == "M")
                {
                    //Aqui é feita a movimentação do objeto de acordo com a direção do objeto no plano.
                    switch (bussola)
                    {
                        case 4:
                            xy[1]++;
                            break;
                        case 2:
                            xy[1]--;
                            break;
                        case 1:
                            xy[0]++;
                            break;
                        case 3:
                            xy[0]--;
                            break;
                    }
                }

                //Aqui é feito uma correção indicativa de direção a ser definida quando a variável chegar em 0 ou 5.
                if (bussola == 0)
                    bussola = 4;
                if (bussola == 5)
                    bussola = 1;
            }

            /* 
             * Aqui é informado a variável ponteiro o valor de direção em letra onde:
             * N = 4;
             * W = 3;
             * S = 2;
             * E = 1;
            */
            switch (bussola)
            {
                case 4:
                    ponteiro = "N";
                    break;
                case 3:
                    ponteiro = "W";
                    break;
                case 2:
                    ponteiro = "S";
                    break;
                case 1:
                    ponteiro = "E";
                    break;
            }

            //Aqui se faz a representação do resultado em texto e retorna o resultado.
            posicaoFinal = xy[0]+","+xy[1]+" "+ponteiro;
            
            return posicaoFinal;
        }

        /*Este metódo faz:
         * 
         * - Pega a posição inicial do objeto e seus movimentos.
         * - Divide a posição inicial em um vetor, onde a primeira posição está em xy[0] e a segunda em xy[1].
         * - Retorna o resultado final com a nova posição, direção e movimentação do objeto.
         * 
         * - Tem como parâmetro: 
         * 
         * - Uma string 'posicao' que representa a posição e direção, na qual o objeto se encontra apontado;
         * - Uma string 'movimentos' que representa o conjunto de instruções de movimentação, passadas para o objeto; 
         * 
         */
        public static string PosicaoFinal(string posicao, string movimentos)
        {
            int[] xy = new int[2];
            xy[0] = Convert.ToInt32(posicao[0].ToString());
            xy[1] = Convert.ToInt32(posicao[2].ToString());

            //Aqui chama a classe Movimentacao para cálcular, a nova posição e direção do objeto e retornar o resultado final.
            string Resultado = Movimentacao(xy, posicao[3].ToString(), movimentos);

            return "" + Resultado;
        }
    }
}
