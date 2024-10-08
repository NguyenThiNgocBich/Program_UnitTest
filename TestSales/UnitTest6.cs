using Labrary1;


namespace TestProject1
{
    [TestClass] 
    public class UnitTest6
    {
        [TestMethod] 
        public void TestJanuaryHas31Days()
        {
            // Arrange
            MonthDays monthDays = new MonthDays();

            // Act
            string[] result = monthDays.GetDaysInEachMonth();

            // Assert
            Assert.AreEqual("January has 31 days.", result[0]); 
        }

        [TestMethod] 
        public void TestFebruaryHas28Days()
        {
            // Arrange
            MonthDays monthDays = new MonthDays();

            // Act
            string[] result = monthDays.GetDaysInEachMonth();

            // Assert
            Assert.AreEqual("February has 28 days.", result[1]); 
        }
    }

}



