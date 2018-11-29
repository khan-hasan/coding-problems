// https:\//www.codewars.com/kata/twice-as-old/train/csharp
/*
Your function takes two arguments:

current father's age (years)
current age of his son (years)
Сalculate how many years ago the father was twice as old as his son (or in how many years he will be twice as old).
*/
using System;

namespace Solution
{
	public class TwiceAsOldSolution
	{
		public static int TwiceAsOld(int dadYears, int sonYears)
		{
			int dadYearsWhenSonBorn = dadYears - sonYears;
			int dadYearsWhenTwiceAsOldAsSon = dadYearsWhenSonBorn * 2;
			int dadYearsFromWhenTwiceAsOldAsSon = Math.Abs(dadYears - dadYearsWhenTwiceAsOldAsSon);
			return dadYearsFromWhenTwiceAsOldAsSon;
		}
	}
}