using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPOOHotel
{
    class Suite
    {
        public int NumeroSuite { get; set; }
        public string TipoQuarto { get; set; }
        public decimal ValorDiaria { get; set; }
        public bool Disponibilidade { get; set; }
        public int Capacidade { get; set; }

        public Suite(int numerosuite, string tipoquarto, decimal valordiaria, bool disponibilidade, int capacidade)
        {
            NumeroSuite = numerosuite;
            TipoQuarto = tipoquarto;
            ValorDiaria = valordiaria;
            Disponibilidade = disponibilidade;
            Capacidade = capacidade;
        }

        public static void CadastrarSuite(List<Suite> suites)
        {
                Console.WriteLine("Digite o numero da suite:");
                int numerosuite = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o tipo do quarto");
                string tipoquarto = Console.ReadLine();
                Console.WriteLine("Digite o valor da diaria: ");
                decimal valordiaria = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Digite a disponibilidade do quarto (true/false): ");
                bool disponibilidade = bool.Parse(Console.ReadLine());
                Console.WriteLine("Digite a capacidade do quarto: ");
                int capacidade = int.Parse(Console.ReadLine());

                Suite novasuite = new Suite(numerosuite, tipoquarto, valordiaria, disponibilidade, capacidade);
                suites.Add(novasuite);

                Console.WriteLine("Suite cadastrada com sucesso!");

            
        }

    }
}
