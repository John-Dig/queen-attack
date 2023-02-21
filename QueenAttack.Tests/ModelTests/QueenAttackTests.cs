using Microsoft.VisualStudio.TestTools.UnitTesting;
using QueenAttack.Models;

namespace QueenAttack.Tests
{
  [TestClass]
  public class QueenAttack
  {
    
    [TestMethod]
    public void BoardConstructor_CreatesInstanceOfBoard_Board()
    {
      Board newBoard = new Board();
      Assert.AreEqual(typeof(Board), newBoard.GetType());
    }
  }
}