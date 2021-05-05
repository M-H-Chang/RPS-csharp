using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using RockPaperScissors;

namespace RockPaperScissor.TestTools
{
  [TestClass]
  public class RockPaperScissorsTests
  {
    [TestMethod]
    public void GetWin_ReturnsWin_True()
    {
      RPS winCondition = new RPS();
      Assert.AreEqual(false, RPS.PlayerOneWin("test", "test"));
    }
    [TestMethod]
    public void RockRock_ReturnsWin_False()
    {
      RPS winCondition = new RPS();
      Assert.AreEqual(false, RPS.PlayerOneWin("rock", "rock"));
    }
    [TestMethod]
    public void RockRock_ReturnsWin_True()
    {
      RPS winCondition = new RPS();
      Assert.AreEqual(true, RPS.PlayerTwoWin("paper", "rock"));
    }
  }
}

// Assert.AreEqual(true, testIsocelesTriangle.IsIsocelesTriangle(2, 2, 1))
