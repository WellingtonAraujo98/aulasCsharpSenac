namespace Produtos
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Produto produto1 = new Produto(nome: "Macarrão", quantidade: 100, valorProduto: 3.99 );
            Produto produto2 = new Produto("Bolo", 47, 30.00);
            Produto produto3 = new Produto("leite", 500, 4.99);
            // Produto produto4 = new Produto();
            // produto4.declararValores();

            Console.Clear();
            Console.WriteLine("-**-**-**-**-**-**-**-**-**-**-**-**-**-**-**-**-**-**-");
            Console.WriteLine(produto1.GetDetailsProduct());
            Console.WriteLine(produto2.GetDetailsProduct());
            Console.WriteLine(produto3.GetDetailsProduct());
            //Console.WriteLine(produto4.GetDetailsProduct());
            Console.WriteLine("-**-**-**-**-**-**-**-**-**-**-**-**-**-**-**-**-**-**-");
            Console.WriteLine();
            Console.WriteLine("Trabalhando com retangulo com construtor: ");
            Retangulo meuRetangulo = new Retangulo(4, 7);
            Console.WriteLine($"Area do retangulo {meuRetangulo.Area().ToString("0.00")}, Perimetro do Retangulo {meuRetangulo.Perimetro().ToString("0.00")}");
            Console.WriteLine("Trabalhando com retangulo sem construtor: ");
            RetanguloSemConstrutor meuRetangulo2 = new RetanguloSemConstrutor();
            double largura = 6;
            double altura = 8;
            meuRetangulo2.largura = (largura);
            meuRetangulo2.altura = (altura);
            Console.WriteLine($"Area do retangulo {meuRetangulo2.Area().ToString("0.00")}, Perimetro do Retangulo {meuRetangulo2.Perimetro().ToString("0.00")}");
        }

    }
}
