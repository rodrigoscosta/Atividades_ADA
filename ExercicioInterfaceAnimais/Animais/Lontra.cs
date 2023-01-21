using System;

public class Lontra : Mamifero, IAquatico
{
  public bool ViveEmTerra { get; set; }
  public bool Mergulho { get; set; }
  public bool AguaDoce { get; set; }

  public Lontra()
  {
    Nome = "Diluc";
    DataNascimento = new DateTime(2020, 09, 17);
    Sexo = 'M';
    Carnivoro = true;
    Peconhento = false;

    QtdMamas = 6;
    Pelos = true;
    CorDoPelo = "Marrom";

    ViveEmTerra = true;
    Mergulho = true;
    AguaDoce = true;

    Console.WriteLine("Consegue Viver na Terra: " + ViveEmTerra);
    Console.WriteLine("Consegue Mergulhar: " + Mergulho);
    Console.WriteLine("Vive em Agua Doce: " + AguaDoce);
    Console.WriteLine();

    Amamentar();
    Movimentar();
    Comunicar();
    Alimentar();
  }
}