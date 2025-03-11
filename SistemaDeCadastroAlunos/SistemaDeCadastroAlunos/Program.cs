namespace SistemaDeCadastroAlunos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Aluno> listaAlunos = new List<Aluno>();
            bool menu = true;
            while (menu) 
            {

                int opcao;
                Console.WriteLine("Digite 1 para adicionar um aluno: ");
                Console.WriteLine("Digite 2 para exibir a lista de alunos: ");
                Console.WriteLine("Digite 0 para fechar o menu: ");
                opcao = int.Parse(Console.ReadLine());
                if (opcao == 0)
                {
                    menu = false;  
                    break;
                }
                if (opcao == 1) 
                {
                    Console.WriteLine("Adicionando aluno");
                }
                if (opcao == 2) 
                {
                    Console.WriteLine("Menu");
                    foreach (Aluno aluno in listaAlunos)
                    {
                        Console.WriteLine($"Nome: {aluno.Nome}");
                        Console.WriteLine($"E-mail: {aluno.Curso}");
                        Console.WriteLine($"Matricula: {aluno.Matricula}");
                        Console.WriteLine("");
                    }
                }
                
                

                foreach (Aluno aluno in listaAlunos)
                {
                    Console.WriteLine($"Nome: {aluno.Nome}");
                    Console.WriteLine($"E-mail: {aluno.Curso}");
                    Console.WriteLine($"Matricula: {aluno.Matricula}");
                    Console.WriteLine("");
                }

            }

            
            

            
        }
    }
}
