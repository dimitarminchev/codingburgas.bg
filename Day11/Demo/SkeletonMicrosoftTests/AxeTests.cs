using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SkeletonMicrosoftTests
{
    [TestClass]
    public class AxeTests
    {
        [TestMethod]
        public void AxeLosesDurabiltyAfterAttack()
        {
            // Arrange
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(10, 10);

            // Act
            axe.Attack(dummy);

            // Assert
            Assert.AreEqual(9, axe.DurabilityPoints, "Axe Durability doesn't change after attack.");
        }

        [TestMethod]
        public void BrokenAxeCanNotAttack()
        {
            // Arrange
            Axe axe = new Axe(2, 2);
            Dummy dummy = new Dummy(20, 20);

            // Act
            axe.Attack(dummy);
            axe.Attack(dummy);

            // Assert
            InvalidOperationException e = Assert.ThrowsException<InvalidOperationException>(() => axe.Attack(dummy));
            Assert.AreEqual(e.Message, "Axe is broken.");
        }
    }
}
