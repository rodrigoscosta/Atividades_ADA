using System;

class Dados
{
  public string ObterNome()
  {
    Console.Write("Digite o nome do aluno: ");
    return Console.ReadLine();
  }

  public int ObterAno()
  {
    int ano;

    do
    {
      Console.Write("Digite o ano: ");
      bool sucesso = int.TryParse(Console.ReadLine(), out ano);

      if (!sucesso)
      {
        Console.WriteLine("Por Favor, digite um Ano valido utilizando apenas numeros\n");
        continue;
      }

      if (ano <= 1964)
      {
        Console.WriteLine("Por Favor, digite um Ano maior que 1964\n");
      }

    } while (ano <= 1964);

      return ano;
  }

  public int ObterSemestre()
  {
    int semestre;

    do
    {
      Console.Write("Digite o semestre que está cursando atualmente: ");
      bool sucesso = int.TryParse(Console.ReadLine(), out semestre);

      if (!sucesso)
      {
        Console.WriteLine("Por Favor, digite um Semestre valido utilizando apenas numeros\n");
        continue;
      }

      if (semestre < 1 || semestre > 14)
      {
        Console.WriteLine("Digite um semestre de 1 a 14\n");
      }

    } while (semestre < 1 || semestre > 14);

      return semestre;
  }

  public double ObterMedia()
  {
    double media;

    do
    {
      bool sucesso = double.TryParse(Console.ReadLine(), out media);

      if (!sucesso)
      {
        Console.WriteLine("Por Favor, digite uma média valida utilizando apenas numeros\n");
        Console.Write("Media: ");
        media = -1;
        continue;
      }

      if (media < 0 || media > 10)
      {
        Console.WriteLine("Por Favor, digite uma Media de 0 a 10\n");
        Console.Write("Media: ");
      }

    } while (media < 0 || media > 10);

      return media;
  }
}