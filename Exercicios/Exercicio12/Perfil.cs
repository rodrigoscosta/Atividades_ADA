using System;

class Perfil
{
  public string Nome { get; set; }
  
  private string _avatar;
  public string Avatar
  {
    get { return _avatar; }
    set 
    {
      if (value.StartsWith("http") || value.StartsWith("https"))
        _avatar = value;
      else
        throw new ArgumentException("A URL da foto de perfil deve iniciar com http ou https");
    }
  }

  private string _tema;
  public string Tema 
  {
    get { return _tema; }
    set 
    {
      switch (value)
      {
        case "L":
          _tema = "Claro";
          break;

        case "D":
          _tema = "Escuro";
          break;

        default:
          throw new ArgumentException("O tema deve ser L para Claro ou D para Escuro");
      }
    }
  }
  
  public Perfil(string nome, string avatar, string tema)
  {
    Nome = nome;
    Avatar = avatar;
    Tema = tema;
  }
}