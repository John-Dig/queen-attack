using System;
using QueenAttack.Models;
using System.Collections.Generic;

namespace QueenAttack
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
      Console.WriteLine("Enter Coordinates:");
      Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
      Board newBoard = new Board(0,0,0,0);
      Console.WriteLine("Queen X:");
      string one = Console.ReadLine();
      Console.WriteLine("Queen Y:");
      string two = Console.ReadLine();
      Console.WriteLine("Target X:");
      string three = Console.ReadLine();
      Console.WriteLine("Target Y:");
      string four = Console.ReadLine();
      newBoard.QueenX = int.Parse(one);
      newBoard.QueenY = int.Parse(two);
      newBoard.TargetX = int.Parse(three);
      newBoard.TargetY = int.Parse(four);
      Console.WriteLine(newBoard.EvaluateBoth());
    }
  }
}

// public bool CaptureDiag()
// public void QueenDiagAdd()
// public bool CaptureStraight()
// public Board(int coordinateX, int coordinateY, int targetCoordinateX, int targetCoordinateY)