
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriadorDePersonagemRPG
{
    internal class Arma
    { 
        public class DetalhesArma
        {
            public string nomeArma { get; set; } // nome da arma
            public string psArma { get; set; } // descrição da passiva da arma
            public int danoArma { get; set; } // dano da arma
            public int pnArma { get; set; } // dano da passiva da arma
            public int valor { get; set; } // preço da arma
            public string classeArma { get; set; } // classe da arma

            // Construtor da classe DetalhesArma
            public DetalhesArma(string nome, string passivaDesc, int dano, int danoPassiva, int preco, string classe)
            {
                nomeArma = nome;
                psArma = passivaDesc;
                danoArma = dano;
                pnArma = danoPassiva;
                valor = preco;
                classeArma = classe;
            }
        }
    }
}
