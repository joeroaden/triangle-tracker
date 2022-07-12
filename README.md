_Tests_

Describe CheckType ()
  Test: It should prompt user for 3 sides
  Code: CheckType();
  Expected Output: true -->

  Test: It should return a triangle from the user input
  Code: CheckType()
  Expected: return a triangle -->


  Test: it should determine if a user creates a triangle
  Code : CheckType (15, 4, 2)
  Expected: return "not a triangle"

  Test: It should determine an equilateral triangle
  Code: CheckType(2,2,2)
  Expected: return "equilateral triangle"

  Test: It should determine an scalene triangle
  Code: CheckType(2,3,4)
  Expected: return "scalene triangle"

  Test: It should determine an isosceles triangle
  Code: CheckType(2,3,2)
  Expected: return "isosceles triangle"

