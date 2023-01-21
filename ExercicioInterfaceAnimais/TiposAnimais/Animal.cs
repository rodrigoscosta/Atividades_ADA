using System;

public abstract class Animal
{
  public string Nome { get; set; }
  public DateTime DataNascimento { get; set; }
  public char Sexo { get; set; }
  public int Idade { get; set; }
  public bool Carnivoro { get; set; }
  public bool Peconhento { get; set; }

  public void Movimentar()
  {
    Console.WriteLine($"{Nome} está se movimentando!");
    Console.WriteLine();
  }

  public void Comunicar()
  {
    Console.WriteLine($"{Nome} está se comunicando!");
    Console.WriteLine();
  }

  public void Alimentar()
  {
    Console.WriteLine($"{Nome} está se alimentando!");
    Console.WriteLine();
  } 
}