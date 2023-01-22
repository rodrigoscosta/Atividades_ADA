using System;

class Seriado : Programa
{
  public int NumeroEpisodios { get; set; }
  public int AnoInicio { get; set; }
  public int AnoFim { get; set; }
  
  public Seriado()
  {
    Random random = new Random();

    Console.WriteLine($"Genero: {Genero}");

    NumeroEpisodios = random.Next(1, 101);
    Console.WriteLine($"Numero de Episodios: {NumeroEpisodios}");

    AnoInicio = random.Next(2000, 2022);
    Console.WriteLine($"Ano de Inicio: {AnoInicio}");

    AnoFim = random.Next(AnoInicio, 2023);
    Console.WriteLine($"Ano de Fim: {AnoFim}");
  }
}