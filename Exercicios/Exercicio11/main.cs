using System;

class Program 
{
  public static void Main (string[] args) 
  {
    Restaurante restaurante = new Restaurante();

    char resposta;
    do
    {
      Console.WriteLine("NOVO PEDIDO");

      Console.Write("Informe a cidade em que mora: ");
      string cidade = Console.ReadLine();

      restaurante.EntregaPedido(cidade);

      Console.WriteLine("Gostaria de fazer outro pedido?");
      bool sucesso;
      do
      {
        Console.Write("Digite S para Sim ou Qualquer outra tecla para Não: ");
        sucesso = char.TryParse(Console.ReadLine().ToUpper(), out resposta);

        if (!sucesso)
        {
          Console.WriteLine("Por Favor, digite apenas um caracter para responder");
        }

      } while(!sucesso);
    } while (resposta == 'S');
  }
}