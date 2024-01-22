using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ADS_2
{
    class DigitosDocumentos
    {
        Random DigitosAleatorios = new Random();
        public int[] DigitosParaCalculo_Array = new int[14];
        public string CPF { get; private set; }
        public string CNPJ { get; private set; }
        public string PIS { get; private set; }
        public string TituloEleitor { get; private set; }
        public string UnidadedeFederacao { get; private set; }
        public string InscriçãoEstadual { get; private set; }
        public DigitosDocumentos()
        {
            GerarDigitosAleatorios();

            CPF = string.Join("", DigitosParaCalculo_Array.Take(9));
            CNPJ = string.Join("", DigitosParaCalculo_Array.Take(12));
            PIS = string.Join("", DigitosParaCalculo_Array.Take(10));
            TituloEleitor = string.Join("", DigitosParaCalculo_Array.Take(8));
            UnidadedeFederacao = string.Join("", DigitosParaCalculo_Array.Take(2));
            InscriçãoEstadual = string.Join("", DigitosParaCalculo_Array.Take(8));
        }
       
        private void GerarDigitosAleatorios()
        {
            for (int i = 0; i < DigitosParaCalculo_Array.Length; i++)
            {
                DigitosParaCalculo_Array[i] = DigitosAleatorios.Next(0, 9);
            }
        }

        public int[] ObterDigitos()
        {
            return DigitosParaCalculo_Array;
        }
    }
}
