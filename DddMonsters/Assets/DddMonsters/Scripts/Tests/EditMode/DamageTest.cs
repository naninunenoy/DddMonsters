using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using DddMonsters.Domains;

namespace DddMonsters.Tests.EditMode
{
    public class DamageTest
    {
        [Test]
        public void DamageTest0() {
            var offence = new DamageParams();
            var defence = new DamageParams();
            var dmg = DamageCalculator.CalculateDamage(offence, defence);
            Assert.That(dmg.value, Is.EqualTo(0));
        }
    }
}
