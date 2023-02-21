using System;
using QueenAttack.Models;

namespace QueenAttack
{
  class Program
  {
    static void Main()
    {
      Board testBoard = new Board(1, 2, 3, 4);
      Console.WriteLine(testBoard);
    }
  }
}