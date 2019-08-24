using System;

namespace MeuPrimeiroTerminal
{ class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual time ganhou a ultima copa?");

            string[] times = new string[4];
            times[0] = "brasil";
            times[1] = "franca";
            times[2] = "mexico";
            times[3] = "alemanha";

            for (int i = 0; i < 4; i++)
                Console.WriteLine($"{i} - {times[i]}");

            int retorno = EhVencedor(1);
            if(retorno < 1)
            Console.WriteLine("Parabens, voce acertou");

            else
            Console.WriteLine("Parabens, voce acertou");
            Console.WriteLine($"Mas errou - {retorno} ");
            Console.ReadLine();
        }

        public static int EhVencedor(int vencedor)
        {
            int c = 0;
            bool acertou = false;

            while (acertou == false)
            {
                Console.WriteLine("Digite o indice: ");
                Console.WriteLine($"Numero de tentativa - {++c}" );

                string opcaoDoUsuarioTexto = Console.ReadLine();
                int opcaoDoUsuario = Convert.ToInt32(opcaoDoUsuarioTexto);

                if (opcaoDoUsuario == vencedor)
                {
                    acertou = true;
                }
                else
                    Console.WriteLine("Voce errou");
            }
            return c;

        }
    }
}

