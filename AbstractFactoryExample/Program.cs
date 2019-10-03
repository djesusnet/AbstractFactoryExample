using System;
using ExecucaoAbstractFactory = AbstractFactoryExample.AbstractFactory.ExecucaoAbstractFactory;

namespace AbstractFactoryExample
{
    class Program
    {
        private static void Main()
        {
            Console.WriteLine("Escolha a operação:");
            Console.WriteLine("------------------------");
            Console.WriteLine("Creational Patterns");
            Console.WriteLine("------------------------");
            Console.WriteLine("1 - Abstract Factory");
            Console.WriteLine("------------------------");

            var opcao = Console.ReadKey();

            Console.WriteLine("");
            Console.WriteLine("------------------------");
            Console.WriteLine("");

            switch (opcao.KeyChar)
            {
                case '1':
                    ExecucaoAbstractFactory.Executar();
                    break;
            }

            Console.ReadKey();
            Console.Clear();
            Main();

        }
    }
}
