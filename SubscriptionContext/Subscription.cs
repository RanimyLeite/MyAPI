using System;
using MyApi.SharedContext;

namespace MyApi.SubscriptionContex
{
  public class Subscription : Base
  {
    public Plan Plan { get; set; }
    public DateTime? EndDate { get; set; }
    public bool IsInactive => EndDate <= DateTime.Now;
  }
}