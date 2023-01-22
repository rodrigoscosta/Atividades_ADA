using System;

class Program 
{
  public static void Main (string[] args) 
  {
    int qtdInscricoes;
    bool sucesso;
    do
    {
      Console.Write("Quantidade de Pessoas Inscritas: ");
      sucesso = int.TryParse(Console.ReadLine(), out qtdInscricoes);

      if (!sucesso)
      {
        Console.WriteLine("Por Favor, digite utilizando apenas numeros!!");
      }
    } while(!sucesso);

    Sorteio sorteio = new Sorteio();
    sorteio.QtdInscricoes = qtdInscricoes;
    sorteio.SorteiaPremio();
  }
}