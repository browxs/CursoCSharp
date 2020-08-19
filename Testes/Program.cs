using System;

namespace AtributosMetodosConstrutores
{
    class Program
    {
        static void Main(string[] args)
        {
            var campoPropriedade = new CampoPropriedade();
            campoPropriedade.Encapsulamento = "TV";
            Console.WriteLine(campoPropriedade.Encapsulamento);
            campoPropriedade.Encapsulamento = "T";
            Console.WriteLine(campoPropriedade.Encapsulamento);

            var construtorSobrecarga = new ConstrutorSobrecarga();
            Console.WriteLine(construtorSobrecarga);
            var construtorUmaSobrecarga = new ConstrutorSobrecarga("Categoria");
            Console.WriteLine(construtorUmaSobrecarga);
            var construtorDuasSobrecargas = new ConstrutorSobrecarga("Categoria", "Nome");
            Console.WriteLine(construtorDuasSobrecargas);

            var tipoMetodo = new TipoMetodo();
            var metodoReferenciavel = tipoMetodo.MetodoReferenciavel();
            Console.WriteLine(metodoReferenciavel);
            var metodoEstatico = TipoMetodo.MetodoEstatico();
            Console.WriteLine(metodoEstatico);
        }
    }
}
