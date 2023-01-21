using System;

class Coruja : Ave, IVoar, IOviparo
{
  public int AltitudeMaximaEmMetros { get; set; }
  public double VelocidadeDoVoo { get; set; }

  public void Voar()
  {
    Console.WriteLine($"{Nome} está voando!");
    Console.WriteLine();
  }

  public void Botar()
  {
    Console.WriteLine("A Coruja está botando ovos!");
    Console.WriteLine();
  }
        
  public void Chocar()
  {
    Console.WriteLine("Os ovos das corujas levam 24 dias para chocarem!");
    Console.WriteLine();
  }

  public Coruja()
  {
    Nome = "Soren";
    DataNascimento = new DateTime(1996, 08, 10);
    Sexo = 'M';
    Carnivoro = true;
    Peconhento = false;

    Rapina = true;
    CorPena = "Marrom";

    AltitudeMaximaEmMetros = 679;
    VelocidadeDoVoo = 86;

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