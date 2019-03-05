using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp40
{
	class Program
	{
		static void Main(string[] args)
		{
			string inputPlayer, inputCPU ;
			int RandomInt;
			
			bool playAgain = true;

			while (playAgain)
			{
				int scorePlayer = 0;
				int scoreCPU = 0;


				while (scorePlayer < 2 && scoreCPU < 2)
				{



					Console.Write("\nChoose Between Rock ,Paper And Scissors : ");
					inputPlayer = Console.ReadLine();

					Random rnd = new Random();

					RandomInt = rnd.Next(1, 4);

					switch (RandomInt)
					{
						case 1:
							inputCPU = "Rock";
							Console.WriteLine("\nComputer Choose Rock\n");
							if (inputPlayer == "Rock")
							{
								Console.WriteLine("Draw!\n\n");
							}
							else if (inputPlayer == "Paper")
							{
								Console.WriteLine("Player Wins!\n\n");
								scorePlayer++;
							}
							else if (inputPlayer == "Scissors")
							{
								Console.WriteLine("CPU Wins!\n\n");
								scoreCPU++;
							}
							break;
						case 2:
							inputCPU = "Paper";

							Console.WriteLine("\nComputer Choose Paper");
							if (inputPlayer == "Paper")
							{
								Console.WriteLine("Draw!\n\n");
							}
							else if (inputPlayer == "Scissors")
							{
								Console.WriteLine("Player Wins!\n\n");
								scorePlayer++;
							}
							else if (inputPlayer == "Rock")
							{
								Console.WriteLine("CPU Wins!\n\n");
								scoreCPU++;
							}
							break;
						case 3:
							inputCPU = "Scissors";

							Console.WriteLine("\nComputer Choose Scissors");
							if (inputPlayer == "Scissors")
							{
								Console.WriteLine("Draw!\n\n");
							}
							else if (inputPlayer == "Rock")
							{
								Console.WriteLine("Player Wins!\n\n");
								scorePlayer++;
							}
							else if (inputPlayer == "Paper")
							{
								Console.WriteLine("CPU Wins!\n\n");
								scoreCPU++;
							}
							break;
					
						default:
							Console.WriteLine("Invalid Entry!");
							break;
					}

					Console.WriteLine("\nScore :- \nPlayer : \t{0}\t CPU : \t{1}", scorePlayer, scoreCPU);
				}
				if (scorePlayer == 3)
				{
					Console.WriteLine("Player Wins!\n");
				}
				else if (scoreCPU == 3)
				{
					Console.WriteLine("CPU Wins!\n");
				}

				Console.WriteLine("Do You Want To Play Again?(Y/N) : ");

				string loop = Console.ReadLine();
				if (loop == "Y")
				{
					playAgain = true;
					Console.Clear();
				}
				else if (loop == "N")
				{
					playAgain = false;
				}
				else
				{

				}

			}
		}

		private static string NewMethod()
		{
			return Console.ReadLine();
		}
	}
}
