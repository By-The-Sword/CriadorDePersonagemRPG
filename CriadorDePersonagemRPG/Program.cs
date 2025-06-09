namespace CriadorDePersonagemRPG
{
    class Program
    {
        static void Main()
        {
            // Variáveis de atributos do personagem.
            int vida = 10;
            int estamina = 0;
            int forca = 0;
            int mana = 0;
            int reflexo = 0;
            int danoArma;
            int atkN1;
            int atkN2;
            int atkN3;
            int menu;

            // Variáveis de personagem.
            string nomePersonagem = "";
            string nomePersonagem2 = "";
            string escolhaClasse = "";
            string escolhaRaca = "gay";
            string passiva;
            string arma;
            string atkS1;
            string atkS2;
            string atkS3;
            string restart;


            // Criação de instancias.
            CriadorDeNome criadorDeNome = new CriadorDeNome();
            CriadorDeRaca criadorDeRaca = new CriadorDeRaca();
            Atributos mostrarAtributos = new Atributos();


            // Sistema de Arrepemdimento.
            while (true) 
            {        
                     // Usando o método nomePersonagem para obter o nome do personagem.
                     nomePersonagem = criadorDeNome.ObterNomeDoPersonagem(); // Cria objeto CriadorDeNome e chama o método ObterNomeDoPersonagem
                     Console.WriteLine($"O nome do personagem é: {nomePersonagem}");
                     Console.ReadLine(); // Press enter to continue
                     Console.Clear(); // Limpa o console após a escolha

                     // Usando o método escolhaRaca para obter a classe do personagem.
                     escolhaRaca = criadorDeRaca.escolhaRaca(); 
                     Console.WriteLine($"Você escolheu a raça: {escolhaRaca}");
                     Console.ReadLine(); 
                     Console.Clear(); 




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
          
            
            
            // Sistema amador de Menu, pode ser substituido por uma classe Menu
           while (true){
            Console.WriteLine("/////////////// Menu ///////////////");
            Console.WriteLine("1 - Mostrar atributos");
            Console.WriteLine("2 - Compre a Dlc para ter acesso");
            Console.WriteLine("3 - Compre a Dlc para ter acesso tambem pobre");
            Console.WriteLine("4 - Sair");
            menu = int.Parse(Console.ReadLine());
                switch (menu){
                    case 1:
                        Console.Clear();
                        List<int> atributosP = new List<int> { vida, estamina, forca, mana, reflexo }; // lista que guarda os dados de int
                        List<string> personagemP = new List<string> { nomePersonagem, escolhaClasse, escolhaRaca }; // lista que guarda os dados de string
                        mostrarAtributos.MostrarAtributos(atributosP, personagemP); //mostra os atributos e personagem
                        Console.ReadLine(); // Press enter to continue
                        Console.Clear(); // Limpa o console após a escolha
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Compre a DLC para ter acesso");
                        Console.ReadLine(); // Press enter to continue
                        Console.Clear(); // Limpa o console após a escolha
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Vai te fuder eu falei pra ir comprar Lopes");
                        Console.ReadLine(); // Press enter to continue
                        Console.Clear(); // Limpa o console após a escolha
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Saindo do jogo...");
                        Console.ReadLine(); // Press enter to continue
                        Console.Clear(); // Limpa o console após a escolha
                        return; // Encerra o programa
                    default:
                        Console.Clear();
                        Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                        Console.ReadLine(); // Press enter to continue
                        Console.Clear(); // Limpa o console após a escolha
                        return; // Encerra o programa
                }
            }
        }
    }
}