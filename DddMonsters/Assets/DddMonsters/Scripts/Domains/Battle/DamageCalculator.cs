using System;
using UnityEngine;

namespace DddMonsters.Domains {
    public static class DamageCalculator {
        public static Damage Calculate(MonsterParams monster, MonsterMove move) {
            // 対応による相性
            var rel = TypeRelationshipCalculator.Calculate(move.type, monster.monsterType);
            var damage = move.power.value * rel.ToDamageFactor();
            // 切り捨て
            return new Damage(Mathf.FloorToInt(damage));
        }
    }

    public static class TypeRelationshipDamageExtension {
        public static float ToDamageFactor(this TypeRelationship relationship) {
            switch (relationship) {
            case TypeRelationship.Ordinary:
                return 1.0F;
            case TypeRelationship.Advantage:
                return 2.0F;
            case TypeRelationship.Disadvantage:
                return 0.5F;
            default:
                throw new ArgumentOutOfRangeException(nameof(relationship), relationship, null);
            }
        }
    }
}
