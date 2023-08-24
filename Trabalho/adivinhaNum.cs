using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho
{
    public class AdivinhaNum
    {
        public static void JogarJogo()
        {
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 101);
            int tentativas = 0;
            int tentativaUsuario;

            Console.WriteLine("Bem-vindo ao jogo de adivinhação!");
            Console.WriteLine("Eu escolhi um número entre 1 e 100. Tente adivinhar qual é!");

            do
            {
                Console.Write("Digite sua tentativa: ");
                tentativaUsuario = Convert.ToInt32(Console.ReadLine());
                tentativas++;

                if (tentativaUsuario < numeroAleatorio)
                {
                    Console.WriteLine("O número que você está procurando é maior.");
                }
                else if (tentativaUsuario > numeroAleatorio)
                {
                    Console.WriteLine("O número que você está procurando é menor.");
                }
                else
                {
                    Console.WriteLine($"Parabéns! Você adivinhou o número {numeroAleatorio} em {tentativas} tentativas!");
                }
            } while (tentativas < 11);

            Console.WriteLine("Obrigado por jogar.");
        }
    }
}
