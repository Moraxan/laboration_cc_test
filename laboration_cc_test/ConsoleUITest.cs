using laboration_cc.classes;

namespace laboration_cc.Tests
{
	[TestClass]
	public class ConsoleUITests
	{
		[TestMethod]
		public void GetUserInput_ValidInput_ReturnsInput()
		{
			// Arrange
			var input = new ConsoleUI();

			// Act
			var result = input.GetUserInput("Test input");


			// Assert
			Assert.IsNotNull(result);

			// Cleanup
			
		}

		[TestMethod]
		public void GetUserInput_EmptyInput_ErrorMessageDisplayed()
		{
			// Arrange
			var input = new ConsoleUI();


			// Act
			var result = () => input.GetUserInput("");

			// Assert
			Assert.ThrowsException<NullReferenceException>(() => result());

			// Cleanup

		}
		[TestMethod]
		public void DisplayMessage_ValidMessage_MessageDisplayed()
		{
			// Arrange
			var input = new ConsoleUI();

			// Redirect console output to capture it
			using (var sw = new StringWriter())
			{
				Console.SetOut(sw);

				// Act
				input.DisplayMessage("Testing the display message method");

				// Assert
				Assert.AreEqual("Testing the display message method\r\n", sw.ToString()); // Include "\r\n" for line break
			}
		}
	}
}
