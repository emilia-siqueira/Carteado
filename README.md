# Carteado
Aulas Práticas sobre POO: Problema Gerador : Jogo de cartas

## Projeto de jogo de cartas

# 🃏 Cartas em Jogo

Bem-vindo ao **Cartas em Jogo**, um sistema interativo em C# onde dois jogadores disputam partidas de cartas em diferentes modos de jogo. Ideal para fins educacionais, este projeto demonstra o uso de **orientação a objetos**, **interfaces**, **herança**, **polimorfismo** e **princípios SOLID**.

---

## 🎮 Modos de Jogo

- **1. Maior Carta:**  
  Cada jogador recebe uma carta. Ganha quem tiver a carta com maior valor.

- **2. Par ou Ímpar:**  
  Cada jogador recebe uma carta. Soma-se os valores.  
  - Se a soma for **par**, o jogador 1 vence.  
  - Se a soma for **ímpar**, o jogador 2 vence.

- **3. Batalha:**  
  Cada jogador recebe **três cartas**. Soma-se os valores.  
  Quem tiver a **maior soma total** vence.

---

## 🧠 Conceitos de Programação Utilizados

- **Programação Genérica**: Todas as classes de jogo e baralho utilizam `generics` (`<T>`) com restrição à interface `IPontuacao`.
- **Interfaces**: 
  - `IPontuacao`
  - `IBaralho<T>`
  - `IJogador<T>`
- **Herança e Polimorfismo**:  
  A classe `JogoBase<T>` define um modelo comum para os jogos e é estendida pelas classes:
  - `JogoMaiorCarta<T>`
  - `JogoParOuImpar<T>`
  - `JogoBatalha<T>`
- **Encapsulamento**: As regras e manipulações de cartas estão bem isoladas em suas respectivas classes.

---

## 🧩 Estrutura do Projeto

```text
Carteado/
│
├── Program.cs                  # Menu principal e execução
├── Modelos/
│   ├── Carta.cs                # Carta base e com multiplicador
│   ├── Baralho.cs              # Controle do baralho
│   ├── Jogador.cs              # Jogador e suas cartas
│   └── Jogos/
│       ├── JogoBase.cs
│       ├── JogoMaiorCarta.cs
│       ├── JogoParOuImpar.cs
│       └── JogoBatalha.cs
└── Interfaces/
    ├── IPontuacao.cs
    ├── IJogador.cs
    └── IBaralho.cs