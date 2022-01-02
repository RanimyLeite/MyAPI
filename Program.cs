using System;
using MyApi.ContentContext;

namespace MyAPI
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");

      var course = new Course();

      foreach (var item in course.Modules)
      {

      }

    }
  }
}
