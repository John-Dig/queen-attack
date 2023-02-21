using Microsoft.VisualStudio.TestTools.UnitTesting;
using QueenAttack.Models;

namespace QueenAttack.Tests
{
  [TestClass]
  public class QueenAttack
  {
    
    [TestMethod] //1
    public void BoardConstructor_CreatesInstanceOfBoard_Board()
    {
      Board newBoard = new Board(1);
      Assert.AreEqual(typeof(Board), newBoard.GetType());
    }
    [TestMethod] //2
    public void GetQueenX_ReturnsQueenX_Int()
    {
      //arrange
      int QueenX = 1;
      Board newBoard = new Board(QueenX);
      //act
      int result = newBoard.QueenX;
      //assert
      Assert.AreEqual(QueenX, result);
    }
    //arrange
    //act
    //assert
  }
}