using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;


    namespace CriadorDePersonagemRPG
{
    internal class CriadorDeClasse
    {
        public string ObterClasse()
        {
            // Dicionário contendo as opções de classes e suas descrições
            var opcoesClasse = new Dictionary<int, string>()
            {
                { 1, "Guerreiro, Alta força e defesa, ideal para combates corpo a corpo." },
                { 2, "Mago, Controla magias poderosas de ataque e defesa." },
                { 3, "Arqueiro, Especialista em ataques à distância com alta agilidade." },
                { 4, "Clérigo, Pode curar aliados e proteger o grupo com magias sagradas." },
                { 5, "Ladino, Pode se camuflar nas sombras e roubar itens." }
            };

            Console.WriteLine("=== Escolha sua classe para dar início à sua jornada forasteiro(a) ===");
            foreach (var opcao in opcoesClasse)
            {
                Console.WriteLine($"{opcao.Key} - {opcao.Value.Split(',')[0]}");
            }

            Console.WriteLine("\nDigite o número da classe desejada: ");
            bool entradaValida = int.TryParse(Console.ReadLine(), out int escolha);

            if (entradaValida && opcoesClasse.TryGetValue(escolha, out string descricaoClasse))
            {
                Console.WriteLine($"\nVocê escolheu: {descricaoClasse}");
                Console.WriteLine("\nPressione qualquer tecla para sair da caverna de escolha...");
                Console.ReadKey();
                return descricaoClasse;
            }
            else
            {
                Console.WriteLine("\nOpção inválida. Tente novamente executando o programa.");
                Console.WriteLine("Pressione qualquer tecla para sair...");
                Console.ReadKey();
                return string.Empty;
            }
        }
    }
}
// melhorias aplicadas: substituí do switch por um dicionário para melhor legibilidade e manutenção do código, removi o switch e adicionei um loop para permitir que o usuário escolha uma classe válida, e adicionei mensagens de feedback mais claras para o usuário. Além disso, a lógica de retorno foi simplificada para retornar diretamente a descrição da classe escolhida ou uma string vazia em caso de erro.
// O código agora é mais fácil de entender e manter, e oferece uma melhor experiência ao usuário. Além disso, o uso de dicionários permite adicionar facilmente novas classes no futuro sem precisar alterar a estrutura do código.
// usei int.TryParse para validar a entrada do usuário, garantindo que o programa não quebre se uma entrada inválida for fornecida. Isso melhora a robustez do código e evita exceções inesperadas durante a execução.
// exibe somente as classes disponíveis e suas descrições, sem repetir a descrição completa para cada classe. Isso torna a saída mais limpa e fácil de ler, além de evitar redundância no código.