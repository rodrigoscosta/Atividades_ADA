
using System;

class Carro
{
  private string Cor { get; set; }
  private string Marca { get; set; }
  private int Modelo { get; set; }
  private double CapacidadeDoTanque { get; set; }
  private int TipoDeCombustivel { get; set; }

  public Carro()
  {
    Dados dados = new();

    Cor = dados.ObterCor();
    Marca = dados.ObterMarca();
    Modelo = dados.ObterModelo();
    CapacidadeDoTanque = dados.ObterCapacidade();
    TipoDeCombustivel = dados.ObterTipoCombustivel();
  }

  public void Abastecer()
  {
    switch (TipoDeCombustivel)
    {
      case 1:
        Console.WriteLine("Enchendo o Tanque com Gasolina...");
        Console.WriteLine("Valor total: R$" + (CapacidadeDoTanque * 5.62));
      break;

      case 2:
        Console.WriteLine("Enchendo o Tanque com Etanol...");
        Console.WriteLine("Valor total: R$" + (CapacidadeDoTanque * 4.16));
      break;

      case 3:

      Dados dados = new();
      double porcentagemGasolina = dados.ObterPorcentagemGasolina();

      switch (porcentagemGasolina)
      {
        case 100:
          Console.WriteLine("Enchendo o Tanque com Gasolina...");
          Console.WriteLine("Valor total: R$" + (CapacidadeDoTanque * 5.62));
        break;

        case 0:
          Console.WriteLine("Enchendo o Tanque com Etanol...");
          Console.WriteLine("Valor total: R$" + (CapacidadeDoTanque * 4.16));
        break;

       default:
        Console.WriteLine($"Enchendo {CapacidadeDoTanque * (porcentagemGasolina / 100)}L de Gasolina...");
        Console.WriteLine($"Encehendo {CapacidadeDoTanque * ((100 - porcentagemGasolina) / 100)}L de Etanol...");

        Console.WriteLine("Valor total: R$" + ((CapacidadeDoTanque * (porcentagemGasolina / 100) * 5.62) + (CapacidadeDoTanque * ((100 - porcentagemGasolina) / 100)) * 4.16));
        break;
      }
        break;
    }
  }
}