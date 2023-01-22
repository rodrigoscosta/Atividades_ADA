using System;
using System.Reflection;

class Program 
{
  public static void DisplayPublicProperties(Student student)
  {
    PropertyInfo[] propriedades = student.GetType().GetProperties();

    foreach (PropertyInfo propriedade in propriedades)
    {
      Console.WriteLine($"{propriedade.Name}: {propriedade.GetValue(student)}");
    }
  }

  public static Student CreateInstance()
  {
    Student student1 = new Student();

    student1.GetType().GetProperty("Name").SetValue(student1, "Rodrigo");
    student1.GetType().GetProperty("University").SetValue(student1, "UNIVESP");
    student1.GetType().GetProperty("RollNumber").SetValue(student1, 3);

    return student1;
  }

  public static void Main (string[] args) 
  {
    Student student = new Student();

    student.Name = "Rodrigo Santos Costa";
    student.University = "UNIVESP";
    student.RollNumber = 0;

    DisplayPublicProperties(student);
    Console.WriteLine();

    Student student1 = CreateInstance();

    MethodInfo methodInfo = student1.GetType().GetMethod("DisplayInfo");
    methodInfo.Invoke(student1, null);
  }
}