using System;

namespace Calculadora
{
    class Program
    {

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("-Bem-vindo a calculadora do Giovanni !--");
            Console.WriteLine("-------Digite a opção de calculo--------");
            Console.WriteLine("1) Soma---------------------------------");
            Console.WriteLine("2) Subtração----------------------------");
            Console.WriteLine("3) Multiplicação------------------------");
            Console.WriteLine("4) Divisão------------------------------");
            Console.WriteLine("5) Fechar calculadora-------------------");

            int opt = Convert.ToInt32(Console.ReadLine());

            switch (opt)
            {
                case 1:
                    Soma();
                    break;
                case 2:
                    Substração();
                    break;
                case 3:
                    Multiplicação();
                    break;
                case 4:
                    Divisão();
                    break;
                case 5:
                    System.Environment.Exit(0);
                    break;
                default:
                    Menu();
                    break;
            }

        }
        static void Divisão()
        {
            Console.WriteLine("Digite o primeiro numero da divisão: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite o segundo numero da divisão: ");
            float b = float.Parse(Console.ReadLine());
            float divisão = a/b;
            Console.WriteLine($"A divisão de {a} por {b} é: {divisão}");
            Console.ReadKey();
            Menu();
        }
        static void Multiplicação()
        {
            Console.WriteLine("Digite o primeiro numero da multiplicação: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite o segundo numero da multiplicação: ");
            float b = float.Parse(Console.ReadLine());
            float multiplicação = a * b;
            Console.WriteLine($"A multiplicação de {a} x {b} é: {multiplicação}");
            Console.ReadKey();
            Menu();
        }
        static void Substração()
        {
            Console.WriteLine("Digite o primeiro numero da subtração: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite o segundo numero da subtração: ");
            float b = float.Parse(Console.ReadLine());
            float subtração = a - b;
            Console.WriteLine($"A subtração de {a} - {b} é: {subtração}");
            Console.ReadKey();
            Menu();
        }
        static void Soma()
        {
            Console.WriteLine("Digite o primeiro numero da soma: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite o segundo numero da soma: ");
            float b = float.Parse(Console.ReadLine());
            float soma = a + b;
            Console.WriteLine($"A soma de {a} + {b} é: {soma}");
            Console.ReadKey();
            Menu();
        }

        static void Main(string[] args)
        {
            Menu();
        }
    }
}
