using System;

class Pessoa
{
  public string email { get; set; }
  public string primeiroNome { get; set; }
  private string _nomeCompleto;

  public string NomeCompleto
  {
    get => _nomeCompleto;
    set => _nomeCompleto = value;
  }

  
}