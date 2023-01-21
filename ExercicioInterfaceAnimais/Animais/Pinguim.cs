using System;

public class Pinguim : Ave, IAquatico, IOviparo
{
  public bool ViveEmTerra { get; set; }
  public bool Mergulho { get; set; }
  public bool AguaDoce { get; set; }

  public void Botar()
  {
    Console.WriteLine("O Pinguim está botando ovos.");
    Console.WriteLine();
  }
        
  public void Chocar()
  {
    Console.WriteLine("Os ovos dos pinguins levam 29 dias para chocarem!");
    Console.WriteLine();
  }

  public Pinguim()
  {
    Nome = "Cadú";
    DataNascimento = new DateTime(2007, 03, 08);
    Sexo = 'M';
    Carnivoro = true;
    Peconhento = false;

    Rapina = false;
    CorPena = "Preto e Branca";

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
    Ciscar();
    Comunicar();
    Alimentar();
  }
}