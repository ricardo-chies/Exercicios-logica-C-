using System;


namespace Exercicios_logica_CSharp.Exercícios
{
    class Ex10
    {
        public static void Main(string[] args)
        {
            //Exercício 10

            Console.WriteLine("Vamos descobrir o resultado da media da soma entre os números 10 a 90");
            DezA90();
            Console.ReadLine();
        }

        public static void DezA90()
        {
            int inicio = 10, final = 90, soma = 0;

            for (int i = inicio; i <= final; i++)
            {
                soma = soma + i;
            }
            Console.WriteLine("O resultado da soma é: " + soma);

            int media = soma / 80;
            Console.WriteLine("A média é " + media);


        }
    }
}