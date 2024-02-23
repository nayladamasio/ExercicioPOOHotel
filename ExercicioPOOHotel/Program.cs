using System.Collections.Generic;
using System.Diagnostics;

namespace ExercicioPOOHotel
{
    internal class Program
    {

        static List<Pessoa> pessoas = new List<Pessoa>();
        static List<Suite> suites = new List<Suite>();
        static List<Reserva> reservas = new List<Reserva>();

        static void Main(string[] args)
        {
            MenuPrincipal(pessoas, suites, reservas);
        }

        public static void MenuPrincipal(List<Pessoa> pessoas, List<Suite> suites, List<Reserva> reservas)
        {
            bool sair = false;
            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("──── MENU PRINCIPAL ────");
                    Console.WriteLine("1. Cadastro");
                    Console.WriteLine("2. Consultar");
                    Console.WriteLine("3. Listar");
                    Console.WriteLine("4. Sair");
                    Console.WriteLine("Digite o numero da sua opcao:");
                    string opcao = Console.ReadLine();

                    switch (opcao)
                    {
                        case "1":
                            MenuCadastro(pessoas, suites, reservas);
                            break;
                        case "2":
                            MenuConsultar(pessoas, suites, reservas);
                            break;
                        case "3":
                            MenuListar(pessoas, suites, reservas);
                            break;
                        case "4":
                            sair = true;
                            Console.WriteLine("Saindo...");
                            break;
                        default:
                            Console.WriteLine("Opcao invalida. Tente novamente.");
                            break;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ocorreu um erro: {ex.Message}");
                }

            } while (!sair);

        }

        public static void MenuCadastro(List<Pessoa> pessoas, List<Suite> suites, List<Reserva> reservas)
        {
            bool continuar = true;
            do
            {
                Console.WriteLine("- Menu Cadastro -");
                Console.WriteLine("1. Cadastrar Hospede");
                Console.WriteLine("2. Cadastrar Suite");
                Console.WriteLine("3. Cadastrar Reserva");
                Console.WriteLine("4. Voltar ao Menu Principal");
                Console.WriteLine("Digite o numero da sua opcao:");
                string opcaocadastro = Console.ReadLine();

                switch (opcaocadastro)
                {
                    case "1":
                        do
                        {
                            Pessoa.CadastrarHospede(pessoas);
                            Console.WriteLine("Deseja cadastrar outro hospede? (S/N)");
                        } while (Console.ReadLine().ToUpper() == "S");
                        break;
                    case "2":
                        do
                        {
                            Suite.CadastrarSuite(suites);
                            Console.WriteLine("Deseja cadastrar outra suite? (S/N)");
                        } while (Console.ReadLine().ToUpper() == "S");
                        break;
                    case "3":
                        do
                        {
                            Reserva.CadastrarReserva(pessoas, suites, reservas);
                            Console.WriteLine("Deseja cadastrar outra reserva? (S/N)");
                        } while (Console.ReadLine().ToUpper() == "S");
                        break;
                    case "4":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opcao invalida. Tente novamente.");
                        break;
                }

            } while (continuar);
            if (!continuar)
            {
                MenuPrincipal(pessoas, suites, reservas);
            }

        }
        public static void MenuConsultar(List<Pessoa> pessoas, List<Suite> suites, List<Reserva> reservas)
        {
            bool continuar = true;
            do
            {
                Console.WriteLine("- Menu Consultar -");
                Console.WriteLine("1. Consultar Hospede");
                Console.WriteLine("2. Consultar Suite");
                Console.WriteLine("3. Consultar Reserva");
                Console.WriteLine("4. Voltar ao Menu Principal");
                Console.WriteLine("Digite o numero da sua opcao:");
                string opcao = Console.ReadLine();

                switch (opcao)
                {

                    case "1":
                        do
                        {
                            Consulta.ConsultarHospede(pessoas);
                            Console.WriteLine("Deseja consultar outro hospede? (S/N)");
                        } while (Console.ReadLine().ToUpper() == "S");
                        break;
                    case "2":
                        do
                        {
                            Consulta.ConsultarSuite(suites);
                            Console.WriteLine("Deseja consultar outra suite? (S/N)");
                        } while (Console.ReadLine().ToUpper() == "S");
                        break;
                    case "3":
                        do
                        {
                            Consulta.ConsultarReserva(reservas);
                            Console.WriteLine("Deseja consultar outra reserva? (S/N)");
                        } while (Console.ReadLine().ToUpper() == "S");
                        break;
                    case "4":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opcao invalida. Tente novamente.");
                        break;
                }

            } while (continuar);
            if (!continuar)
            {
                MenuPrincipal(pessoas, suites, reservas);
            }

        }
        public static void MenuListar(List<Pessoa> pessoas, List<Suite> suites, List<Reserva> reservas)
        {
            bool continuar = true;
            do
            {
                Console.WriteLine(" - Menu Listar -");
                Console.WriteLine("1. Listar Hospedes");
                Console.WriteLine("2. Listar Suites");
                Console.WriteLine("3. Listar Reservas");
                Console.WriteLine("4. Voltar ao Menu Principal");
                Console.Write("Escolha uma opcao: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Listagem.ListarHospedes(pessoas);
                        break;
                    case "2":
                        Listagem.ListarSuites(suites);
                        break;
                    case "3":
                        Listagem.ListarReservas(reservas);
                        break;
                    case "4":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opcao invalida. Tente novamente.");
                        break;
                }

            } while (continuar);
            if (!continuar)
            {
                MenuPrincipal(pessoas, suites, reservas);
            }

        }
    }
}

