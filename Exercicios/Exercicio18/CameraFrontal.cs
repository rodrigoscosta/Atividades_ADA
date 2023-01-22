using System;

class CameraFrontal : Camera
{
  public double ResolucaoAtual { get; set; }

  public CameraFrontal()
  {
    Random random = new Random();

    ResolucaoMaxima = 8;
    ResolucaoAtual = random.Next(5, 9);
  }
}