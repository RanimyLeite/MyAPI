using MyApi.SharedContext;

namespace MyApi.SubscriptionContex
{
  public class Studant : Base
  {
    public string Name { get; set; }
    public string Email { get; set; }
    public User User { get; set; }
  }
}