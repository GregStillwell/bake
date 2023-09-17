using System;
using Bakery.Models;


namespace Bakery
{
  class Program
  {
    static void Main()
    {
       Console.WriteLine("Welcome to Greg's Bakery!");
       Console.WriteLine("How many loaves of bread/pastry would you like to purchase?");
       Console.WriteLine("Bread cost $5 a loaf and for every two loaf, you get one for free!");
       string breadInput = Console.ReadLine();
       Console.WriteLine("How many Patries would you like to buy?");
       string pastryInput = Console.ReadLine();
       int BreadQuantity = int.Parse(breadInput);
       int PastryQuantity = int.Parse(pastryInput);
       Bread bread = new Bread(BreadQuantity); 
       Pastry pastry = new Pastry(PastryQuantity);
       pastry.GetPasteryOrderCost();
       bread.GetBreadOrderCost();
      Console.WriteLine($"Your total will be: ${bread.TotalCost + pastry.TotalCost}");
    }
  }
}