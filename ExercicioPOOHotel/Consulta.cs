using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPOOHotel
{
    class Consulta
    {
        public static void ConsultarHospede(List<Pessoa> pessoas)
        {
            Console.WriteLine("- Consultar Hospede -");
            Console.Write("Digite o codigo do Hospede: ");
            int codigoHospede = int.Parse(Console.ReadLine());

            Pessoa hospedeEncontrado = pessoas.Find(p => p.CD_Hospede == codigoHospede);

            if (hospedeEncontrado != null)
            {
                Console.WriteLine("Hospede encontrado:");
                Console.WriteLine($"Nome: {hospedeEncontrado.Nome}");
                Console.WriteLine($"Idade: {hospedeEncontrado.Idade}");
                Console.WriteLine($"Genero: {hospedeEncontrado.Genero}");
                Console.WriteLine($"Profissao: {hospedeEncontrado.Profissao}");
                Console.WriteLine($"Codigo do Hospede: {hospedeEncontrado.CD_Hospede}");
            }
            else
            {
                Console.WriteLine("Hospede nao encontrado.");
            }
        }

        public static void ConsultarSuite(List<Suite> suites)
        {
            Console.WriteLine("- Consultar Suite -");
            Console.Write("Digite o numero da suite: ");
            int numeroSuite = int.Parse(Console.ReadLine());

            Suite suiteEncontrada = suites.Find(s => s.NumeroSuite == numeroSuite);

            if (suiteEncontrada != null)
            {
                Console.WriteLine("Suite encontrada:");
                Console.WriteLine($"Numero da Suite: {suiteEncontrada.NumeroSuite}");
                Console.WriteLine($"Tipo de Quarto: {suiteEncontrada.TipoQuarto}");
                Console.WriteLine($"Valor da Diaria: {suiteEncontrada.ValorDiaria}");
                Console.WriteLine($"Disponibilidade: {(suiteEncontrada.Disponibilidade ? "Disponivel" : "Indisponivel")}");
                Console.WriteLine($"Capacidade: {suiteEncontrada.Capacidade}");
            }
            else
            {
                Console.WriteLine("Suite nao encontrada.");
            }
        }

        public static void ConsultarReserva(List<Reserva> reservas)
        {
            Console.WriteLine("- Consultar Reserva -");
            Console.WriteLine("Digite o nome do hospede:");
            string nomeHospede = Console.ReadLine();
            Console.WriteLine("Digite o numero da suite:");
            int numeroSuite = int.Parse(Console.ReadLine());

            Reserva reservaEncontrada = reservas.Find(r => r.Hospede.Nome == nomeHospede && r.SuiteReservada.NumeroSuite == numeroSuite);

            if (reservaEncontrada != null)
            {
                Console.WriteLine("Reserva encontrada:");
                Console.WriteLine($"Hospede: {reservaEncontrada.Hospede.Nome}");
                Console.WriteLine($"Suite: {reservaEncontrada.SuiteReservada.NumeroSuite}");
                Console.WriteLine($"Data de Inicio: {reservaEncontrada.DataInicio}");
                Console.WriteLine($"Data de Fim: {reservaEncontrada.DataFim}");
                
            }
            else
            {
                Console.WriteLine("Reserva nao encontrada.");
            }
        }
    }
}
