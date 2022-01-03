using System;
using MyApi.SharedContext;

namespace MyApi.SubscriptionContex
{
  public class Plan : Base
  {
    public string TitlePlan { get; set; }
    public decimal Price { get; set; }
  }
}