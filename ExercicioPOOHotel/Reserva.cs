using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPOOHotel
{
    class Reserva
    {
        public int NumeroReserva { get; }
        public Pessoa Hospede { get; set; }
        public Suite SuiteReservada { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }

        public Reserva(Pessoa hospede, Suite suitereservada, DateTime dateinicio, DateTime datefim)
        {
            Random rand = new Random();
            int numeroReserva = rand.Next(1000, 2000);

            Hospede = hospede;
            SuiteReservada = suitereservada;
            DataInicio = dateinicio;
            DataFim = datefim;
        }

        public decimal CalcularValorTotal()
        {
            int diasReserva = (int)(DataFim - DataInicio).TotalDays;
            decimal valorTotal = diasReserva * SuiteReservada.ValorDiaria;

            if (diasReserva > 10)
            {
                valorTotal *= 0.9m;
            }
            return valorTotal;
        }

        public static void CadastrarReserva(List<Pessoa> pessoas, List<Suite> suites, List<Reserva> reservas)
        {
            bool cadastrarOutraReserva = true;

            do
            {
                int codigoHospede;
                do
                {
                    Console.WriteLine("Digite o código do hospede:");
                } while (!int.TryParse(Console.ReadLine(), out codigoHospede));

                Pessoa hospedeSelecionado = pessoas.Find(p => p.CD_Hospede == codigoHospede);

                if (hospedeSelecionado == null)
                {
                    Console.WriteLine("Hospede não encontrado. Verifique o código e tente novamente.");
                    continue;
                }

                int numeroSuite;
                do
                {
                    Console.Write("Digite o número da suíte: ");
                } while (!int.TryParse(Console.ReadLine(), out numeroSuite) || numeroSuite < 1);

                Suite suiteSelecionada = suites.Find(s => s.NumeroSuite == numeroSuite);

                DateTime dataInicio;
                do
                {
                    Console.WriteLine("Informe a data de início da reserva (dd/mm/aaaa):");
                } while (!DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dataInicio));

                DateTime dataFim;
                do
                {
                    Console.WriteLine("Informe a data de fim da reserva (dd/mm/aaaa):");
                } while (!DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dataFim));

                int duracaoReserva = (int)(dataFim - dataInicio).TotalDays;

                decimal valorTotalReserva = suiteSelecionada.ValorDiaria * duracaoReserva;

                if (duracaoReserva > 10)
                {
                    decimal desconto = valorTotalReserva * 0.1m;
                    valorTotalReserva -= desconto;
                    Console.WriteLine("Desconto de 10% aplicado!");
                }

                Reserva novaReserva = new Reserva(hospedeSelecionado, suiteSelecionada, dataInicio, dataFim);
                reservas.Add(novaReserva);

                suiteSelecionada.Disponibilidade = false;

                Console.WriteLine("Reserva cadastrada com sucesso!");
                Console.WriteLine("Detalhes da Reserva:");
                Console.WriteLine($"Hóspede: {hospedeSelecionado.Nome}");
                Console.WriteLine($"Número da Suíte: {suiteSelecionada.NumeroSuite}");
                Console.WriteLine($"Data de Início: {dataInicio.ToShortDateString()}");
                Console.WriteLine($"Data de Fim: {dataFim.ToShortDateString()}");
                Console.WriteLine($"Valor Total: {valorTotalReserva:C2}");

                Console.WriteLine("Deseja cadastrar outra reserva? (S/N)");
            } while (Console.ReadLine().ToUpper() == "S");
        }
    }
}
