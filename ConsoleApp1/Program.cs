using System;
using System.Globalization;
namespace PrimeiroProjeto
{
    internal class Program
    {       
        static void Main(string[] args)
        {

            string produto1 = "computador";
            string produto2 = "Messa de escritorio";
            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';
            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos");
            Console.WriteLine("{0},cujo preço e {1}",produto1,preco1);
            Console.WriteLine("{0},cujo o preço e {1}", produto2, preco2);
            Console.WriteLine("Registro: {0} anos de idade, codigo{1} e genero:{2}");
            Console.WriteLine(medida.ToString("F8"));
            Console.WriteLine(medida.ToString("F3"));
            Console.WriteLine(medida.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}