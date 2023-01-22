using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Boletim
{
  private string NomeDoAluno { get; set; }
  private int Ano { get; set; }
  private int Semestre { get; set; }
  private List<double> Medias { get; set; } = new List<double>(6);

  public Boletim()
  {
    Dados dados = new Dados();

    NomeDoAluno = dados.ObterNome();
    Ano = dados.ObterAno();
    Semestre = dados.ObterSemestre();

    for (int i = 0; i < Medias.Count; i++)
    {
      Console.Write($"Media da Materia {i + 1}: ");
      double media = dados.ObterMedia();
      Medias.Add(media);
    }
  }
}