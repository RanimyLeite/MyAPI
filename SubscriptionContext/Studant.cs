using System.Collections.Generic;
using System.Linq;
using MyApi.NotificationContext;
using MyApi.SharedContext;

namespace MyApi.SubscriptionContex
{
  public class Studant : Base
  {
    public Studant()
    {
      Subscriptions = new List<Subscription>();
    }
    public string Name { get; set; }
    public string Email { get; set; }
    public User User { get; set; }
    public IList<Subscription> Subscriptions { get; set; }
    public bool IsPremium => Subscriptions.Any(x => !x.IsInactive);

    public void CreateSubscription(Subscription subscription)
    {
      if (IsPremium)
      {
        AddNotification(new Notification("Premium", "O Aluno já tem uma assinatura ativa!"));
        return;
      }

      Subscriptions.Add(subscription);
    }
  }
}