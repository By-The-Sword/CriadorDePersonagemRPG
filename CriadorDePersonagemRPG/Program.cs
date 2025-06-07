namespace CriadorDePersonagemRPG
{
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
            string restart;


           // List<int> atributos = new List<string>(vida,estamina,forca,mana,reflexo);
           // List<string> personagem = new List<string>(nomePersonagem,escolhaClasse,escolhaRaca);

           // atributos mostre = new MostrarAtributos();
            


                while (true)
                {
                    // Instanciar o criador de nome e obter o nome do personagem
                    CriadorDeNome criadorDeNome = new CriadorDeNome();
                    nomePersonagem = criadorDeNome.ObterNomeDoPersonagem();

                    Console.WriteLine($"O nome do personagem é: {nomePersonagem}");
                    Console.Clear(); // Limpa o console após a escolha
                    // fim.}

                    // Instanciar o criador de raça e obter a escolha
                    CriadorDeRaca criadorDeRaca = new CriadorDeRaca();
                    escolhaRaca = criadorDeRaca.escolhaRaca();
                    Console.WriteLine($"Você escolheu a raça: {escolhaRaca}");
                    Console.ReadLine();
                    Console.Clear(); // Limpa o console após a escolha

                    Console.WriteLine("Você deseja Reiniciar seu personagem? (sim/não)");
                    restart = Console.ReadLine().ToLower();
                    if (restart == "sim")
                    {
                        Console.Clear(); // Limpa o console após a escolha
                        continue;
                    }
                    else if (restart == "não" || restart == "nao")
                    {
                        Console.Clear(); // Limpa o console após a escolha
                        break;
                    }

                }
        }
    }
}