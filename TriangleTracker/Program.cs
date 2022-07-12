using System;
using System.Collections.Generic;
using TriangleTracker.Models;

namespace TriangleTracker
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter Side 1:");
      string stringSideOne = Console.ReadLine();
      int sideOne = int.Parse(stringSideOne);

      Console.WriteLine("Enter Side 2:");
      string stringSideTwo = Console.ReadLine();
      int sideTwo = int.Parse(stringSideTwo);

      Console.WriteLine("Enter Side 3:");
      string stringSideThree = Console.ReadLine();
      int sideThree = int.Parse(stringSideThree);
      
      Triangle usersTriangle = new Triangle(sideOne, sideTwo, sideThree);
      Console.WriteLine("Side 1 = " + sideOne);
      Console.WriteLine("Side 2 = " + sideTwo);
      Console.WriteLine("Side 3 = " + sideThree);
      Console.WriteLine(usersTriangle.CheckType());




    }


  }
}