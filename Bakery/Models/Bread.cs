using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public int BreadQuantity {get; set;}
    public int Cost { get; set; }
    public int TotalCost { get; set; }

    public Bread(int quantity)
    {
      BreadQuantity = quantity;
      Cost = 5;
    }

    public int GetBreadOrderCost(){
      int discount = BreadQuantity / 3;
      int totalCost = (BreadQuantity - discount) * Cost;
      TotalCost = totalCost;
      return totalCost;
    } 

    public int NonDiscountedBread(){
      int totalCost = (BreadQuantity * Cost);
      TotalCost = totalCost;
      return TotalCost;
    }
  }
}