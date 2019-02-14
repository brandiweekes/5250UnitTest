using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Models
{
    [TestFixture]
    public class CharacterUnitTests
    {
        [Test]
        public void ScaleLevel_Level_1_Should_Pass()
        {
            // Arrange
            var TestCharacter = new Crawl.Models.Character();
            var Level = 1;
            var Expected = true;

            // Act
            var Actual = TestCharacter.ScaleLevel(Level);

            // Reset


            // Assert
            Assert.AreEqual(Expected, Actual, TestContext.CurrentContext.Test.Name);
        }

        [Test]
        public void ScaleLevel_Level_0_Should_Fail()
        {
            // Arrange
            var TestCharacter = new Crawl.Models.Character();
            var Level = 0;
            var Expected = false;

            // Act
            var Actual = TestCharacter.ScaleLevel(Level);

            // Reset


            // Assert
            Assert.AreEqual(Expected, Actual, TestContext.CurrentContext.Test.Name);
        }

        [Test]
        public void ScaleLevel_Level_Neg1_Should_Fail()
        {
            // Arrange
            var TestCharacter = new Crawl.Models.Character();
            var Level = -1;
            var Expected = false;

            // Act
            var Actual = TestCharacter.ScaleLevel(Level);

            // Reset


            // Assert
            Assert.AreEqual(Expected, Actual, TestContext.CurrentContext.Test.Name);
        }

        [Test]
        public void ScaleLevel_Level_MaxLevel_Plus1_Should_Fail()
        {
            // Arrange
            var TestCharacter = new Crawl.Models.Character();
            var Level = Crawl.Models.LevelTable.MaxLevel + 1;
            var Expected = false;

            // Act
            var Actual = TestCharacter.ScaleLevel(Level);

            // Reset


            // Assert
            Assert.AreEqual(Expected, Actual, TestContext.CurrentContext.Test.Name);
        }

        [Test]
        public void ScaleLevel_Level_5_Equal_Level_Should_Fail()
        {
            // Arrange
            var TestCharacter = new Crawl.Models.Character();
            var Level = 5;
            TestCharacter.Level = Level;
            var Expected = false;

            // Act
            var Actual = TestCharacter.ScaleLevel(Level);

            // Reset


            // Assert
            Assert.AreEqual(Expected, Actual, TestContext.CurrentContext.Test.Name);
        }

        [Test]
        public void ScaleLevel_Level_5_Less_Than_Current_Level_Should_Fail()
        {
            // Arrange
            var TestCharacter = new Crawl.Models.Character();
            var Level = 5;
            TestCharacter.Level = Level;
            var Expected = false;

            // Act
            var Actual = TestCharacter.ScaleLevel(Level - 1);

            // Reset


            // Assert
            Assert.AreEqual(Expected, Actual, TestContext.CurrentContext.Test.Name);
        }

    }
}
