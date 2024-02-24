using System;
class Program
{
  public static void Main (string[]args)
  {
	try
	{
	  double numberFirst, numberSecond;
	  double sum;
	    Console.Write ("Enter the first number: ");
	  while (!double.TryParse (Console.ReadLine (), out numberFirst))
		{
		  Console.Write ("Invalid input. Please enter a valid number: ");
		}

	  Console.Write ("Enter the second number: ");
	  while (!double.TryParse (Console.ReadLine (), out numberSecond))
		{
		  Console.Write ("Invalid input. Please enter a valid number: ");
		}
      sum = numberFirst + numberSecond;
	  Console.WriteLine ($"The sum of {numberFirst} and {numberSecond} is: {sum}");
	}
	catch (Exception Ex)
	{
	  Console.WriteLine ($"An error occurred: {Ex.Message}");
	}
  }
}
