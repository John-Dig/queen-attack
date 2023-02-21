using System;
using QueenAttack.Models;

namespace QueenAttack
{
  class Program
  {
    static void Main()
    {
      Board testBoard = new Board(2, 2);
      Console.WriteLine(testBoard);
    }
  }
}