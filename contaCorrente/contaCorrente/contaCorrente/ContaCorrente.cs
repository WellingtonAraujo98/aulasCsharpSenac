
namespace contaCorrente
{
    internal class ContaCorrente
    {
        string numeroConta;
        string titular;
        double saldo = 0;
        private static HashSet<string> numerosGerados = new HashSet<string>();
        private string senha;

        public ContaCorrente (string titular)
        {
            this.numeroConta = GerarCartaoUnico();
            this.titular = titular;
            this.senha = Gerarsenha();
            Console.WriteLine($"{titular}seu cartão foi gerado {numeroConta}");
            Console.WriteLine($"Anote sua senha, não será exibida novamente: {senha}");
            
        }
        public void MenuConta()
        {   

            
            bool possoAcessar = AutenticarSenha();
            if (possoAcessar = true)
            {
                Console.WriteLine($"Bem vindo {titular} \n" +
                    $"Conta: {numeroConta}\n" +
                    $"Saldo atual: {saldo}\n" +
                    $"Para fazer um deposito digite (1): \n" +
                    $"Para fazer um saque digite (2): \n" +
                    $"Para fechar o menu digite (0)");
            }
            
            
                

                
        }

        private bool AutenticarSenha()
        {
            string senhaDigitada = " ";
            int numeroTentativa = 1;
            bool acessoPermitido = false;
            Console.WriteLine($"Conta: {numeroConta}");
            Console.WriteLine("Digite sua senha: ");
            while (numeroTentativa <= 3)
            {
                senhaDigitada = Console.ReadLine();
                if (senhaDigitada == senha)
                {
                    Console.WriteLine("Senha correta, acesso permitido\n" +
                        "aguarde um momento.\n" +
                        "...");
                    acessoPermitido = true;
                    break;
                }
                if(numeroTentativa == 3 || senhaDigitada != senha)
                {
                    Console.WriteLine("Acesso Negado, entre em contato com sua agencia bancaria");
                    acessoPermitido = false;
                    break;
                }
            }
            return acessoPermitido;


        }


        private void Deposito()
        { }

        private string Gerarsenha()
        {
            Random random = new Random();
            string senhaGerada = random.Next(1000, 9999).ToString();
            return senhaGerada;
        }
            static string GerarNumeroCartao()
        {
            Random random = new Random();
            string numeroGerado = "";

            for (int i = 0; i < 4; i++)
            {
                numeroGerado += random.Next(1000, 9999).ToString();
                if (i < 3) numeroGerado += " ";
            }
            return numeroGerado;
        }
        private string GerarCartaoUnico()
        {
            string numero;
            do
            {
                numero = GerarNumeroCartao();
            } while (numerosGerados.Contains(numero));

            numerosGerados.Add(numero);
            return numero;
        }
        
    }
}
