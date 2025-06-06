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

        CriadorDeRaca criador = new CriadorDeRaca();
        escolhaRaca = criador.escolhaRaca();
        // Solicita ao usuário que escolha uma raça e valida a entrada
        Console.WriteLine($"Você escolheu a raça: {escolhaRaca}");// Exibe a raça escolhida pelo usuário
        Console.ReadLine();// Aguarda o usuário pressionar Enter para continuar
    }
}
