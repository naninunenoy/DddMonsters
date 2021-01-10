using NUnit.Framework;
using DddMonsters.Domains;

namespace DddMonsters.Tests.EditMode
{
    public class DamageTest
    {
        [Test]
        public void DamageTest0() {
            var offence = new DamageParams();
            var defence = new DamageParams();
            var dmg = DamageCalculator.Calculate(offence, defence);
            Assert.That(dmg.value, Is.EqualTo(0));
        }
    }
}
