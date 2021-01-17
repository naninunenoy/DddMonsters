using System.Collections.Generic;
using DddMonsters.Domains;
using NUnit.Framework;

namespace DddMonsters.Tests.EditMode {
    public class MonsterTest {
        [Test]
        public void HP0以下で戦闘不能() {
            var alive = new Monster(Type.Normal, new MonsterProperties(new HitPoint(1)), new List<MonsterMove>());
            Assert.That(alive.IsDead(), Is.False);
            var dead = new Monster(Type.Normal, new MonsterProperties(new HitPoint(0)), new List<MonsterMove>());
            Assert.That(dead.IsDead(), Is.True);
        }
    }
}
