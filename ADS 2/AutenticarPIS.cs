using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS_2
{
    internal class AutenticarPIS
    {
        DigitosDocumentos digitosDocumentos = new DigitosDocumentos();

        public AutenticarPIS()
        {
            int[] digitosPIS = digitosDocumentos.ObterDigitos();

            int[] verificar1 = new int[10] { 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            int soma = 0;
            int resto;

            for (int i = 0; i < 10; i++)
            {
                soma += digitosPIS[i] * verificar1[i];
            }

            resto = soma % 11;
            int primeiroDigitoVerificador = resto == 10 || resto == 11 ? 0 : resto;

            digitosPIS[10] = primeiroDigitoVerificador;

            string PIS = string.Join("", digitosPIS.Take(10));
        }
    }
}