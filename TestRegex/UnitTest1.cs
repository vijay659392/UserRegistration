using RegexProblem;
namespace TestRegex
{
    public class Tests
    {
        RegexMethod regexMethod = new RegexMethod();
        [Test]
        public void GivenFirstName_WhenAnalysed_ShouldReturnFirstName()
        {
            string expectedOutput = "First name matching with Regex";
            string actualOutput = regexMethod.ValidateFirstName("Vijay");
            Assert.That(actualOutput, Is.EqualTo(expectedOutput));
        }
    }
}