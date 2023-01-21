using System;

public class Morcego : Mamifero, IVoar
{
  public int AltitudeMaximaEmMetros { get; set; }
  public double VelocidadeDoVoo { get; set; }

  public void Voar()
  {
    Console.WriteLine($"{Nome} está voando!");
    Console.WriteLine();
  }

  public Morcego()
  {
    Nome = "Lara";
    DataNascimento = new DateTime(2022, 11, 27);
    Sexo = 'F';
    Carnivoro = false;
    Peconhento = false;

    QtdMamas = 2;
    Pelos = true;
    CorDoPelo = "Preto";

    AltitudeMaximaEmMetros = 180;
    VelocidadeDoVoo = 160;

    Console.WriteLine($"Altitude Maxima de Voo: {AltitudeMaximaEmMetros} m");
    Console.WriteLine($"Velocidade do Voo: {VelocidadeDoVoo} Km/h");
    Console.WriteLine();

    Movimentar();
    Comunicar();
    Alimentar();
    Voar();
  }
}