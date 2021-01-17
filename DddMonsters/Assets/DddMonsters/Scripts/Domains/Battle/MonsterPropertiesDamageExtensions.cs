namespace DddMonsters.Domains.Battle {
    public static class MonsterPropertiesDamageExtensions {
        public static HitPoint GetDamagedHitPoint(this Damage damage, HitPoint original) {
            var remain = original.value - damage.value;
            if (remain < 0) {
                remain = 0;
            }

            return new HitPoint(remain);
        }

        public static MonsterProperties GetDamagedMonsterProperties(this Damage damage, MonsterProperties props) {
            var hitPoint = damage.GetDamagedHitPoint(props.Hp);
            return new MonsterProperties(hitPoint);
        }
    }
}
