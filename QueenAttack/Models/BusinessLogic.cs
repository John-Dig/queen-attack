using System.Collections.Generic;

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
    // business logic
   // Dictionary<string, int> QueenPosition = new Dictionary<string, int>();

  }
}

// // code where i stopped ---------------------------copied from Phat
// using System.Collections.Generic;

// // create a dictionary with string keys and int values
// Dictionary<string, int> myDictionary = new Dictionary<string, int>();

// // add key-value pairs to the dictionary
// myDictionary.Add("x", qx);
// myDictionary.Add("y", qy);

// // access the values by key
// int xValue = myDictionary["x"]; // returns qx
// int yValue = myDictionary["y"]; // returns qy
// //-------------------------------------------------