namespace DddMonsters.Domains {
    public static class DamageCalculator {
        public static Damage Calculate(DamageParams offense, DamageParams defense) {
            // ToDo 一旦技の威力がそのままダメージ
            return new Damage(offense.move.power.value);
        }
    }
}
