namespace SistemaDeCadastroAlunos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool menu = true;
            while (menu) 
            {
                Console.WriteLine("\n=== Sistema de Cadastro de Alunos ===");
                Console.WriteLine("1 - Adicionar Aluno");
                Console.WriteLine("2 - Listar Alunos");
                Console.WriteLine("3 - Sair");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Aluno.AdicionarAluno();
                        break;
                    case "2":
                        Aluno.ListarAlunos();
                        break;
                    case "3":
                        Console.WriteLine("Encerrando o programa...");
                        menu = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                }                
            }            
        }
    }
}
