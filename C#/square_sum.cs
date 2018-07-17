using System;

public static class Kata
{
  public static int SquareSum(int[] n)
  {
    int total = 0;
    foreach(int num in n) {
        total += (int)Math.Pow(num, 2);
    }

    return total;
  }
}
