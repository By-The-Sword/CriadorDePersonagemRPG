
using System;

namespace CriadorDePersonagemRPG;
class Program
{
    static void Main()
    {
        int vida = 10;
        int estamina;
        int forca;
        int mana;
        int reflexo;
        int danoArma;
        int atkN1;
        int atkN2;
        int atkN3;

        string nomePersonagem;
        string nomePersonagem2;
        string escolhaClasse;
        string escolhaRaca;
        string passiva;
        string arma;
        string atkS1;
        string atkS2;
        string atkS3;

        CriadorDeRaca qualquercoisa = new CriadorDeRaca();
        qualquercoisa.vida(vida);

        // instância criada, chama o metodo e exibe no console
        CriadorDeNome criadorDeNome = new CriadorDeNome();
        nomePersonagem = criadorDeNome.ObterNomeDoPersonagem(); 

        Console.WriteLine($"O nome do personagem é: {nomePersonagem}");
        // fim.
    }
}