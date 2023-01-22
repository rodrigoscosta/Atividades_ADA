using System;

class Program {
  public static void Main (string[] args)
  {
    Console.WriteLine("---------------- CARRO ----------------");
    Carro carro = new Carro();

    Console.WriteLine("---------------- ABASTECER ----------------");
    carro.Abastecer();
  }
}