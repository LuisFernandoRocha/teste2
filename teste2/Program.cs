using System;
using System.Collections.Generic;
using System.Globalization;

namespace teste2
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                double PercentualReajuste = 0.0;

                List<Pessoas> lista = new List<Pessoas>();
                string[] nomes = new string[7] { "Patrícia", "Fernanda", " Diego", "Letícia", "Tiago", "Rodnei", "Sabrina" };
                Console.WriteLine("Se o percentual será único ou se será variável? ");
                Console.WriteLine("Se o percentual for único Digite (U) ou variável Digite (V)? ");
                char Tipo = char.Parse(Console.ReadLine());

                if (Tipo == 'U')
                {
                    Console.WriteLine("Qual o Percentual Fixo? ");
                    PercentualReajuste = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
                foreach (string nome in nomes)
                {
                    Console.Write("Qual o salário atual da " + nome + " R$ = ");
                    double Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    if (Tipo == 'V')
                    {
                        Console.Write("Percentual reajuste: ");
                        PercentualReajuste = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    }
                    double novoSalario = SalarioReajustado(PercentualReajuste, Salario);
                    lista.Add(new Pessoas(nome, Salario, PercentualReajuste, novoSalario));
                }
                Console.WriteLine("");
                foreach (Pessoas p in lista)
                {
                    Console.WriteLine(p.Nome + " tem o Salario R$ = "
                        + p.Salario.ToString("F2", CultureInfo.InvariantCulture)
                        + ", Percentual Reajuste = "
                        + p.Porcentagem + " % Novo Salario R$ = "
                        + p.NovoSalario.ToString("F2", CultureInfo.InvariantCulture));
                }

                Console.ReadKey();


            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error! " + e.Message);
            }
        }


        public static double SalarioReajustado(double PercentualReajuste, double Salario)
        {

            double total = Salario + ((PercentualReajuste / 100) * Salario);
            return total;
        }
    }
}
