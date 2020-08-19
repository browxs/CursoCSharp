using System;
using System.Collections.Generic;
using System.Text;

namespace ArraysListas
{
    public class Params
    {
        public static int Soma(params int[] parametros)
        {
            int soma = 0;
            for (int i = 0; i < parametros.Length; i++)
            {
                soma += parametros[i];
            }
            return soma;
        }
    }
}
