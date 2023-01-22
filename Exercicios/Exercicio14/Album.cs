using System;

class Album
{
  private int qtdFigurinhas { get; set; }
  private bool[] FigurinhasColadas { get; set; }
  
  public Album()
  {
    qtdFigurinhas = 60;

    FigurinhasColadas = new bool[qtdFigurinhas];

    for(int i = 0; i < FigurinhasColadas.Length; i++)
    {
      FigurinhasColadas[i] = false;
    }
  }

  public void VerFigurinhasRestantes()
  {
    Console.WriteLine("FIGURINHAS RESTANTES");
    for (int i = 0; i < qtdFigurinhas; i++)
    {
      if (i != 0 && i % 10 == 0)
      {
        Console.WriteLine();
      }
      
      if (FigurinhasColadas[i] == false)
      {
        Console.Write((i + 1) + "\t");
      }
      else
      {
        Console.Write("X\t");
      }
    }
    Console.WriteLine("\n");
  }

  public void ColarFigurinha()
  {
    bool sucesso;
    do
    {
      VerFigurinhasRestantes();

      Console.Write("Qual Figurinha Deseja Colar: ");
      sucesso = int.TryParse(Console.ReadLine(), out int figurinha);

      if (!sucesso || (figurinha < 1 || figurinha > qtdFigurinhas))
      {
        Console.WriteLine($"Essa Figurinha Não Existe, Digite uma Figurinha Existente (1 a {qtdFigurinhas})");
        sucesso = false;
      }
      else if (FigurinhasColadas[figurinha - 1] == true)
      {
        Console.WriteLine("Essa Figurinha Já Foi Colada\n");
      }
      else
      {
        FigurinhasColadas[figurinha - 1] = true;
        Console.WriteLine($"Figurinha {figurinha} Colada Com Sucesso!!!");
      }
    } while (!sucesso);
  }
}