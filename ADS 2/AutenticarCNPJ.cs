using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS_2
{
    internal class AutenticarCNPJ
    {
        DigitosDocumentos digitosDocumentos = new DigitosDocumentos();

        public AutenticarCNPJ()
        {
            int[] digitosCNPJ = digitosDocumentos.ObterDigitos();

            int[] verificar1 = new int[12] { 6, 7, 8, 9, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] verificar2 = new int[13] { 5, 6, 7, 8, 9, 2, 3, 4, 5, 6, 7, 8, 9 };

            int soma = 0;
            int resto;

            for (int i = 0; i < 12; i++)
            {
                soma += digitosCNPJ[i] * verificar1[i];
            }
            resto = soma % 11;
            int primeiroDigitoVerificador = resto == 10 ? 0 : resto;
                        
            digitosCNPJ[12] = primeiroDigitoVerificador;

            soma = 0;
            resto = 0;
            for (int i = 0; i < 13; i++)
            {
                soma += digitosCNPJ[i] * verificar2[i];
            }
            resto = soma % 11;
            int segundoDigitoVerificador = resto == 10 ? 0 : resto;
            
            digitosCNPJ[13] = segundoDigitoVerificador;

            string CNPJ = string.Join("", digitosCNPJ.Take(14));
        }
    }
}
