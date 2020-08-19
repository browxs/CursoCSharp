using HerancaMultipla.Entities;
using System;

namespace HerancaMultipla
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo:
            // classe Device tem o metodo de processDoc
            // as classes Scanner e Printer herdam de Device
            // a classe ComboDevice precisa ter o mesmo comportamento da Scanner e Print
            // não é possível herdar das duas classes, pois ocasiona o problema do diamante
            // porque as classes já herdam de Device, então o método processDoc ira repetir

            Printer printer = new Printer() { SerialNumber = 1002 };
            printer.ProcessDoc("My letter");
            printer.Print("My letter");

            Scanner scanner = new Scanner() { SerialNumber = 1003 };
            scanner.ProcessDoc("My email");
            Console.WriteLine(scanner.Scan());

            ComboDevice comboDevice = new ComboDevice() { SerialNumber = 1004 };
            comboDevice.ProcessDoc("My dissertation");
            comboDevice.Print("My dissertation");
            Console.WriteLine(comboDevice.Scan());
        }
    }
}
