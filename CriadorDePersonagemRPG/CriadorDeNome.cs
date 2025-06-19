using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriadorDePersonagemRPG
{
    internal class CriadorDeNome
    {
        public string ObterNomeDoPersonagem()
        { // declaração das variavéis
            string nomePersonagem = "";
            string nomePersonagem2 = "";
            bool nomeConfirmado = false;
        //mensagem de boas vindas, talvez seja pertinente tirar e colocar na primeira parte do codigo que vai ser exibida no console
            Console.WriteLine("Bem vindo safado!");
            // inicio do loop
            while (!nomeConfirmado)
            {
                Console.WriteLine("\nPor Favor, digite o nome de seu personagem");
                nomePersonagem = Console.ReadLine();
                // confirmação de nome
                Console.WriteLine($"\nVocê digitou: {nomePersonagem}.");
                Console.Write("Este nome está correto? (sim/não): ");
                nomePersonagem2 = Console.ReadLine() .ToLower();

                if (nomePersonagem2 == "sim") 
                {
                    nomeConfirmado=true;
                    Console.WriteLine("\nNome confirmado!");
                    Console.WriteLine();

                }

                else if (nomePersonagem2 == "não") 
                {
                    Console.WriteLine("\nNome incorreto. Por favor, tenta dnv ai cara.");
                }

                else
                {
                    Console.WriteLine("\nResposta inválida. Digite 'sim' ou 'não'.");
                    Console.ReadKey();
                    Console.Clear();
                }
                // fim do loop
                
            }

            return nomePersonagem;
         

        }
    }
}
