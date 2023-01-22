using System;

class Sorteio
{
  public int QtdInscricoes { get; set; }

  public void SorteiaPremio()
  {
    Random random = new Random();
    int vencedor = random.Next(1, QtdInscricoes+1);
    Console.WriteLine($"O vencedor é o numero de inscrição {vencedor}");
  }
}