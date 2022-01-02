using System.Reflection;
using System.Collections.Generic;
using MyApi.ContentContext.Enums;

namespace MyApi.ContentContext
{
  public class Course : Content
  {
    public Course()
    {
      Modules = new List<Module>();
    }
    public string Tag { get; set; }
    public IList<Module> Modules { get; set; }
    public int DurationInMinutes { get; set; }
    public EContentLevel Level { get; set; }

  }
}