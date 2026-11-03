// Desenvolva o diagrama de classes do seu jogo favorito: pense em personagens, cenários, coisas utilizadas 
// pelos personagens, poderes, habilidades, etc…
// ○ Dica: utilize um software de desenho.
// Sugestão: LucidChart
// O diagrama deve conter atributos, métodos, relacionamentos e cardinalidades.
// Implemente 3 classes principais do seu jogo (as que você escolher) e submeta os códigos das classes no questionário.

using System;

public class Personagem
{
    public string nome = "";
    public string 
    public int vida;

    public void Atacar(Personagem alvo)
    {
        alvo.vida -= this.ataque;
        Console.WriteLine($"{this.nome} atacou {alvo.nome} causando {this.ataque} de dano!");
    }
}