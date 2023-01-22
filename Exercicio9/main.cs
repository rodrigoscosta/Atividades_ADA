using System;

class Program 
{
  public static void Main (string[] args) 
  {
    Console.WriteLine("------------------ TIME ------------------");
    Time time  = new Time();

    Console.Write("Nome do pais: ");
    time.Pais = Console.ReadLine();

      Console.Write("Esporte praticado: ");
      time.Esporte = Console.ReadLine();

      int qtdPartidas;
      bool sucesso;
    
      do
      {
        Console.Write("Quantidade de partidas jogadas: ");
        sucesso = int.TryParse(Console.ReadLine(), out qtdPartidas);

        if (!sucesso)
        {
          Console.WriteLine("Por Favor, digite apenas numeros");
        }
      } while (!sucesso);

      for (int i = 0; i < qtdPartidas; i++)
      {
        Console.WriteLine($"Resultado da {i + 1}° partida");

        char resultado;
        do
        {
          Console.Write("Digite W para Vitoria, L para Derrota e D para Empate: ");
          char.TryParse(Console.ReadLine().ToUpper(), out resultado);

          if (resultado != 'W' && resultado != 'L' && resultado != 'D')
          {
            Console.WriteLine("Resultado Digitado Invalido");
          }
        } while (resultado != 'W' && resultado != 'L' && resultado != 'D');

        time.Pontuar(resultado);
      }
      Console.WriteLine($"\nO resultado final do(a) {time.Pais} no(a) {time.Esporte} é {time.Pontuacao}"); 
  }
}