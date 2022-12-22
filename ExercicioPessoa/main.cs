using System;

class Program 
{
  public static void Main (string[] args) 
  {
    Pessoa pessoa = new();
    pessoa.NomeCompleto = "Rodrigo Santos Costa";
    pessoa.primeiroNome = "Rodrigo";
    pessoa.email = "rodrigoltscode@gmail.com";
    
    Console.WriteLine(pessoa.primeiroNome);
    Console.WriteLine(pessoa.NomeCompleto);
    Console.WriteLine(pessoa.email);
  }
}