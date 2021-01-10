namespace DddMonsters.Domains {
    public readonly struct MonsterMove {
        public readonly MonsterMovePower power;
        public readonly Type type;
        public MonsterMove(MonsterMovePower power, Type type) {
            this.power = power;
            this.type = type;
        }
    }
}
