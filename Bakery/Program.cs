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
       int breadInputInt = int.Parse(breadInput);
       int PastryInputInt = int.parse(PastryInputInt);
       Bread order = new Bread(breadInputInt); 
       Pastry order = new Pastry(PastryInputInt);
       Pastry.GetPasteryOrderCost();
       Bread.GetBreadOrderCost();
      Console.WriteLine($"Your total will be: ${Bread.TotalCost + Pastry.TotalCost}");
    }
  }
}