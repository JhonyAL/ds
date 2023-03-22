using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static double inputDouble()
        {
            return Convert.ToDouble(Console.ReadLine());
        }

        static string mention(double number)
        {
            if (number >= 9)
            {
                return "MB";
            }
            else if (number >= 8)
            {
                return "B";
            }
            else if (number >= 7)
            {
                return "R";
            }
            return "I";
        }

        static void Main(string[] args)
        {
            double n1;
            double n2;
            double n3;
            double n4;
            string situation;
            string name;
            Console.WriteLine("Nome: ");
            name = Console.ReadLine();
            Console.WriteLine("Primeira nota: ");
            n1 = inputDouble();
            Console.WriteLine("Segunda nota: ");
            n2 = inputDouble();
            Console.WriteLine("Terceira nota: ");
            n3 = inputDouble();
            Console.WriteLine("Quarta nota: ");
            n4 = inputDouble();

            double media = (n1 + n2 + n3 + n4) / 4;

            if (media >= 7)
            {
                situation = "Aprovado";
            }
            else if (media < 4)
            {
                situation = "Reprovado";
            }
            else
            {
                situation = "Em recuperação";
            }

            Console.Write($"{name}, você obteve a menção {mention(n1)} no 1º, {mention(n2)} na 2°, {mention(n3)} na 3°, {mention(n4)} na 4°, sendo assim, sua menção final é {mention(media)}. Você está {situation}");

            Console.ReadLine();
        }
    }
}
