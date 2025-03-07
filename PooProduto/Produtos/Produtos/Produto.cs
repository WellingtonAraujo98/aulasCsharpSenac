using System.Globalization;

namespace Produtos
{
    internal class Produto // ao clicar em produto posso usar ctrl + . para alguns atalhos ()
    {               //como criar um construtor
        public string Nome;
        public double ValorProduto;
        public int Quantidade;

        public Produto()
        {
        }

        public Produto(string nome, int quantidade, double valorProduto)
        {
            this.Nome = nome; //this. para deixar claro que o atributo da classe recebera valor construtor
            this.ValorProduto = valorProduto;    
            this.Quantidade = quantidade; 
        }

        public void declararValores()
        {
            Console.Clear();
            Console.WriteLine("Digite um nome para o seu produto");
            Nome = Console.ReadLine();
            Console.WriteLine("Digite um valor para o seu produto");
            ValorProduto = Double.Parse(Console.ReadLine());
            Console.WriteLine("Digite um quantidade para o seu produto");
            Quantidade = int.Parse(Console.ReadLine());
        }
        public double GetTotalAmount()
        {
            return (ValorProduto * Quantidade);
        }

        public string GetDetailsProduct()
        {
            
            return ($"nome: {Nome} -  valor: R${ValorProduto.ToString("0.00",  CultureInfo.InvariantCulture)} - quantidade em estoque {Quantidade} - valor Total em estoque R${GetTotalAmount().ToString("0.00", CultureInfo.InvariantCulture)}");
        }
    }
    
}
