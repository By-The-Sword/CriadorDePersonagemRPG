# CriadorDePersonagemRPG
## Repositório utilizado para a realização do primeiro projeto de preparação, sendo um programa de criação de personagem baseado no estilo RPG em C# 

### Explicações de variáveis e constantes que serão utiliziadas:

#### Inteiros:
- int vida > Referente a vida do personagem - classe/raça
- int estamina > Referente a estamina do personagem - classe/raça
- int forca > Referente a força do personagem - classe/raça
- int mana > Referente a mana do personagem - classe/raça
- int reflexo > Referente à chance de desvio de um ataque inimigo (Deve ser alterada apenas para a classe assassino) - classe/raça
- int danoArma > Referente ao dano da arma da classe - classe/raça
- int atkN1 > Referente à primeira habilidade da classe - classe
- int atkN2 > Referente à segunda habilidade da classe - classe
- int atkN3 > Referente à terceira habilidade da classe - classe
- int ouro > Referente à quantidade de dinheiro do personagem


#### Strings:
- string nomePersonagem > Referente ao nome do personagem
- string nomePersonagem2 > Referente à confirmação do nome do personagem
- string escolhaClasse > Referente à classe escolhida
- string escolhaRaca > Referente à raça escolhida
- string passiva > Referente à passiva da raça do personagem (cada raça tem uma passiva diferente que aumenta os atributos do mesmo) - raça
- string arma > Referente ao nome da arma, ex: machado, espada, cajado - classe
- string atkS1 > Referente ao nome da primeira habilidade da classe - classe
- string atkS2 > Referente ao nome da segunda habilidade da classe - classe
- string atkS3 > Referente ao nome da terceira habilidade da classe - classe
  
////////////////////////

16/05/25 João victor

PONTOS MELHORADOS:
- Criei a base de meu sistema, com o sistema de loop.

PONTOS A SEREM MELHORADOS:
- Falta algum comando para que o usuario consiga misturar letras maiusculas e minusculas.

////////////////////////

17/05/25   João Victor

PONTOS MELHORADOS

Sistema de nomes concluido

////////////////////////

06/06/25 Mota

- Criei o sistema de raças, com validação de entrada e um array mostrando as opções disponíveis.
- Adicionei comentários tanto a parte de raças quanto ao program.cs, para que fique bem claro o que foi feito.

////////////////////////

07/06/25 Mota 

PONTOS MELHORADOS:

- Resolvendo os erros do código
- consertando o program.cs

  ////////////////////////

07/06/25 20:23 Manoel

PONTOS MELHORADOS:

- Mudança do nome da classe atributos para Atributos
- Conclusão da classe que mostra os atributos
- Organização do código Main
- criação de um Menu para melhor entendimento do usuario
- Criação de comentarios para melhor entendimento do código

### Iniciação da Fase 2

#### Sistema de Cidade:
-> Armeiro:
Cada personagem terá 5 armas compráveis, seu valor respectivo será: 700, 1250, 2000, 2150, 3000
As armas serão divididas por classe.

strings:
- nomeArma > Referente ao nome da arma.
- psArma > Referente à descrição da passiva da arma

int:
- danoArma > Referente à quantidade de dano da arma
- pnArma > Referente ao dano da passiva da arma

-> Loja:
Os itens da loja serão encarados como consumíveis, serão os mesmos independente das classes.

Itens:
- Jarro de fogo > causa 200 de dano
-  Jarro de congelamento > causa 150 de dano + 50% de chance de congelamento do alvo
-  Jarro de eletricidade > causa 450 de dano
-  Poção de força > Duplica o valor da força
-  Poção de vida > Duplica o valor da vida
-  Poção de mana > Duplica o valor da mana
-  Poção de estamina > Duplica o valor da estamina
-  Estus > Cura o personagem

-> Arena: 
Opção que se refere à arena de combates no jogo, ao clicar nela o jogador terá a possibilidade de enfrentar 5 inimigos, o quais serão criados posteriormente

#### Associação de variáveis:

##### Jon:

-> Inteiros:
- int atkN1 > Referente à primeira habilidade da classe - classe
- int atkN2 > Referente à segunda habilidade da classe - classe
- int atkN3 > Referente à terceira habilidade da classe - classe

-> Strings:
- string atkS1 > Referente ao nome da primeira habilidade da classe - classe
- string atkS2 > Referente ao nome da segunda habilidade da classe - classe
- string atkS3 > Referente ao nome da terceira habilidade da classe - classe

##### Mota:

-> Strings:
- string passiva > Referente à passiva da raça do personagem (cada raça tem uma passiva diferente que aumenta os atributos do mesmo) - raça

##### Colab:

-> Inteiros:
- int vida > Referente a vida do personagem - classe/raça
- int estamina > Referente a estamina do personagem - classe/raça
- int forca > Referente a força do personagem - classe/raça
- int mana > Referente a mana do personagem - classe/raça
- int danoArma > Referente ao dano da arma INICIAL da classe - classe/raça

////////////////

João 18/06/25
PONTOS MELHORADOS:

Arquivos Arma e Armeiro criados, caracteristicas de armas setadas

PONTOS A MELHORAR: 

Falta criar armeiro

////////////////
