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
    public void Capture_ReturnsTrueWhenQueenAndTargetOnSameDiagonal_bool()
    {
      //arrange
      Board newBoard = new Board(1, 1, 1, 8);
      //act
      bool result = newBoard.CaptureDiag();
      //assert
      Assert.AreEqual(true, result);

    }
    
  
//phat test
// [TestMethod]
// public void Get_It_MuffinTesting_Dict_output()
// {
//   //arrange
//   Board newBoard = new Board(8, 8, 1, 2);
  
//   //act
//   newBoard.MakeQueenPoss();
//   foreach (var entry in newBoard.QueenRein)
//   {
//       Console.WriteLine("Queen position: " + entry.Key);
//       Console.WriteLine("Possible moves: " + string.Join(",", entry.Value));
//   }
  
//   //assert
//   Assert.AreNotEqual(typeof(Board), newBoard.GetType());
// }

  }
}
