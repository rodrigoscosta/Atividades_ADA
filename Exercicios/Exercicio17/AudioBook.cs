using System;

class AudioBook : Livro
{
  public int Duracao { get; set; }

  public AudioBook(string autor, int ano) : base(autor, ano)
  {
    Random random = new Random();

    Duracao = random.Next(30, 420);
    Console.WriteLine($"Duração do AudioBook: {Duracao}min");

  }
}