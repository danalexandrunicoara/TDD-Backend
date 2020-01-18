using System;

namespace BusinessLogic
{
	/// <summary>
	///     Operations class.
	/// </summary>
	public class Operations
	{
		/// <summary>
		///     Adds two numbers.
		/// </summary>
		/// <param name="a">First number.</param>
		/// <param name="b">Second number.</param>
		/// <returns>The sum of a and b.</returns>
		public int? Add(int? a, int? b)
		{
			if (a == null || b == null) throw new InvalidOperationException();
			return a + b;
		}
	}
}