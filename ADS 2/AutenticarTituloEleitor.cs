using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS_2
{
    internal class AutenticarTituloEleitor
    {
        DigitosDocumentos digitosDocumentos = new DigitosDocumentos();

        public AutenticarTituloEleitor()
        {
            string UF = digitosDocumentos.UnidadedeFederacao;

            int[] UnidadedeFederacao = digitosDocumentos.ObterDigitos();
            int[] digitosTituloEleitor = digitosDocumentos.ObterDigitos();

            int[] verificar1 = new int[8] { 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] verificar2 = new int[3] { 7, 8, 9 };

            int soma = 0;
            int resto;

            for (int i = 0; i < 8; i++)
            {
                soma += digitosTituloEleitor[i] * verificar1[i];
            }

            resto = soma % 11;
            int primeiroDigitoVerificador = resto == 10 ? 0 : resto;

            UnidadedeFederacao[3] = primeiroDigitoVerificador;

            soma = 0;
            for (int i = 0; i < 3; i++)
            {
                soma += UnidadedeFederacao[i] * verificar2[i];
            }

            resto = soma % 11;
            int segundoDigitoVerificador = resto == 10 ? 0 : resto;

            UnidadedeFederacao[4] = segundoDigitoVerificador;

            string TituloEleitor = string.Join("", digitosTituloEleitor.Take(8)) + string.Join("", UnidadedeFederacao.Take(4));
        }
    }
}
