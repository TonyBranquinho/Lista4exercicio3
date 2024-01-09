using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("Digite o numero de casos.");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                string[] vet = Console.ReadLine().Split(' ');
                double a = double.Parse(vet[0], CI);
                double b = double.Parse(vet[1], CI);
                double c = double.Parse(vet[2], CI);

                double media = a * 0.2 + b * 0.3 + c * 0.5;
                Console.WriteLine(media.ToString("F1", CI));
            }
        }
    }
}