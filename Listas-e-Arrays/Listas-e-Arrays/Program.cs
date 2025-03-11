using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_e_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tipo[]  nome = new tipo[tamanho]
            int[] myArray = new int[5];
            string[] arrayFruits = new string[3];

            //array serve  para mesmo tipo de arquivos

            string[] arrayFruits2 = {"Banana", "Maçã-", "Pera"};
            arrayFruits[0] = "Banana";
            arrayFruits[1] = "Uva";
            arrayFruits[2] = "Pera";

            arrayFruits2[1] = arrayFruits2[1].Replace("ç", "c").Replace("ã","a").Replace("-","");
            Console.WriteLine(arrayFruits2[1]);

            double[] notas = new double[3];
            Console.WriteLine(arrayFruits);

            string emailWell = "Wellington.a14@hotmail.com";
            Console.WriteLine(emailWell.Contains("@"));


            //  n precisara declarar numero de vetores antecipadamente
            List<string> fruitListFavWell = new List<string>();
            fruitListFavWell.Add("Pera");
            fruitListFavWell.Add("Morango");
            fruitListFavWell.Add("Banana");
            fruitListFavWell.Add("Abacate");
            fruitListFavWell.Remove("Abacate");

            Console.Clear();
            foreach (string fruit in arrayFruits) { 
                Console.WriteLine(fruit);
            }

            Console.WriteLine("\n");
            fruitListFavWell.ForEach(fruta => Console.WriteLine(fruta));

            Console.Clear();

            Aluno aluno1 = new Aluno("Well", 51841, "Programação", "Wellington.a14@hotmail.com", "(11)919361287");
            Aluno aluno2 = new Aluno("Clebin", 51801, "Programação", "Wellton.a14@hotmail.com", "(11)910000287");
            Aluno aluno3 = new Aluno("ana", 57771, "Programação", "Welltsdadn4@hotmail.com", "(11)917777777");

            List<Aluno> listaAlunos = new List<Aluno>();
            listaAlunos.Add(aluno1);
            listaAlunos.Add(aluno2);
            listaAlunos.Add(aluno3);

            foreach (Aluno aluno in listaAlunos) 
            {
                Console.WriteLine($"Nome: {aluno.Nome}");
                Console.WriteLine($"E-mail: {aluno.Email}");
                Console.WriteLine($"Matricula: {aluno.Matricula}");
                Console.WriteLine($"Numero: {aluno.Telefone}");
                Console.WriteLine("");
            }

        }
    }
}
