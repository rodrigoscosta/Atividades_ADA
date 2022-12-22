using System;

class Program {
  public static void Main (string[] args) 
  {
    Caneta caneta1 = new();
    Caneta caneta2 = new();

    caneta1.Cor = "Preto";
    caneta1.Marca = "Bic";
    caneta1.Preco = 1.50;

    Console.WriteLine($"Caneta 1 \nCor: {caneta1.Cor} \nMarca: {caneta1.Marca} \nPreço:{caneta1.Preco.ToString("N2")}");
    caneta1.Escrever();

    Console.WriteLine("-----------------------------------------------------------");

    caneta2.Cor = "Azul";
    caneta2.Marca = "Faber Castell";
    caneta2.Preco = 2.99;

    Console.WriteLine($"Caneta 2 \nCor: {caneta2.Cor} \nMarca: {caneta2.Marca} \nPreço:{caneta2.Preco.ToString("N2")}");
    caneta2.Escrever();
  }
}