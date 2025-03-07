namespace Produtos
{
    internal class Retangulo
    {
        double largura; 
        double altura;

        public Retangulo(double largura, double altura)
        {
            this.largura = largura;
            this.altura = altura;
        }

        public double Area()
        {
            return largura * altura;
        }

        public double Perimetro()
        {
            return (2 * (largura + altura));
        }

    }
    internal class RetanguloSemConstrutor 
    {
        public double largura;
        public double altura;

        public double Area()
        {
            return largura * altura;
        }

        public double Perimetro()
        {
            return (2 * (largura + altura));
        }
    }

}
