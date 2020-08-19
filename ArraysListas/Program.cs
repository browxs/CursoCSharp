using System;

namespace ArraysListas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tipo Referência: Classe
            TipoReferencia r1, r2;
            r1 = new TipoReferencia() { Quantidade = 1 };
            r2 = r1;
            r1.Quantidade = 2;
            Console.WriteLine(r1.Quantidade);
            Console.WriteLine(r2.Quantidade);
            // Tipo Valor: Struct
            TipoValor v1, v2;
            v1.Quantidade = 1;
            v2 = v1;
            v1.Quantidade = 2;
            Console.WriteLine(v1.Quantidade);
            Console.WriteLine(v2.Quantidade);

            // Nullable
            // int x = null; não pode porque int não aceita nulo
            // Nullable<int> x = null;
            int? x = null;
            Console.WriteLine(x.HasValue);
            int y = x ?? 5;
            Console.WriteLine(y);

            // Vetores
            Console.WriteLine("defina elementos do vetor");
            var elementos = int.Parse(Console.ReadLine());
            // pode ser um objeto ao invés de int
            int[] vetor = new int[elementos];
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine($"insira informação do vetor posicao: {i}");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine($"valor do vetor[{i}]: {vetor[i]}");
            }
            // foreach
            foreach (var item in vetor)
            {
                Console.WriteLine(item);
            }

            // Params
            // n quantidade de parametros
            var parametros = Params.Soma(1, 2, 3);
            Console.WriteLine(parametros);

            // Matriz
            int tamanhoMatriz = int.Parse(Console.ReadLine());
            int[,] matriz = new int[tamanhoMatriz, tamanhoMatriz];
            for (int i = 0; i < tamanhoMatriz; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < tamanhoMatriz; j++)
                {
                    matriz[i, j] = int.Parse(values[j]);
                }
            }
        }
    }
}
