using System;

class Programa
{
  public int Duracao { get; set; }
  public string Genero { get; set; }

  public Programa()
  {
    Random random = new Random();

    string[] generos = new string[5] { "Ação", "Comedia", "Suspense", "Drama", "Terror" };
    Genero = generos[random.Next(0, 5)];

    Duracao = random.Next(90, 180);
  }
}