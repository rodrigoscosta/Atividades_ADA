using System;

class TV
{
  public int Volume = 50;
  public bool Ligada;

  public bool Ligar()
  {
    string tvLigada = "Televisão ligada";
    Console.WriteLine(tvLigada);
    return Ligada = true;
  }

  public bool Desligar()
  {
    string tvDesligada = "Televisão Desligada";
    Console.WriteLine(tvDesligada);
    return Ligada = false;
  }

  public int mudaCanal()
  {
    Console.WriteLine("Informe para qual canal deseja mudar: ");
    int canal = int.Parse(Console.ReadLine());

    Console.WriteLine($"Mudado para o canal: {canal}");
    return canal;
  }

  public int aumentaVolume()
  {
    Console.WriteLine($"O volume atual é: {Volume}");
    
    Console.WriteLine("Informe o quanto deseja aumentar: ");
    int aumentarVolume = int.Parse(Console.ReadLine());

    Volume = Volume + aumentarVolume;

    Console.WriteLine($"Volume aumentado para: {Volume}");
    return Volume;
  }

  public int diminuiVolume()
  {
    Console.WriteLine($"O volume atual é: {Volume}");
    
    Console.WriteLine("Informe o quanto deseja diminuir: ");
    int diminuirVolume = int.Parse(Console.ReadLine());

    Volume = Volume - diminuirVolume;

    Console.WriteLine($"Volume diminuído para: {Volume}");
    return Volume;
  }
}