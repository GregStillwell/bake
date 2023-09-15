using System;
using Bakery.Models;

namespace Bakery
{
  class Program
  {
    static void Main()
    {
      Console.Writeline("Welcome to Greg's Bakery!")
      Console.Writeline("How many loaves of bread would you like to purchase?")
      string breadInput = Console.ReadLine();
      int breadInputInt = int.Parse(breadInput);
      Bread order = new Bread(breadInputInt);
    }
  }
}