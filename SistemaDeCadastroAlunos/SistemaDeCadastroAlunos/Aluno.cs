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

        public Aluno()
        {
        }

        public string AdicionarNome() 
        {
            Console.WriteLine("Digite o nome do aluno: ");
            string nome = Console.ReadLine();
            return nome;
        }
        public void AdicionarCurso()
        {
            Console.WriteLine("Qual o curso do aluno? ");
            Curso = Console.ReadLine();
        }
        public void AdicionarMatricula()
        {
            Console.WriteLine("Qual a matricula do aluno? ");
            Matricula = int.Parse(Console.ReadLine());
        }



    }
}
