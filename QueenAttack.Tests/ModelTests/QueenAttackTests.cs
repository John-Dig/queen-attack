using System;
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
      Board newBoard = new Board(1, 4);
      Assert.AreEqual(typeof(Board), newBoard.GetType());
    }
    [TestMethod] //2
    public void GetQueenX_ReturnsQueenX_Int()
    {
      //arrange
      int QueenX = 1;
      Board newBoard = new Board(QueenX, 4);
      //act
      int result = newBoard.QueenX;
      //assert
      Assert.AreEqual(QueenX, result);
    }
    [TestMethod] //3
    public void SetQueenX_SetsValueOfQueenX_Void()
    {
      //arrange
      Board newBoard = new Board(1, 4);
      int newQueenX = 5;
      //act
      newBoard.QueenX = newQueenX;
      //assert  
      Assert.AreEqual(newQueenX, newBoard.QueenX);
    }
    [TestMethod] //4
    public void GetQueenY_ReturnsQueenY_Int()
    {
    //arrange
    int QueenY = 4;
    Board newBoard = new Board(1, QueenY);
    //act
    int result = newBoard.QueenY;
    //assert
    Assert.AreEqual(QueenY, result);
    }
    [TestMethod] //5
    public void SetQueenY_SetsValueOfQueenY_Void()
    {
    //arrange
    Board newBoard = new Board(1, 4);
    int newQueenY = 8;
    //act
    newBoard.QueenY = newQueenY;
    //assert
    Console.WriteLine($"newboard.QueenY {newBoard.QueenY}");
    Assert.AreEqual(newQueenY, newBoard.QueenY);
    
    }
    //arrange
    //act
    //assert
    
    //arrange
    //act
    //assert
    
    //arrange
    //act
    //assert

  }
}