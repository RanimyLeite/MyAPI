using System.Linq;
using System;
using System.Collections.Generic;
using MyApi.ContentContext;
using MyApi.SubscriptionContex;

namespace MyAPI
{
  class Program
  {
    static void Main(string[] args)
    {
      var articles = new List<Article>();
      articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
      articles.Add(new Article("Artigo sobre C#", "csharp"));
      articles.Add(new Article("Artigo sobre .Net", "dotnet"));

      foreach (var article in articles)
      {
        Console.WriteLine(article.Id);
        Console.WriteLine(article.Title);
        Console.WriteLine(article.Url);
      }

      var courses = new List<Course>();
      var courseOOP = new Course("Fundamentos OOP", "fundamentos-oop");
      var courseCsharp = new Course("Fundamentos C#", "fundamentos-csharp");
      var courseAspNet = new Course("Fundamentos ASP.NET", "fundamentos-aspnet");

      courses.Add(courseOOP);
      courses.Add(courseCsharp);
      courses.Add(courseAspNet);

      var carrers = new List<Career>();
      var careerDotnet = new Career("Especialista .NET", "especialista-dotnet");
      var carrerItem2 = new CareerItem(2, "Aprenda OOP", "", courseOOP);
      var carrerItem = new CareerItem(1, "Começe por aqui!", "", courseCsharp);
      var carrerItem3 = new CareerItem(3, "Aprenda .NET", "", courseAspNet);

      careerDotnet.Items.Add(carrerItem2);
      careerDotnet.Items.Add(carrerItem);
      careerDotnet.Items.Add(carrerItem3);

      carrers.Add(careerDotnet);

      foreach (var carrer in carrers)
      {
        Console.WriteLine(carrer.Title);
        foreach (var item in carrer.Items.OrderBy(x => x.Order))
        {
          Console.WriteLine($"{item.Order} - {item.Title}");
          Console.WriteLine(item.Course?.Title);
          Console.WriteLine(item.Course?.Level);

          foreach (var notification in item.Notifications)
          {
            Console.WriteLine($"{notification.Property} - {notification.Message}");
          }
        }

        var payPalSubscription = new PayPalSubscription();
        var studant = new Studant();
        studant.CreateSubscription(payPalSubscription);
      }
    }
  }
}
