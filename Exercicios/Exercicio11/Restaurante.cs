using System;

class Restaurante
{
  private string Cidade { get; set; }
  private bool Delivery { get; set; }
  private int PedidosPendentes { get; set ; }
  private int TempoEntrega { get; set; }

  public Restaurante()
  {
    Cidade = "São Paulo";
    PedidosPendentes = 0;
  }

  public void EntregaPedido(string cidade)
  {
    Delivery = Cidade.Equals(cidade, StringComparison.OrdinalIgnoreCase);

    if (!Delivery)
    {
      Console.WriteLine("Desculpe, mas so fazemos entrega em " + Cidade);
    }
    else
    {
      Console.WriteLine("\nPedido aceito e encaminhado para produção");
      TempoEntrega = 10 + 2 * PedidosPendentes;
      Console.WriteLine($"Tempo estimado de entrega {TempoEntrega} minutos");
      PedidosPendentes++;
    }
  }
}