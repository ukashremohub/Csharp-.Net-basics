using System;

public class Program
{
	public static void Main()
	{
		Console.Write("Enter Operation (sum/sub/mul/div) : ");
		string Operation_string = Console.ReadLine();
		int a = Convert.ToInt32(Console.ReadLine());
		int b = Convert.ToInt32(Console.ReadLine());
		Addition A;
		try
		{
			if (Operation_string == "sum")
			{
				A = new Addition(a,b);
				Console.WriteLine("Sum of two numbers : " + A.Operation());
			}

			else if (Operation_string == "sub")
			{
				A = new Subraction(a,b);
				Console.WriteLine("Sub of two numbers : " + A.Operation());
			}

			else if (Operation_string == "mul")
			{
				//A = new Multiplication(a,b);
			//	Console.WriteLine("Mul of two numbers : " + A.Operation());
			}

			else if (Operation_string == "div")
			{
				//A = new Division(a,b);
				//Console.WriteLine("Div of two numbers : " + A.Operation());
			}

		}
		catch (Exception e)
		{
			Console.WriteLine("Error! " + e.Message);
		}

	}
}
public class Addition
{
	public int x = 0;
	public int y = 0;
	public Addition(int a, int b) {
		x = a;
		y = b;
	}
	public int Operation()
	{
		return x + y;
	}
}
public class Subraction : Addition
{
	public Subraction(int a, int b) :base(a,b)
	{ 
	}
	public int Operation()
	{
		return base.Operation();
	}
}
public class Multiplication : Addition
{
	public Multiplication(int a, int b) : base(a, b)
	{


	}
	public  int Operation()
	{
		return base.Operation();
	}
}
public class Division : Addition
{
	public Division(int a, int b) : base(a, b)
	{


	}
	public  int Operation()
	{
		return base.Operation();
	}
}