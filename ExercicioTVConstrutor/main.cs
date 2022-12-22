using System;

class Program 
{
  public static void Main (string[] args) 
  {
    TV televisao1 = new TV(45, false);

    Console.WriteLine("Televisão 1:");
    Console.WriteLine($"Volume atual: {televisao1.Volume}");
    Console.WriteLine($"Televisão ligada? {televisao1.Ligada}");

    Console.WriteLine("--------------------------");

    TV televisao2 = new TV(50, true);

    Console.WriteLine("Televisão 2:");
    Console.WriteLine($"Televisão ligada? {televisao2.Ligada}");

    televisao2.aumentaVolume();
    televisao2.diminuiVolume();
    televisao2.mudaCanal();
    televisao2.Desligar(); 
  }
}