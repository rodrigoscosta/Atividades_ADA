using System;

public abstract class Ave : Animal
{
  public bool Rapina { get; set; }
  public string CorPena { get; set; }

  public void Ciscar()
  {
    Console.WriteLine($"{Nome} está ciscando!");
    Console.WriteLine();
  }
}