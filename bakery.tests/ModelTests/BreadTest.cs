using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
    Bread newBread = new Bread(1);
    Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetBreadOrderCost_ReturnTotalCost_Int()
    {
      // Arrange
      Bread newBread = new Bread(3);
      int testPrice = 10;
      // Act
      int testBreadCost = newBread.GetBreadOrderCost();
      // Assert
      Assert.AreEqual(testPrice, testBreadCost);
    }

    [TestMethod]
    public void NonDiscountedBread_ReturnTotalCost()
    {
      Bread newBread = new Bread(2);
      int testPrice = 10;
      int testBreadCost = newBread.NonDiscountedBread();
      Assert.AreEqual(testPrice, testBreadCost);

    }
  }
}

// 1 test for the constructor --done
// 1 test bread/pastry with discount --done
// 1 test bread/pastry no discount