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
    Pastry newPastry = new Pastry();
    Assert.AreEqual(typeof(Pastry), newPastry.GetType());
  }


  }
}
  
  
