using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace SkeletonMicrosoftTests
{
    [TestClass]
    public class HeroTests
    {
        private const string HeroName = "Pesho";

        [TestMethod]
        public void TestHeroGainsExperienceAfterAttackIfTargetDies()
        {
            // Arrange
            ITarget fakeTarget = new FakeTarget(); // Health = 0, Experience = 20, Dead = true
            IWeapon fakeWeapon = new FakeWeapon(); // AttackPoints = 10, DurabilityPoints = 10
            Hero hero = new Hero(HeroName, fakeWeapon);

            // Act
            hero.Attack(fakeTarget);

            // Assert
            Assert.AreEqual(20, hero.Experience, "Hero Must Gain Experience After Attack.");
        }

        [TestMethod]
        public void TestHeroGainsExperienceAfterAttackIfTargetDiesUsingMock()
        {
            // Arrange
            Mock<ITarget> fakeTarget = new Mock<ITarget>();
            fakeTarget.Setup(t => t.Health).Returns(0);
            fakeTarget.Setup(t => t.GiveExperience()).Returns(20);
            fakeTarget.Setup(t => t.IsDead()).Returns(true);

            Mock<IWeapon> fakeWeapon = new Mock<IWeapon>();
            fakeWeapon.Setup(w => w.AttackPoints).Returns(10);
            fakeWeapon.Setup(w => w.DurabilityPoints).Returns(10);

            // Act
            Hero hero = new Hero(HeroName, fakeWeapon.Object);
            hero.Attack(fakeTarget.Object);

            // Assert
            Assert.AreEqual(20, hero.Experience, "Hero Must Gain Experience After Attack.");
        }

    }
}