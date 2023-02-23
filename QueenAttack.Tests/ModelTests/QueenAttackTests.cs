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
      Board newBoard = new Board(1, 4, 7, 8);
      Assert.AreEqual(typeof(Board), newBoard.GetType());
    }
    [TestMethod] //2
    public void GetQueenX_ReturnsQueenX_Int()
    {
      //arrange
      int QueenX = 1;
      Board newBoard = new Board(QueenX, 4, 7, 8);
      //act
      int result = newBoard.QueenX;
      //assert
      Assert.AreEqual(QueenX, result);
    }
    [TestMethod] //3
    public void SetQueenX_SetsValueOfQueenX_Void()
    {
      //arrange
      Board newBoard = new Board(1, 4, 7, 8);
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
    Board newBoard = new Board(1, QueenY, 7, 8);
    //act
    int result = newBoard.QueenY;
    //assert
    Assert.AreEqual(QueenY, result);
    }
    [TestMethod] //5
    public void SetQueenY_SetsValueOfQueenY_Void()
    {
    //arrange
    Board newBoard = new Board(1, 4, 7, 8);
    int newQueenY = 8;
    //act
    newBoard.QueenY = newQueenY;
    //assert
    Console.WriteLine($"newboard.QueenY {newBoard.QueenY}");
    Assert.AreEqual(newQueenY, newBoard.QueenY);
    
    }
    [TestMethod] //6
    public void GetAndSetTargetXAndY_ReturnsTargetXAndY_IntAndInt()
    {
      //arrange
      int TargetX = 6;
      int TargetY = 8;
      Board newBoard = new Board(1, 4, TargetX, TargetY);
      //act
      int resultX = newBoard.TargetX;
      int resultY = newBoard.TargetY;
      //assert
      Assert.AreEqual(TargetX, resultX);
      Assert.AreEqual(TargetY, resultY);

    }
    [TestMethod] //7
    public void StraightCapture_ReturnsTrueWhenQueenAndTargetShareACoordinate_bool()
    {
      //arrange
      Board newBoard = new Board(1, 4, 5, 4);
      //act 
      bool result = newBoard.CaptureStraight();
      //assert
      Assert.AreEqual(true, result);

    }
    [TestMethod] //8
    public void Capture_ReturnsTrueWhenQueenAndTargetOnSameDiagonalOrStraight_bool()
    {
      //arrange
      Board newBoard = new Board(5,7,1,7);
      //act
      newBoard.QueenDiagAdd();
      bool resultDiag = newBoard.CaptureDiag();
      bool resultStraight = newBoard.CaptureStraight();
      //assert
      Assert.IsTrue(resultDiag || resultStraight);

    }
  }
}    
