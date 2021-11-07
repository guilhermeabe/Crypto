using System;

namespace Crypto
{
    class Program
    {

        static void Main(string[] args)
        {
            string msg;
            int escolha = 1;
            while (escolha != 0)
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("[1] Criptografar");
                Console.WriteLine("[2] Descriptografar");
                Console.WriteLine("[0] Sair");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Por favor, insira o texto a ser codificado.");
                        msg = Console.ReadLine();
                        Console.WriteLine("Seu texto foi codificado com sucesso!");
                        Console.WriteLine(receberMensagem(msg));
                        limparTela();
                        break;
                    case "2":
                        Console.WriteLine("Por favor, insira o texto a ser descodificado.");
                        msg = Console.ReadLine();
                        Console.WriteLine("Seu texto foi descodificado com sucesso!");
                        Console.WriteLine(receberMensagem(msg));
                        limparTela();
                        break;
                     case "0":
                        escolha = 0;
                        Console.WriteLine();
                        Console.WriteLine(" Você saiu do programa. Pressione qualquer tecla para sair");
                        Console.ReadKey();
                        break;
                }
            }
            static void limparTela()
            {
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
        }
         static string receberMensagem(string msg)
        {
            char[] mensagem = msg.ToCharArray();
            for (int i = 0; i < mensagem.Length; i++)
            {
                int number = (int)mensagem[i];

                if (number >= 'a' && number <= 'z')
                {
                    if (number > 'm')
                    {
                        number -= 13;
                    }
                    else
                    {
                        number += 13;
                    }
                }
                else if (number >= 'A' && number <= 'Z')
                {
                    if (number > 'M')
                    {
                        number -= 13;
                    }
                    else
                    {
                        number += 13;
                    }
                }
                mensagem[i] = (char)number;
            }
            return new string(mensagem);
        }
    }
}
 