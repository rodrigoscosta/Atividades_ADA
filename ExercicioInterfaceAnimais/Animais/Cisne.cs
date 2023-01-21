using System;

class Cisne : Ave, IAquatico, IOviparo, IVoar
{
  public bool ViveEmTerra { get; set; }
  public bool Mergulho { get; set; }
  public bool AguaDoce { get; set; }

  public int AltitudeMaximaEmMetros { get; set; }
  public double VelocidadeDoVoo { get; set; }

  public void Voar()
  {
    Console.WriteLine($"{Nome} voou para longe");
    Console.WriteLine();
  }

  public void Botar()
  {
    Console.WriteLine("O Cisne está botando ovos!");
    Console.WriteLine();
  }
  
  public void Chocar()
  {
    Console.WriteLine("Os ovos dos Cisnes levam 19 dias para chocarem!");
    Console.WriteLine();
  }

  public Cisne()
  {
    Nome = "Jack";
    DataNascimento = new DateTime(2005, 01, 09);
    Sexo = 'M';
    Carnivoro = false;
    Peconhento = false;

    Rapina = false;
    CorPena = "Branca";

    ViveEmTerra = true;
    Mergulho = false;
    AguaDoce = true;

    AltitudeMaximaEmMetros = 429;
    VelocidadeDoVoo = 38;

    Console.WriteLine("Consegue Viver na Terra: " + ViveEmTerra);
    Console.WriteLine("Consegue Mergulhar: " + Mergulho);
    Console.WriteLine("Vive em Agua Doce: " + AguaDoce);
    Console.WriteLine();

    Console.WriteLine($"Altitude Maxima de Voo: {AltitudeMaximaEmMetros} m");
    Console.WriteLine($"Velocidade do Voo: {VelocidadeDoVoo} Km/h");
    Console.WriteLine();

    Botar();
    Chocar();
    Console.WriteLine();

    Movimentar();
    Ciscar();
    Comunicar();
    Alimentar();
    Voar();
  }
}