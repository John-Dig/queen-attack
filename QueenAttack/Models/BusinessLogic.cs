using System;
using System.Collections.Generic;
using System.Linq;

namespace QueenAttack.Models
{
  public class Board
  {
    private int _queenX;
    public int QueenX
    {
      get { return _queenX; }
      set { _queenX = value; }
    }
    
    private int _queenY;
    public int QueenY
    {
      get { return _queenY; }
      set { _queenY = value; }
    }
    
    private int _targetX;
    public int TargetX
    {
      get { return _targetX; }
      set { _targetX = value; }
    }

    private int _targetY;
    public int TargetY
    {
      get { return _targetY; }
      set { _targetY = value; }
    }
    
    public Board(int coordinateX, int coordinateY, int targetCoordinateX, int targetCoordinateY)
    {
      _queenX = coordinateX;
      _queenY = coordinateY;
      _targetX = targetCoordinateX;
      _targetY = targetCoordinateY;
    }
    
    public bool CaptureStraight()
    {
      if (QueenX == TargetX || QueenY == TargetY)
      {
        return true;
      }
      else 
      {
        return false;
      }
    }
    
    public Dictionary<int, Tuple<int, int>> QueenRein = new Dictionary<int, Tuple<int, int>>();
    
    public void QueenDiagAdd()
    {
      for (int i = 0; i < 8; i ++) // ++
      {
        int Qx = QueenX + i;
        int Qy = QueenY + i;
        if (Qx == 9 || Qy == 9) 
        {
          break;
        }
        QueenRein.Add(i, new Tuple<int, int>(Qx, Qy));
      }
      for (int i = 0; i < 8; i ++) // +-
      {
        int Qx = QueenX + i;
        int Qy = QueenY - i;
        if (Qx == 9 || Qy == 0) 
        {
          break;
        }
        QueenRein.Add(i+10, new Tuple<int, int>(Qx, Qy));
      }
      for (int i = 0; i < 8; i ++)  // -+
      {
        int Qx = QueenX - i;
        int Qy = QueenY + i;
        if (Qx == 0 || Qy == 9) 
        {
          break;
        }
        QueenRein.Add(i+20, new Tuple<int, int>(Qx, Qy));
      }
      for (int i = 0; i < 8; i ++) // --
      {
        int Qx = QueenX - i;
        int Qy = QueenY - i;
        if (Qx == 0 || Qy == 0) 
        {
          break;
        }
        QueenRein.Add(i+30, new Tuple<int, int>(Qx, Qy));
      }    
    }
    public bool CaptureDiag()
    {
    bool Capture = QueenRein.Values.Any(tuple => tuple.Item1 == TargetX && tuple.Item2 == TargetY);
    {
      return Capture;
    }
    }
    
    // newMethod() //need to rewrite this 
    // {
    //   public void InputQX()
    //   {
    //     Console.WriteLine("Enter Queen's X coordinate");
    //     string inputX = Console.ReadLine();
    //     int coord = int.Parse(inputX);
    //     return coord;
    //   }
    //     public void InputQY()
    //   {
    //     Console.WriteLine("Enter Queen's Y coordinate");
    //     string inputX = Console.ReadLine();
    //     int coord = int.Parse(inputX);
    //     return coord;
    //   }
    //   public void InputTX()
    //   {
    //     Console.WriteLine("Enter target's X coordinate");
    //     string inputX = Console.ReadLine();
    //     int coord = int.Parse(inputX);
    //     return coord;
    //   }
    //   public void InputTY()
    //   {
    //     Console.WriteLine("Enter target's Y coordinate");
    //     string inputX = Console.ReadLine();
    //     int coord = int.Parse(inputX);
    //     return coord;
    //   }
    // }      
  }
}

