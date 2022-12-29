using System;
using System.Collections.Generic;

namespace MegaSena.Calculo
{
    internal class Program
    {

        private static IList<string> _apostas = new List<string>();

        static void Main(string[] args)
        {           
            DateTime start = DateTime.Now;
            Console.WriteLine($"Tempo Inicial: {start}");
            for (int a = 1; a <= 55; a++)
            {
                for (int b = 2; b <= 56; b++)
                {
                    for (int c = 3; c <= 57; c++)
                    {
                        for (int d = 4; d <= 58; d++)
                        {
                            for (int e = 5; e <= 59; e++)
                            {
                                for (int f = 6; f <= 60; f++)
                                {
                                    var aposta = $"{a:D2},{b:D2},{c:D2},{d:D2},{e:D2},{f:D2}";

                                    if (!_apostas.Contains(aposta))
                                    {
                                        _apostas.Add(aposta);
                                    }
                                }
                            }
                        }
                    }
                }
            }

            DateTime end = DateTime.Now;
            Console.WriteLine($"Tempo Final: {end}");
            Console.WriteLine($"Tempo de processamento: {end - start}");
            Console.WriteLine($"Total de apostas possíveis: {_apostas.Count}");
            Console.ReadKey();
        }
    }
}
