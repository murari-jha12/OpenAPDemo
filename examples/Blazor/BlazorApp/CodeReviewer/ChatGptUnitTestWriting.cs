using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlazorApp.CodeReviewer
{
    public class ChatGptUnitTestWriting
    {
        public string CheckPassenger(int age)
        {
            if (age > 2)
            {
                return "Adult";
            }
            else
            {
                return "Infant";
            }

        }

        [TestMethod]
        public void CheckPassenger_Age2_Infant()
        {

            // Arrange 
            int age = 2;

            // Act 
            var result = CheckPassenger(age);

            // Assert
            Assert.AreEqual("Infant", result);
        }

        [TestMethod]
        public void CheckPassenger_Age3_Adult()
        {

            // Arrange 
            int age = 3;

            // Act 
            var result = CheckPassenger(age);

            // Assert
            Assert.AreEqual("Adult", result);
        }


        public bool VoterEligibility(int age)
        {
            if (age >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        [TestMethod]
        public void TestVoterEligibility()
        {
            // Arrange
            bool expected;
            // Act
            expected = VoterEligibility(18);
            // Assert
            Assert.IsTrue(expected);
        }

        [TestMethod]
        public void TestVoterEligibility2()
        {
            // Arrange
            bool expected;
            // Act
            expected = VoterEligibility(17);
            // Assert
            Assert.IsFalse(expected);
        }

    }
}
