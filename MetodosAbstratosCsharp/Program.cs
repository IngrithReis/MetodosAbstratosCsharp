using MetodosAbstratosCsharp.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace MetodosAbstratosCsharp
{
    class Program
    {
        public static List<Pessoa> pessoas = new List<Pessoa>();
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com a quantidade de contribuintes: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i<=n; i++)
            {
                Console.WriteLine($"Entre com os dados do #{i} contrinuinte");
                Console.Write("Pessoa Física ou Jurídia? F/J ");
                string resposta = Console.ReadLine();

                
                
                if (resposta == "F" || resposta == "f")
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Renda anual declarada: ");
                    double renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Valor com gastos em saúde: ");
                    double gastos = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    pessoas.Add(new PessoaFisica(nome, renda, gastos));

                }
                else if(resposta == "J" || resposta == "j")
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Renda anual declarada: ");
                    double renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Quantidade de funcionários: ");
                    int funcionarios = int.Parse(Console.ReadLine());

                    pessoas.Add(new PessoaJuridica(nome, renda, funcionarios));
                }
                else 
                {
                    Console.WriteLine("Dado inserido incorretamente, favor refazer solicitação deste contribuinte");
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("Contrinuintes: ");
            double soma = 0;
            foreach (Pessoa pessoa in pessoas)
            { 
                Console.WriteLine(pessoa.Nome +" $"+ pessoa.ValorPago().ToString("F2", CultureInfo.InvariantCulture));
                soma += pessoa.ValorPago();
            }

            Console.WriteLine("Total de valor arrecadado: "+ soma.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
