using MyApi.ContentContext.Enums;

namespace MyApi.ContentContext
{
  public class Lecture
  {
    public int Ordem { get; set; }
    public string Title { get; set; }
    public int DurationInMinutes { get; set; }
    public EContentLevel Level { get; set; }
  }
}