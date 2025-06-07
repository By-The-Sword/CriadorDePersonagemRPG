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

            // Instanciar o criador de raça e obter a escolha
            CriadorDeRaca criadorDeRaca = new CriadorDeRaca();
            escolhaRaca = criadorDeRaca.escolhaRaca();
            Console.WriteLine($"Você escolheu a raça: {escolhaRaca}");
            Console.ReadLine();
            Console.Clear(); // Limpa o console após a escolha

            // Instanciar o criador de nome e obter o nome do personagem
            CriadorDeNome criadorDeNome = new CriadorDeNome();
            nomePersonagem = criadorDeNome.ObterNomeDoPersonagem();

            Console.WriteLine($"O nome do personagem é: {nomePersonagem}");
            // fim.
        }
    }
}