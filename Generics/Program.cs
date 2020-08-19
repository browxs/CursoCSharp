using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericsSetDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Generics
            // inicialmente criada como int[] o PrintService
            // Problemas:
            // 1. Reuso: se precisar trabalhar com string[], é necessário criar uma nova classe
            //           ex.: PrintServiceString
            // 2. Type Safety: um forma de vencer o reuso é criar o PrintService como object
            //                 mas teria problema de conflito em alguns casos entre string[] e int[]
            //                 aumentando a chance de dar erro em tempo de execução
            // Solução: criar como Generic de T - serve para classes, interfaces e métodos

            //Console.WriteLine("Generics:");
            //PrintService<int> printService = new PrintService<int>();
            ////PrintService<string> printService = new PrintService<string>();

            //Console.Write("How many values? ");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    int x = int.Parse(Console.ReadLine());
            //    //string x = Console.ReadLine();
            //    printService.AddValue(x);
            //}

            //printService.Print();

            //Console.WriteLine($"First: {printService.First()}");
            #endregion

            Console.WriteLine("---------");

            #region GetHashCode e Equals
            // tipos pré-definidos (int, string, etc) já possuem a implementação
            // Classes é necessário a implementação. Ex na classe: Client
            Console.WriteLine("GetHashCode e Equals:");

            var clientA = new Client() { Name = "Maria", Email = "teste@teste.com" };
            var clientB = new Client() { Name = "José", Email = "teste@teste.com" };

            Console.WriteLine(clientA == clientB);
            Console.WriteLine(clientA.Equals(clientB));
            Console.WriteLine(clientA.GetHashCode());
            Console.WriteLine(clientB.GetHashCode());

            // Struct
            var pointA = new Point() { X = 1, Y = 2 };
            var pointB = new Point() { X = 1, Y = 2 };

            Console.WriteLine(pointA.Equals(pointB));
            #endregion

            Console.WriteLine("---------");

            #region HashSet e SortedSet
            // é um conjunto de elementos (similar ao da Álgebra)
            // não permitem repetições e não tem posições 
            // operações de conjuntos: UnionWith, IntersectWith, ExceptWith
            // Sorted já vem ordenado
            var hashSet = new HashSet<int>() { 1, 3 };
            hashSet.Add(2);
            hashSet.Add(3);
            PrintCollection(hashSet);

            var sortedSetA = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            var sortedSetB = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            // Union
            var sortedSetUnion = new SortedSet<int>(sortedSetA);
            sortedSetUnion.UnionWith(sortedSetB);
            PrintCollection(sortedSetUnion);

            // Intersect
            var sortedSetIntersect = new SortedSet<int>(sortedSetA);
            sortedSetIntersect.IntersectWith(sortedSetB);
            PrintCollection(sortedSetIntersect);

            // Except
            var sortedSetExcept = new SortedSet<int>(sortedSetA);
            sortedSetExcept.ExceptWith(sortedSetB);
            PrintCollection(sortedSetExcept);

            Console.WriteLine();
            #endregion

            Console.WriteLine("---------");

            #region Dictionary e SortedDictionary
            // é uma coleção de pares (chave/valor)
            // não permitem repetições do objeto chave e são indexados por ele (não possuem posição)
            var cookies = new Dictionary<string, string>();
            cookies["user"] = "maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "99771122";
            cookies["phone"] = "99771133";
            Console.WriteLine(cookies["email"]);
            cookies.Remove("email");
            Console.WriteLine("Phone number: " + cookies["phone"]);
            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine("Email: " + cookies["email"]);
            }
            else
            {
                Console.WriteLine("There is not 'email' key");
            }
            Console.WriteLine("Size: " + cookies.Count);
            Console.WriteLine("ALL COOKIES:");

            foreach (var item in cookies)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
            #endregion
        }

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            Console.WriteLine();

            foreach (var item in collection)
            {
                Console.Write(item);
            }
        }
    }
}
