using MyApi.ContentContext.Enums;
using MyApi.SharedContext;

namespace MyApi.ContentContext
{
  public class Lecture : Base
  {
    public int Ordem { get; set; }
    public string Title { get; set; }
    public int DurationInMinutes { get; set; }
    public EContentLevel Level { get; set; }
  }
}