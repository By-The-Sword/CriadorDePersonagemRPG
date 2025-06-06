using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriadorDePersonagemRPG
{
    internal class CriadorDeRaca
    {
        public string escolhaRaca()
        {
            Console.WriteLine("Escolha uma raça: ");
            Console.WriteLine("1 - Humano");
            Console.WriteLine("2 - Elfo");
            Console.WriteLine("3 - Anão");
            Console.WriteLine("4 - Orc");
            Console.WriteLine("5 - Khajit");
            Console.Write("Escolha sua raça: ");
            // Lê a escolha do usuário e valida se é um número entre 1 e 5
            int escolha;
            while (!int.TryParse(Console.ReadLine(), out escolha) || escolha < 1 || escolha > 5)// Verifica se a entrada é válida
            {
                Console.Write("Opção inválida. Escolha um número entre 1 e 5: ");// Solicita uma nova entrada
            }
            // Retorna a raça escolhida
            string[] racas = { "Humano", "Elfo", "Anão", "Orc", "Khajit" };// Array com as raças disponíveis
            return racas[escolha - 1];// Retorna a raça correspondente à escolha do usuário
        }
    }
}
