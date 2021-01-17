using NUnit.Framework;
using DddMonsters.Domains;

namespace DddMonsters.Tests.EditMode {
    public class DamageTest {
        MonsterProperties ofnProp = new MonsterProperties(new HitPoint(100));
        MonsterMove ofnMove = new MonsterMove(new MonsterMovePower(100), Type.Normal);
        MonsterProperties defProp = new MonsterProperties(new HitPoint(100));
        MonsterMove defMove = new MonsterMove(new MonsterMovePower(100), Type.Normal);

        [Test]
        public void DamageTest0() {
            var offence = new DamageParams(ofnProp, ofnMove);
            var defence = new DamageParams(defProp, defMove);
            var dmg = DamageCalculator.Calculate(offence, defence);
            Assert.That(dmg.value, Is.EqualTo(100));
        }
    }
}
