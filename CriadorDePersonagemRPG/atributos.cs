using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CriadorDePersonagemRPG
{
    internal class Atributos
    {
        public void MostrarAtributos(List<int> atributosP, List<string> personagemP) // metodo recebe duas listas.
        {
            // Prints para mostrar na tela os atributos e caracteristicas do personagem
            Console.WriteLine("Vida: " + atributosP[0]);
            Console.WriteLine("Estamina: " + atributosP[1]);
            Console.WriteLine("Força: " + atributosP[2]);
            Console.WriteLine("Mana: " + atributosP[3]);
            Console.WriteLine("Reflexo: " + atributosP[4]);
            Console.WriteLine("\n");
            Console.WriteLine("Nome: " + personagemP[0]);
            Console.WriteLine("Classe: " + personagemP[1]);
            Console.WriteLine("Raça: " + personagemP[2]);

        }
    }
}
