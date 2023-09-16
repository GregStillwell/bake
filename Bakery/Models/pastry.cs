using System.Collections.Generic;

namespace Bakery.Models
{
  public class Pastry
  {
    public int PastryQuantity {get; set;}
    public int Cost { get; set; }
    public int TotalCost { get; set; }

    public Pastry(int quantity)
    {
      PastryQuantity= quantity;
      Cost = 2;
    }
    public int GetPasteryOrderCost(){
      int discount = PastryQuantity / 4;
      int TotalCost = (PastryQuantity - discount) * Cost;
      TotalCost = totalCost
      return TotalCost;
    }
  }
    
}

