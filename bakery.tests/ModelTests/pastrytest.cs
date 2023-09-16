using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstancesOfPastry_Pastry()
  {
    Pastry newPastry = new Pastry(1);
    Assert.AreEqual(typeof(Pastry), newPastry.GetType());
  }
  [TestMethod]
    public void GetPasteryOrderCost_returnTotalCost_Int()
    {
      Pastry newPastry = new Pastry(4);
      int testprice = 6;
      int testPastryCost= newPastry.GetPasteryOrderCost();
      Assert.AreEqual(testprice, testPastryCost);
    }
    [TestMethod]
    public void NonDiscountedPastry_ReturnTotalCost_Int()
    {
      Pastry newPastry = new Pastry(5);
      int testPrice = 10;
      int testPastryCost = newPastry.NonDiscountedPastry();
      Assert.AreEqual(testPrice, testPastryCost);
    }


  }
}
  
  
