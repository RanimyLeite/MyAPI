using System;
using MyApi.NotificationContext;

namespace MyApi.ContentContext
{
  public abstract class Base : Notifiable
  {
    public Base()
    {
      Guid guid = Guid.NewGuid();
      Id = guid;
    }
    public Guid Id { get; set; }
  }
}