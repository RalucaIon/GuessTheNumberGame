using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessGame
{
	class Program
	{
		static void Main(string[] args)
		{
			Random rng = new Random();
			int r = rng.Next(0, 100);
			bool correctGuess = false;



			while (!correctGuess)

			{
				try
				{
					Console.WriteLine("I am thinking of a number between 0 and 100.\n Please guess the number I am thinking of:");
					int x = Convert.ToInt32(Console.ReadLine());
					//Console.WriteLine(r);

					if (x == r)
					{
						Console.WriteLine("Congratulations! The number I was thinking was:" + r);
						correctGuess = true;
						Console.ReadLine();
					}

					else if (x > r)
					{
						Console.WriteLine("The guess was too big, the number I am thinking of is lower than " + x + ". Please guess again!");

					}

					else if (x < r)
					{
						Console.WriteLine("The guess was too low, the number I am thinking of is bigger than " + x + ". Please guess again!");

					}

				}
				catch (FormatException WrongInput)
				{
					Console.WriteLine("Wrong input!!");
				}
		}
	}
}
