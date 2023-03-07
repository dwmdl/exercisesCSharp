namespace exercisesCSharp;

public static class StringCompare
{
	private static bool Compare(string? s1, string? s2)
	{
		if (s1 == null || s2 == null) return false;
		if (s1.Length != s2.Length) return false;

		for (var i = 0; i < s1.Length; i++)
		{
			int c1 = s1[i];
			int c2 = s2[i];
			if (Math.Abs(c1 - c2) > 1) return false;
		}

		return true; 
	}

	private static void Main()
	{
		var s1 = "UVWXY";
		var s2 = "UVWXY";
		var s3 = "XVWUY";
		Console.WriteLine(Compare(s1, s2));
		Console.WriteLine(Compare(s1, s3));
	}
}