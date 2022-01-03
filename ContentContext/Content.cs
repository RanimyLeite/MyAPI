using System;
using System.Reflection.Metadata;
using System.ComponentModel;
namespace MyApi.ContentContext
{
  public abstract class Content : Base
  {
    public Content(string title, string url)
    {
      Title = title;
      Url = url;
    }
    public string Title { get; set; }
    public string Url { get; set; }
  }
}