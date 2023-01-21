using System;

public class Jacare : Reptil, IAquatico, IOviparo
{
  public bool ViveEmTerra { get; set; }
  public bool Mergulho { get; set; }
  public bool AguaDoce { get; set; }

  public void Botar()
  {
    Console.WriteLine("O Jacaré está botando ovos.");
    Console.WriteLine();
  }
  
  public void Chocar()
  {
    Console.WriteLine("Os ovos dos Jacarés levam 15 dias para chocarem!");
    Console.WriteLine();
  }

  public Jacare()
  {
    Nome = "Jack";
    DataNascimento = new DateTime(2000, 05, 16);
    Sexo = 'M';
    Carnivoro = true;
    Peconhento = false;

    TemEscamas = true;
    TemCasco = false;

    ViveEmTerra = true;
    Mergulho = true;
    AguaDoce = true;

    Console.WriteLine("Consegue Viver na Terra: " + ViveEmTerra);
    Console.WriteLine("Consegue Mergulhar: " + Mergulho);
    Console.WriteLine("Vive em Agua Doce: " + AguaDoce);
    Console.WriteLine();

    Botar();
    Chocar();
    Console.WriteLine();

    Movimentar();
    Comunicar();
    Alimentar();
  }
}