using NUnit.Framework;
using DddMonsters.Domains;

namespace DddMonsters.Tests.EditMode {
    public class DamageTest {
        static readonly MonsterProperties prop = new MonsterProperties(new HitPoint(100));
        static readonly MonsterMove normalMove = new MonsterMove(new MonsterMovePower(100), Type.Normal);
        static readonly MonsterMove fireMove = new MonsterMove(new MonsterMovePower(100), Type.Fire);
        static readonly MonsterMove waterMove = new MonsterMove(new MonsterMovePower(100), Type.Water);

        [Test]
        public void 通常タイプ() {
            var param = new MonsterParams(prop, Type.Normal);
            var dmg = DamageCalculator.Calculate(param, normalMove);
            Assert.That(dmg.value, Is.EqualTo(100));
        }

        [Test]
        public void 有利タイプ() {
            var param = new MonsterParams(prop, Type.Fire);
            var dmg = DamageCalculator.Calculate(param, waterMove);
            Assert.That(dmg.value, Is.EqualTo(200));
        }

        [Test]
        public void 不利タイプ() {
            var param = new MonsterParams(prop, Type.Water);
            var dmg = DamageCalculator.Calculate(param, fireMove);
            Assert.That(dmg.value, Is.EqualTo(50));
        }

        [Test]
        public void 相性倍率のダメージは切り捨てられる() {
            var fireMove2 = new MonsterMove(new MonsterMovePower(3), Type.Fire);
            var param = new MonsterParams(prop, Type.Water);
            var dmg = DamageCalculator.Calculate(param, fireMove2);
            // 1.5 が 切り捨てで 1 になる
            Assert.That(dmg.value, Is.EqualTo(1));
        }

        [Test]
        public void ToDamageFactorTest() {
            var x = TypeRelationship.Ordinary.ToDamageFactor();
            Assert.That(x, Is.EqualTo(1.0F));
            x = TypeRelationship.Advantage.ToDamageFactor();
            Assert.That(x, Is.EqualTo(2.0F));
            x = TypeRelationship.Disadvantage.ToDamageFactor();
            Assert.That(x, Is.EqualTo(0.5F));
        }
    }
}
