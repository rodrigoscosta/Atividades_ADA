using System;

class Filme : Programa
{
  public Filme()
  {
    Random random = new Random();

    Console.WriteLine($"Genero: {Genero}");
    Console.WriteLine($"Duração: {Duracao}min");
  }
}