using System;
using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
	[TestClass]
	public class OperationsTests
	{
		private Operations _operations;

		[TestInitialize]
		public void TestInitialize()
		{
			_operations = new Operations();
		}

		[TestMethod]
		public void TestAdd()
		{
			// Assert
			var a = 1;
			var b = 2;

			// Act
			var actualResult = _operations.Add(a, b);

			// Assert
			var expectedResult = 3;
			Assert.AreEqual(expectedResult, actualResult);
		}

		[TestMethod]
		[ExpectedException(typeof(InvalidOperationException))]
		public void TestAddWithNullParameters()
		{
			// Assert
			int? a = null;
			int? b = null;

			// Act
			var actualResult = _operations.Add(a, b);

			// Assert
			var expectedResult = 3;
			Assert.AreEqual(expectedResult, actualResult);
		}

		[TestMethod]
		[ExpectedException(typeof(InvalidOperationException))]
		public void TestAddWithFirstParameterNull()
		{
			// Assert
			int? a = null;
			int? b = 1;

			// Act
			var actualResult = _operations.Add(a, b);

			// Assert
			var expectedResult = 3;
			Assert.AreEqual(expectedResult, actualResult);
		}

		[TestMethod]
		[ExpectedException(typeof(InvalidOperationException))]
		public void TestAddWithSecondParameterNull()
		{
			// Assert
			int? a = 1;
			int? b = null;

			// Act
			var actualResult = _operations.Add(a, b);

			// Assert
			var expectedResult = 3;
			Assert.AreEqual(expectedResult, actualResult);
		}

		[TestCleanup]
		public void TestCleanUp()
		{
			_operations = null;
		}
	}
}