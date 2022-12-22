using System;

class Program 
{
  public static void Main (string[] args) 
  {
    TV televisao1 = new();
    TV televisao2 = new();

    Console.WriteLine("Televisão 1:");
    televisao1.Ligar();
    televisao1.mudaCanal();
    Console.WriteLine();
    televisao1.aumentaVolume();
    Console.WriteLine();
    televisao1.diminuiVolume();

    Console.WriteLine("-------------------------------------------");

    Console.WriteLine("Televisão 2:");
    televisao1.Desligar();
    Console.WriteLine("Deseja ligar? Digite 1 para Sim ou 2 para Não");
    int opcao = int.Parse(Console.ReadLine());
    if(opcao == 1)
    {
      televisao1.mudaCanal();
      Console.WriteLine();
      televisao1.aumentaVolume();
      Console.WriteLine();
      televisao1.diminuiVolume();
    }
    else
    {
      Console.WriteLine("Televisão2 permanece desligada");
    }
  }
}