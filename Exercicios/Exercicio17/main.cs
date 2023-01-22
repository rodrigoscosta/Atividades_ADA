using System;

class Program 
{
  public static void Main (string[] args) 
  {
    Console.Write("Nome do Livro: ");
    string nome = Console.ReadLine();

    Console.Write("Autor: ");
    string autor = Console.ReadLine();

    int ano;
    bool sucesso;
    do
    {
      Console.Write("Ano de Lançamento: ");
      sucesso = int.TryParse(Console.ReadLine(), out ano);

      if (!sucesso)
      {
        Console.WriteLine("Por Favor, Utilize Apenas Numeros\n");
      }
    } while(!sucesso);

    Console.WriteLine($"\nGostaria de conferir as informações do Ebook de {nome}?");
    do
    {
      Console.Write("Digite S para SIM ou QUALQUER Outra Tecla para Não: ");
      sucesso = char.TryParse(Console.ReadLine().ToUpper(), out char resposta);

      if (!sucesso)
      {
        Console.WriteLine("Por Favor, Digite Apenas UM Caracter\n");
        continue;
      }

      if (resposta == 'S')
      {
        Ebook ebook = new Ebook(autor, ano);
      }
    } while(!sucesso);

    Console.WriteLine($"\nGostaria de conferir as informações do AudioBook de {nome}?");
    do
    {
      Console.Write("Digite S para SIM ou QUALQUER Outra Tecla para Não: ");
      sucesso = char.TryParse(Console.ReadLine().ToUpper(), out char resposta);

      if (!sucesso)
      {
        Console.WriteLine("Por Favor, Digite Apenas UM Caracter\n");
        continue;
      }

      if (resposta == 'S')
      {
        AudioBook audioBook = new AudioBook(autor, ano);
      }
    } while (!sucesso);
  }
}