using System;

class Program 
{
  public static void Main (string[] args) 
  {
    Console.WriteLine("ALBUM DE FIGURINHAS\n");
    Album album = new Album();

    char opcao;
    do
    {
      do
      {
        Console.WriteLine("1 - Ver Figurinhas Restantes;");
        Console.WriteLine("2 - Colar Figurinha;");
        Console.WriteLine("S - Sair;\n");

        Console.Write("Digite uma das opções acimas: ");
        char.TryParse(Console.ReadLine().ToUpper(), out opcao);

        if (opcao != '1' && opcao != '2' && opcao != 'S')
        {
          Console.WriteLine("Opção digitada inexistente\n");
        }
      } while(opcao != '1' && opcao != '2' && opcao != 'S');

      switch (opcao)
      {
        case '1':
          album.VerFigurinhasRestantes();
          break;

        case '2':
          album.ColarFigurinha();
          break;
      }
    } while (opcao != 'S');
  }
}