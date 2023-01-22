using System;

class CNH
{
  public string Pais { get; set; }
  public int Idade { get; set; }

  public CNH(string pais)
  {
    this.Pais = pais;

    if (Pais == "US" || Pais == "ESTADOS UNIDOS" || Pais == "CA" || Pais == "CANADA")
    {
      this.Idade = 16;
    }
    else if (Pais == "CH" || Pais == "CHINA" || Pais == "RU" || Pais == "RUSSIA")
    {
      this.Idade = 21;
    }
    else
    {
      this.Idade = 18;
    }
  }

  public void ValidarBrasil(string pais)
  {
    if (Pais == "BR" || Pais == "BRASIL")
    {
      bool opcaoExistente;

      do
      {
        opcaoExistente = true;

        Console.Write("Digite a categoria de CNH desejada (A - B - C - D - E - AB - AC - AD - AE): ");
        string categoria = Console.ReadLine().ToUpper();

        switch (categoria)
        {
          case "A":
            Console.WriteLine("\nEssa carteira de motorista permite a condução de veículos com duas ou três rodas,\n" +
                                              "com ou sem o carro lateral e maiores que 50cm3 de cilindrada.");
          break;

          case "B":
            Console.WriteLine("\nEstando habilitado nesta categoria, o condutor tem permissão para conduzir veículos de quatro rodas com peso máximo de 3,5 toneladas\n" +
                                              "e com capacidade para até oito passageiros mais o motorista, totalizando nove pessoas. Incluem-se nesta categoria os quadriciclos.");
          break;

          case "C":
            Console.WriteLine("\nNa CNH C, os motoristas podem conduzir todos os tipos de veículos da CNH B e ainda os veículos de carga, não articulados, acima de 3,5 toneladas.\n" +
                                              "A partir da CNH C, é obrigatório que o condutor tenha experiência mínima de 1 ano na categoria B.");
          break;

          case "D":
            Console.WriteLine("\nA CNH de categoria D permite a condução de veículos de transporte de passageiros com acomodação superior a oito passageiros.\n" +
                                              "Nesse rol, incluem-se os ônibus, microônibus e as vans. Todos os veículos das categorias B e C estão englobados.\n" +
                                              "É necessário ter experiência mínima de 1 ano na CNH C e 2 anos na categoria B.\n" +
                                              "A idade mínima é 21 anos e é imperativa a realização de exame para distúrbios do sono e toxicológico.");
          break;

          case "E":
            Console.WriteLine("\nO motorista que possui a CNH de categoria E pode dirigir todo o rol de veículos definidos nas categorias B, C e D.\n" +
                                              "Somando-se a isso, também tem permissão para conduzir veículos com unidades acopladas com peso superior a 6 toneladas, como carretas, caminhões com reboques e semirreboques articulados.\n" +
                                              "Para possui a CNH E, será necessária a experiência nas categorias C ou D pelo período mínimo de 1 ano, além de idade superior a 21 anos e os testes de distúrbio do sono e exame toxicológico.");
          break;

          case "AB":
            Console.WriteLine("\nJunção da categoria A com a categoria B");
          break;

          case "AC":
            Console.WriteLine("\nJunção da categoria A com a categoria C");
          break;

          case "AD":
            Console.WriteLine("\nJunção da categoria A com a categoria D");
          break;

          case "AE":
            Console.WriteLine("\nJunção da categoria A com a categoria E");
          break;

          default:
            Console.WriteLine("Categoria inválida");
            opcaoExistente = false;
          break;
        }

      } while (!opcaoExistente);
    }
  }
}