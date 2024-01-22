using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS_2
{
    class AutenticarInscricaoEstadualPR
    {
        DigitosDocumentos digitosDocumentos = new DigitosDocumentos();

        public AutenticarInscricaoEstadualPR()
        {
            int[] digitosIE = digitosDocumentos.ObterDigitos();

            int[] verificar1 = new int[8] { 3, 2, 7, 6, 5, 4, 3, 2 };
            int[] verificar2 = new int[9] { 4, 3, 2, 7, 6, 5, 4, 3, 2 };

            int soma = 0;
            int resto;

            for (int i = 0; i < 8; i++)
            {
                soma += digitosIE[i] * verificar1[i];
            }

            resto = soma % 11 - soma;
            int primeiroDigitoVerificador = resto == 11 || resto == 10 ? 0 : resto;

            digitosIE[8] = primeiroDigitoVerificador;

            soma = 0;
            for (int i = 0; i < 9; i++)
            {
                soma += digitosIE[i] * verificar2[i];
            }

            resto = soma % 11 - soma;
            int segundoDigitoVerificador = resto == 11 || resto == 10 ? 0 : resto;

            digitosIE[9] = segundoDigitoVerificador;

            string InscriçãoEstadual = string.Join("", digitosIE.Take(9));
        }
    }
}


