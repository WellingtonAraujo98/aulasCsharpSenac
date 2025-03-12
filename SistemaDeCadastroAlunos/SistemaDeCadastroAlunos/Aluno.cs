using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCadastroAlunos
{
    internal class Aluno
    {
        public string Nome;
        public string Curso;
        public int Matricula;


        private static List<Aluno> listaAlunos = new List<Aluno>();

        public static void AdicionarAluno()
        {
            Console.WriteLine("Digite o nome do aluno: ");
            string nome = Console.ReadLine();
            

            Console.WriteLine("Qual o curso do aluno? ");
            string curso = Console.ReadLine();
            
            Console.WriteLine("Qual a matrícula do aluno? ");
            int matricula = int.Parse(Console.ReadLine());


            // Adiciona o aluno à lista
            listaAlunos.Add(new Aluno { Nome = nome, Curso = curso, Matricula = matricula });

            Console.WriteLine("Aluno cadastrado com sucesso!\n");
        }

        public static void ListarAlunos()
        {
            Console.WriteLine("\nLista de Alunos Cadastrados:");
            foreach (var aluno in listaAlunos)
            {
                Console.WriteLine($"Nome: {aluno.Nome}, Curso: {aluno.Curso}, Matrícula: {aluno.Matricula}");
            }
        }
    }
}
