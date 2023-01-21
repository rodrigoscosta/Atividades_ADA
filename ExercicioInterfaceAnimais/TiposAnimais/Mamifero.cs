using System;

public abstract class Mamifero : Animal
{
  public int QtdMamas { get; set; }
  public bool Pelos { get; set; }
  public string CorDoPelo { get; set; }

  public void Amamentar()
  {
    Console.WriteLine($"{Nome} está amamentando!");
    Console.WriteLine();
  }
  
}