using System;

class Arara : Ave, IVoar, IOviparo
{
  public int AltitudeMaximaEmMetros { get; set; }
  public double VelocidadeDoVoo { get; set; }
  
  public void Chocar()
  {
    Console.WriteLine("Os ovos das Araras levam 20 dias para chocarem!");
    Console.WriteLine();
  }

  public void Botar()
  {
    Console.WriteLine("A Arara está botando ovos!");
    Console.WriteLine();
  }
  
  public void Voar()
  {
    Console.WriteLine($"{Nome} está voando!");
    Console.WriteLine();
  }

  public Arara()
  {
    Nome = "Blue";
    DataNascimento = new DateTime(2011, 04, 16);
    Sexo = 'M';
    Carnivoro = false;
    Peconhento = false;

    Rapina = false;
    CorPena = "Azul";

    AltitudeMaximaEmMetros = 622;
    VelocidadeDoVoo = 78;

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