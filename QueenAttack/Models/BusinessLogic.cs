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
    public Board(int coordinateX, int coordinateY)
    {
      _queenX = coordinateX;
      _queenY = coordinateY;
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