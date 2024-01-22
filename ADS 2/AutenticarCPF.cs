using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ADS_2
{
    class AutenticarCPF
    {
        DigitosDocumentos digitosDocumentos = new DigitosDocumentos();

        public AutenticarCPF()
        {
            int[] digitosCPF = digitosDocumentos.ObterDigitos();

            int[] verificar1 = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] verificar2 = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int soma = 0;
            int resto;

            for (int i = 0; i < 9; i++)
            {
                soma += digitosCPF[i] * verificar1[i];
            }
            resto = soma % 11;

            int primeiroDigitoVerificador = resto >= 10 ? 0 : resto;

            digitosCPF[11] = primeiroDigitoVerificador;

            resto = 0;
            soma = 0;
            for (int i = 0; i < 10; i++)
            {
                soma += digitosCPF[i] * verificar2[i];
            }
            resto = soma % 11;

            int segundoDigitoVerificador = resto >= 10 ? 0 : resto;

            digitosCPF[12] = segundoDigitoVerificador;

            string CPF = string.Join("", digitosCPF.Take(11));

        }
    }
}
