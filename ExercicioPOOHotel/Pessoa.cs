using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPOOHotel
{
    class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Genero { get; set; }
        public string Profissao { get; set; }
        public int CD_Hospede { get; set; }

        public Pessoa(string nome, int idade, string genero, string profissao, int cd_hospede)
        {
            Nome = nome;
            Idade = idade;
            Genero = genero;
            Profissao = profissao;
            CD_Hospede = cd_hospede;
        }

        public static void CadastrarHospede(List<Pessoa> pessoas)

        {
            Console.WriteLine("Digite o nome do Hospede: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite a idade do Hospede: ");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o genero do Hospede: ");
            string genero = Console.ReadLine();
            Console.WriteLine("Digite a profissao do Hospede: ");
            string profissao = Console.ReadLine();
            Console.WriteLine("Digite o codigo do Hospede: ");
            int cd_hospede = int.Parse(Console.ReadLine());

            Pessoa novohospede = new Pessoa(nome, idade, genero, profissao, cd_hospede);
            pessoas.Add(novohospede);

            Console.WriteLine("Hospede cadastrado com sucesso!");
        }

    }
}
