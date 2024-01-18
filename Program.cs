using System;
using System.Globalization;
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite sua senha: ");
            int senha = int.Parse(Console.ReadLine());

            while (senha != 1425)
            {

                Console.WriteLine("Senha incorreta:");
                senha = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Ascesso Permitido!!!");

        }
    }
}
