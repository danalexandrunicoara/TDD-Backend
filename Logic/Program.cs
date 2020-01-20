using System;

namespace Logic
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var jokeClient = new JokeClient();
			do
			{
				var joke = jokeClient.GetJoke("jokes/random");
				Console.WriteLine(joke.Value.Joke);
				Console.WriteLine("-------------");
			} while (Console.ReadKey().Key != ConsoleKey.X);
		}
	}
}