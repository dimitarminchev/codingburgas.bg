using NUnit.Framework;

namespace SkeletonNunitTests
{
    [TestFixture]
    public class AxeTests
    {
        [Test]
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

        [Test]
        public void BrokenAxeCanNotAttack()
        {
            // Arrange
            Axe axe = new Axe(2, 2);
            Dummy dummy = new Dummy(20, 20);

            // Act
            axe.Attack(dummy);
            axe.Attack(dummy);

            // Assert
            InvalidOperationException e = Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
            Assert.That(e.Message, Is.EqualTo("Axe is broken."));
        }
    }
}