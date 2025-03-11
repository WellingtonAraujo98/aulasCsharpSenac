using System.Globalization;


namespace contaCorrente
{
    internal class ContaCorrente
    {
        CultureInfo culturaBrasileira = new CultureInfo("pt-BR");
        string numeroConta;
        string titular;
        double Saldo = 13.5;
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
            int opcaoMenu;
            while (possoAcessar = true)
            {
                Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
                Console.WriteLine($"\n\n\nBem vindo {titular} \n" +
                    $"Conta: {numeroConta}\n" +
                    $"Saldo atual: {Saldo.ToString("C", culturaBrasileira)} \n" +
                    $"Para fazer um deposito digite (1): \n" +
                    $"Para fazer um saque digite (2): \n" +
                    $"Para fechar o menu digite (0)");
                opcaoMenu = int.Parse(Console.ReadLine());
                switch (opcaoMenu)
                {
                    case 0: 
                        Console.WriteLine("Obrigado por utilizar o app, até a proxima.");
                        possoAcessar = false;
                        break;

                    case 1:
                        Deposito();
                        break;
                    case 2:
                        Saque();
                        break;
                }
                if (possoAcessar == false)
                {
                    break;
                }

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
        { 
            
            Console.WriteLine("Quanto você deseja depositar na conta ? ");
            double valorDeposito = double.Parse(Console.ReadLine().Replace(".",","));
            Saldo += valorDeposito;
            Console.WriteLine($"O saldo atual da conta é de {Saldo.ToString("C", culturaBrasileira)}");
        }

        private void Saque()
        {
            Console.WriteLine($"Quanto você deseja sacar da sua conta? valor disponivel: {Saldo.ToString("C", culturaBrasileira)}");
            double valorSaque = double.Parse(Console.ReadLine().Replace(".", ","));
            if (valorSaque <= Saldo)
            {
                Saldo -= valorSaque;
                Console.WriteLine($"Novo valor na conta: {Saldo.ToString("C", culturaBrasileira)}");
            }
            else
            {
                Console.WriteLine("Valor indisponivel para saque");
            }
        }


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
