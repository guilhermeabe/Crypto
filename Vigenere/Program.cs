using System;

namespace Vigenere
{
    class Program
    {
        static void Main(string[] args)
        {
            int escolha = 1;
            while (escolha != 0)
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("[1] Criptografar");
                Console.WriteLine("[2] Descriptografar");
                Console.WriteLine("[0] Sair");
                switch (Console.ReadLine())
                {
                    case "0":
                        sairPrograma();
                        escolha = 0;
                        break;
                    case "1":
                        codificarMensagem();
                        limparTela();
                        break;
                    case "2":
                        descodificarMensagem();
                        limparTela();
                        break;
                }

            }

        }
        static void limparTela()
        {
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
        static void sairPrograma()
        {

            Console.WriteLine();
            Console.WriteLine(" Você saiu do programa. Pressione qualquer tecla para sair");
            Console.ReadKey();

        }
        static void codificarMensagem()
        {
            string mensagem, senha, codigo;
            Console.WriteLine(" Digite a mensagem para codificar: ");
            mensagem = Console.ReadLine();
            Console.WriteLine(" Digite a senha: ");
            senha = Console.ReadLine();
            codigo = Cifrar(mensagem, senha);
            Console.WriteLine(" Mensagem codificada em Cifra de Vigenère: " + codigo);
        }
        static void descodificarMensagem()
        {
            string mensagem, senha, codigo;
            Console.WriteLine(" Digite a mensagem para descodificar: ");
            mensagem = Console.ReadLine();
            Console.WriteLine(" Digite a senha: ");
            senha = Console.ReadLine();
            codigo = Decifrar(mensagem, senha);
            Console.WriteLine(" Mensagem descodificada em Cifra de Vigenère: " + codigo);
        }


        static string Cifrar(string mensagem, string senha)
        {
            var codigo = "";
            for (int i = 0; i < mensagem.Length; i++)
            {
                char letraMsg = char.ToUpper(mensagem[i]);
                if (letraMsg < 'A' || letraMsg > 'Z')
                    continue;
                char letraSenha = char.ToUpper(senha[i % senha.Length]);
                int final = (letraMsg + letraSenha) % 26;
                final += 'A';
                codigo += (char)(final);
            }
            return codigo;
        }
        static string Decifrar(string mensagem, string senha)
        {
            var codigo = "";
            for (int i = 0; i < mensagem.Length; i++)
            {
                char letraMsg = char.ToUpper(mensagem[i]);
                if (letraMsg < 'A' || letraMsg > 'Z')
                    continue;
                char letraSenha = char.ToUpper(senha[i % senha.Length]);
                int final = (letraMsg - letraSenha + 26) % 26;
                final += 'A';
                codigo += (char)(final);
            }
            return codigo;
        }
    }
}