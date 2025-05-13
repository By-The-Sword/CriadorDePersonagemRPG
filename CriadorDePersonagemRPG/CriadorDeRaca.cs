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
        public void vida(int vida)
        {
            Console.WriteLine("Escolha uma raça: ");
            Console.WriteLine("1 - Humano");
            Console.WriteLine("2 - Elfo");
            Console.WriteLine("3 - Anão");
            Console.WriteLine("4 - Orc");
            Console.WriteLine("5 - Draconiano");
            Console.WriteLine("6 - Khajiit");
        }
    }
}
