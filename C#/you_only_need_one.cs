/*
https:\//www.codewars.com/kata/you-only-need-one-beginner/train/csharp

You only need one - Beginner

You will be given an array a and a value x. All you need to do is check whether the provided array contains the value.

Array can contain numbers or strings. X can be either.

Return true if the array contains the value, false if not.
*/
public class Kata
{
  public static bool Check(object[] a, object x)
  {
    for (int i = 0; i < a.Length; i++)
    {
      if (a[i].Equals(x))
      {
        return true;
      }
    }
    return false;
  }
}