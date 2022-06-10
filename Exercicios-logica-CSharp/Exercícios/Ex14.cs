using System;


namespace Exercicios_logica_CSharp.Exercícios
{
    class Ex14
    {
        public //Exercício 14
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando programa");

            Console.WriteLine("Digite a idade do primeiro homem");
            int h1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a idade do segundo homem");
            int h2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a idade da primeira mulher");
            int m1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a idade da segunda mulher");
            int m2 = Convert.ToInt32(Console.ReadLine());

            Resolucao(h1, h2, m1, m2);
            Console.ReadKey();

        }

        public static void Resolucao(int h1, int h2, int m1, int m2)
        {
            if ((h1 > h2) && (m1 > m2))
            {
                int soma = h1 + m2;
                int produto = h2 * m1;
                Console.WriteLine("A soma das idades do homem mais velho com a mulher mais nova é {0}", soma);
                Console.WriteLine("O produto das idades do homem mais novo com a mulher mais velha é {0}", produto);
            }
            else if ((h2 > h1) && (m1 > m2))
            {
                int soma = h2 + m2;
                int produto = h1 * m1;
                Console.WriteLine("A soma das idades do homem mais velho com a mulher mais nova é {0}", soma);
                Console.WriteLine("O produto das idades do homem mais novo com a mulher mais velha é {0}", produto);
            }

            else if ((h2 > h1) && (m2 > m1))
            {
                int soma = h2 + m1;
                int produto = h1 * m2;
                Console.WriteLine("A soma das idades do homem mais velho com a mulher mais nova é {0}", soma);
                Console.WriteLine("O produto das idades do homem mais novo com a mulher mais velha é {0}", produto);
            }
            else if ((h1 > h2) && (m2 > m1))
            {
                int soma = h1 + m2;
                int produto = h2 * m1;
                Console.WriteLine("A soma das idades do homem mais velho com a mulher mais nova é {0}", soma);
                Console.WriteLine("O produto das idades do homem mais novo com a mulher mais velha é {0}", produto);
            }


        }
    }
}