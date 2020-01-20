using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
	[TestClass]
	public class JokeClientTests
	{
		private JokeClient _jokeClient;

		[TestInitialize]
		public void TestInitialize()
		{
			_jokeClient = new JokeClient();
		}

		[TestMethod]
		public void TestJokeClientWithEmptyPath()
		{
			// Arrange
			var path = string.Empty;

			// Act
			var actualResult = _jokeClient.GetJoke(path);

			// Assert
			Assert.AreEqual(null, actualResult);
		}

		[TestMethod]
		public void TestJokeClientWithWrongPath()
		{
			// Arrange
			var path = "wrong path";

			// Act
			var actualResult = _jokeClient.GetJoke(path);

			// Assert
			Assert.AreEqual(null, actualResult);
		}

		[TestMethod]
		public void TestJokeClient()
		{
			// Arrange
			var path = "jokes/random";

			// Act
			var actualResult = _jokeClient.GetJoke(path);

			// Assert
			Assert.IsTrue(!string.IsNullOrWhiteSpace(actualResult.Type));
			Assert.IsTrue(!string.IsNullOrWhiteSpace(actualResult.Value.Joke));
			Assert.IsTrue(actualResult.Value.Id != 0);
			Assert.IsNotNull(actualResult.Value.Categories);
		}

		[TestCleanup]
		public void TestCleanUp()
		{
			_jokeClient = null;
		}
	}
}