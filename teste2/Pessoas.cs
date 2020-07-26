using System;
using System.Collections.Generic;
using System.Text;

namespace teste2
{
    class Pessoas
    {
        public string Nome { get; set; }
        public double Salario { get; set; }
        public double Porcentagem { get; set; }
        public double NovoSalario { get; set; }

        public Pessoas(string nome, double salario, double porcentagem, double novoSalario)
        {
            Nome = nome;
            Salario = salario;
            Porcentagem = porcentagem;
            NovoSalario = novoSalario;
        }
    }
}
