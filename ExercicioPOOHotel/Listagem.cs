using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPOOHotel
{
     class Listagem
    {
        public static void ListarHospedes(List<Pessoa> pessoas)
        {
            Console.WriteLine("- Listar Hospedes -");
            foreach (var hospede in pessoas)
            {
                Console.WriteLine($"Nome: {hospede.Nome}");
                Console.WriteLine($"Idade: {hospede.Idade}");
                Console.WriteLine($"Genero: {hospede.Genero}");
                Console.WriteLine($"Profissao: {hospede.Profissao}");
                Console.WriteLine($"Código do Hospede: {hospede.CD_Hospede}");
                Console.WriteLine();
            }
        }
        public static void ListarSuites(List<Suite> suites)
        {
            Console.WriteLine("- Listar Suites -");
            foreach (var suite in suites)
            {
                Console.WriteLine($"Numero da Suite: {suite.NumeroSuite}");
                Console.WriteLine($"Tipo de Quarto: {suite.TipoQuarto}");
                Console.WriteLine($"Valor da Diaria: {suite.ValorDiaria}");
                Console.WriteLine($"Disponibilidade: {(suite.Disponibilidade ? "Disponivel" : "Indisponivel")}");
                Console.WriteLine($"Capacidade: {suite.Capacidade}");
                Console.WriteLine();
            }
        }

        public static void ListarReservas(List<Reserva> reservas)
        {
            Console.WriteLine("- Listar Reservas -");
            foreach (var reserva in reservas)
            {
                Console.WriteLine($"Hospede: {reserva.Hospede.Nome}");
                Console.WriteLine($"Suite: {reserva.SuiteReservada.NumeroSuite}");
                Console.WriteLine($"Data de Inicio: {reserva.DataInicio}");
                Console.WriteLine($"Data de Fim: {reserva.DataFim}");
                Console.WriteLine();
            }
        }
    }
}
