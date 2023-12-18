using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SkeletonMicrosoftTests
{
    [TestClass]
    public class DummyTests
    {
        [TestMethod]
        public void DummyLosesHealthAfterAttack()
        {
            // Arrange
            Axe axe = new Axe(1, 1);
            Dummy dummy = new Dummy(2, 2);

            // Act
            axe.Attack(dummy);

            // Assert
            Assert.AreEqual(1, dummy.Health, "Dummy doesn't lose health after attack.");
        }

        [TestMethod]
        public void DeadDummyThrowsExeption()
        {
            // Arrange
            Axe axe = new Axe(5, 5);
            Dummy dummy = new Dummy(5, 5);

            // Act
            axe.Attack(dummy);

            // Assert
            InvalidOperationException e = Assert.ThrowsException<InvalidOperationException>(() => axe.Attack(dummy));
            Assert.AreEqual(e.Message, "Dummy is dead.");
        }

        [TestMethod]
        public void DeadDummyGivesExperience()
        {
            // Arrange
            Axe axe = new Axe(5, 5);
            Dummy dummy = new Dummy(5, 5);

            // Act
            axe.Attack(dummy);
            int experience = dummy.GiveExperience();

            // Assert
            Assert.AreEqual(experience, 5);
        }

        [TestMethod]
        public void AliveDummyGivesExperience()
        {
            // Arrange
            Axe axe = new Axe(5, 5);
            Dummy dummy = new Dummy(10, 10);

            // Act
            axe.Attack(dummy);

            // Assert
            InvalidOperationException e = Assert.ThrowsException<InvalidOperationException>(() => dummy.GiveExperience());
            Assert.AreEqual(e.Message, "Target is not dead.");
        }
    }
}