using System.Collections.Generic;

namespace BusinessLogic
{
	public class Value
	{
		public int Id { get; set; }
		public string Joke { get; set; }
		public List<object> Categories { get; set; }
	}

	public class JokeDto
	{
		public string Type { get; set; }
		public Value Value { get; set; }
	}
}