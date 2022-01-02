using System;
using System.Reflection.Metadata;
using System.ComponentModel;
namespace MyApi.ContentContext
{
  public abstract class Content
  {
    public Content()
    {
      Guid guid = Guid.NewGuid();
      Id = guid;
    }
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Url { get; set; }
  }
}