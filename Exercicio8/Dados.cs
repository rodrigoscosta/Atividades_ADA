using System;

class Dados
{
  public string ObterCor()
  {
    Console.Write("Digite a cor do Carro: ");
    return Console.ReadLine();
  }

  public string ObterMarca()
  {
    Console.Write("Digite a marca do Carro: ");
    return Console.ReadLine();
  }

  public int ObterModelo()
  {
    int modelo;
    do
    {
      Console.Write("Modelo do Carro (1 para sedan ou 2 para hatch): ");
      int.TryParse(Console.ReadLine(), out modelo);

      if (modelo != 1 && modelo != 2)
      {
        Console.WriteLine("Opção inválida, digite 1 para sedan ou 2 para hatch!");
      }
    } while (modelo != 1 && modelo != 2);

    return modelo;
  }

  public double ObterCapacidade()
  {
    double capacidadeDoTanque;
    bool sucesso;
    do
    {
      Console.Write("Capacidade do Tanque (em litros): ");
      sucesso = double.TryParse(Console.ReadLine(), out capacidadeDoTanque);

      if (!sucesso)
      {
        Console.WriteLine("Por Favor, digite apenas numeros!");
      }

    } while (!sucesso);

    return capacidadeDoTanque;
  }

  public int ObterTipoCombustivel()
  {
    int tipoDeCombustivel;
    do
    {
      Console.Write("Tipo de Combustivel (1 para gasolina, 2 para alcool e 3 para flex): ");
      int.TryParse(Console.ReadLine(), out tipoDeCombustivel);

      if (tipoDeCombustivel < 1 || tipoDeCombustivel > 3)
      {
        Console.WriteLine("Opção digitada inexistente, digite 1 para gasolina, 2 para alcool e 3 para flex\n");
      }

    } while (tipoDeCombustivel < 1 || tipoDeCombustivel > 3);

      return tipoDeCombustivel;
  }

  public double ObterPorcentagemGasolina() 
  {
    double porcentagemGasolina;
    bool sucesso;

    do
    {
      Console.Write("\nPorcentagem de Gasolina desejada: ");
      sucesso = double.TryParse(Console.ReadLine(), out porcentagemGasolina);

      if (!sucesso)
      {
        Console.WriteLine("Por Favor, digite apenas numeros");
        continue;
      }

      if (porcentagemGasolina < 0 || porcentagemGasolina > 100)
      {
        Console.WriteLine("Por Favor, digite uma porcentagem de 0 a 100");
      }
    } while (!sucesso || porcentagemGasolina < 0 || porcentagemGasolina > 100);

      return porcentagemGasolina;
  }
}
