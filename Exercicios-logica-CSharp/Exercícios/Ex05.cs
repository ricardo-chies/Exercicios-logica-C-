using System;


namespace Exercicios_logica_CSharp.Exercícios
{
    class Ex05
    {
        public static void Main(string[] args)
        {
            //Exercício 5

            Console.WriteLine("Digite uma fruta");
            string fruta = (Console.ReadLine());

            string primeiraLetra = LetraFruta(fruta);

            Console.WriteLine("A primeira letra da fruta {0} é {1}", fruta, primeiraLetra);
            Console.ReadLine();


        }

        public static string LetraFruta(string fruta)
        {
            string primeiraLetra = fruta[0].ToString();
            return primeiraLetra;

        }
    }
}