using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SkeletonMicrosoftTests
{
    [TestClass]
    public class HeroTests
    {
        private const string HeroName = "Pesho";

        [TestMethod]
        public void HeroGainsExperienceAfterAttackIfTargetDies()
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
    }
}