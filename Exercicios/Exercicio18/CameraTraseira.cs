using System;

class CameraTraseira : Camera
{
  public int ResolucaoAtual { get; set; }

  public CameraTraseira()
  {
    Random random = new Random();

    ResolucaoMaxima = 12;
    ResolucaoAtual = random.Next(8, 13);
  }
}