using System;

class Program
{

	private static bool IsPalindrome(string input)
	{
		int left = 0;
		int right = input.Length - 1;

		while(left < right)
		{
			if (input[left] != input[right]) return false;

			left++;
			right--;
		}

		return true;
	}

	private static bool IsPrimeNumber(int input)
	{
		if(input <= 1) return false;

		for(int i = 2; i <= Math.Sqrt(input); i++)
		{
			if (input % 1 == 0) return false;
		}

		return true;
	}

	static void Main()
	{
		// Palindrom Tester
		Console.WriteLine(IsPalindrome("NISSIN") ? "Palindrome" : "Not a palindrome");

		// Prime Number Checker
		Console.WriteLine(IsPrimeNumber(1) ? "Prime Number" : "Not a prime number");
	}
}