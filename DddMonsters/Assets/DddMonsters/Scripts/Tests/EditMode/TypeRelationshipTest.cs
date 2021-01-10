using DddMonsters.Domains;
using NUnit.Framework;

namespace DddMonsters.Tests.EditMode {
    public class TypeRelationshipTest {
        // ノーマル
        [Test]
        public void ノーマルでノーマルに攻撃すると普通() {
            Assert.That(TypeRelationshipCalculator.Calculate(Type.Normal, Type.Normal),
                Is.EqualTo(TypeRelationship.Ordinary));
        }

        [Test]
        public void ノーマルで火に攻撃すると普通() {
            Assert.That(TypeRelationshipCalculator.Calculate(Type.Normal, Type.Fire),
                Is.EqualTo(TypeRelationship.Ordinary));
        }

        [Test]
        public void ノーマルで水に攻撃すると普通() {
            Assert.That(TypeRelationshipCalculator.Calculate(Type.Normal, Type.Water),
                Is.EqualTo(TypeRelationship.Ordinary));
        }

        [Test]
        public void ノーマルで草に攻撃すると普通() {
            Assert.That(TypeRelationshipCalculator.Calculate(Type.Normal, Type.Leaf),
                Is.EqualTo(TypeRelationship.Ordinary));
        }

        // 火
        [Test]
        public void 火でノーマルに攻撃すると普通() {
            Assert.That(TypeRelationshipCalculator.Calculate(Type.Fire, Type.Normal),
                Is.EqualTo(TypeRelationship.Ordinary));
        }

        [Test]
        public void 火で火に攻撃すると不利() {
            Assert.That(TypeRelationshipCalculator.Calculate(Type.Fire, Type.Fire),
                Is.EqualTo(TypeRelationship.Disadvantage));
        }

        [Test]
        public void 火で水に攻撃すると不利() {
            Assert.That(TypeRelationshipCalculator.Calculate(Type.Fire, Type.Water),
                Is.EqualTo(TypeRelationship.Disadvantage));
        }

        [Test]
        public void 火で草に攻撃すると有利() {
            Assert.That(TypeRelationshipCalculator.Calculate(Type.Fire, Type.Leaf),
                Is.EqualTo(TypeRelationship.Advantage));
        }

        // 水

        [Test]
        public void 水でノーマルに攻撃すると普通() {
            Assert.That(TypeRelationshipCalculator.Calculate(Type.Water, Type.Normal),
                Is.EqualTo(TypeRelationship.Ordinary));
        }

        [Test]
        public void 水で火に攻撃すると有利() {
            Assert.That(TypeRelationshipCalculator.Calculate(Type.Water, Type.Fire),
                Is.EqualTo(TypeRelationship.Advantage));
        }

        [Test]
        public void 水で水に攻撃すると不利() {
            Assert.That(TypeRelationshipCalculator.Calculate(Type.Water, Type.Water),
                Is.EqualTo(TypeRelationship.Disadvantage));
        }

        [Test]
        public void 水で草に攻撃すると不利() {
            Assert.That(TypeRelationshipCalculator.Calculate(Type.Water, Type.Leaf),
                Is.EqualTo(TypeRelationship.Disadvantage));
        }

        // 草

        [Test]
        public void 草でノーマルに攻撃すると普通() {
            Assert.That(TypeRelationshipCalculator.Calculate(Type.Leaf, Type.Normal),
                Is.EqualTo(TypeRelationship.Ordinary));
        }

        [Test]
        public void 草で火に攻撃すると不利() {
            Assert.That(TypeRelationshipCalculator.Calculate(Type.Leaf, Type.Fire),
                Is.EqualTo(TypeRelationship.Disadvantage));
        }

        [Test]
        public void 草で水に攻撃すると有利() {
            Assert.That(TypeRelationshipCalculator.Calculate(Type.Leaf, Type.Water),
                Is.EqualTo(TypeRelationship.Advantage));
        }

        [Test]
        public void 草で草に攻撃すると不利() {
            Assert.That(TypeRelationshipCalculator.Calculate(Type.Leaf, Type.Leaf),
                Is.EqualTo(TypeRelationship.Disadvantage));
        }
    }
}
