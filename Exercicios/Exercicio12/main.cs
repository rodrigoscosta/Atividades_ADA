using System;

class Program 
{
  public static void Main (string[] args) 
  {
    Console.WriteLine("PERFIL");
    
    Console.WriteLine("Nome: ");
    string nome = Console.ReadLine();

    Console.WriteLine("Avatar: ");
    string avatar = Console.ReadLine();

    Console.Write("Tema (L para CLARO e D para ESCURO): ");
    string tema = Console.ReadLine().ToUpper();

    Perfil perfil = new Perfil(nome, avatar, tema);
  }
}