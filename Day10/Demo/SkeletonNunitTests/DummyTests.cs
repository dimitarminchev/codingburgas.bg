using NUnit.Framework;

namespace SkeletonNunitTests
{
    [TestFixture]
    public class DummyTests
    {
        [Test]
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

        [Test]
        public void DeadDummyThrowsExeption()
        {
            // Arrange
            Axe axe = new Axe(5, 5);
            Dummy dummy = new Dummy(5, 5);

            // Act
            axe.Attack(dummy);

            // Assert
            InvalidOperationException e = Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
            Assert.That(e.Message, Is.EqualTo("Dummy is dead."));
        }

        [Test]
        public void DeadDummyGivesExperience()
        {
            // Arrange
            Axe axe = new Axe(5, 5);
            Dummy dummy = new Dummy(5, 5);

            // Act
            axe.Attack(dummy);
            int experience = dummy.GiveExperience();

            // Assert
            Assert.That(experience, Is.EqualTo(5));
        }

        [Test]
        public void AliveDummyGivesExperience()
        {
            // Arrange
            Axe axe = new Axe(5, 5);
            Dummy dummy = new Dummy(10, 10);

            // Act
            axe.Attack(dummy);

            // Assert
            InvalidOperationException e = Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());
            Assert.That(e.Message, Is.EqualTo("Target is not dead."));
        }
    }
}