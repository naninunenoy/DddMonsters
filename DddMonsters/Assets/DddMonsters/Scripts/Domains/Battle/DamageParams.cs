namespace DddMonsters.Domains {
    public readonly struct DamageParams {
        public readonly MonsterProperties monsterProperties;
        public readonly MonsterMove move;

        public DamageParams(MonsterProperties monsterProperties, MonsterMove move) {
            this.monsterProperties = monsterProperties;
            this.move = move;
        }
    }
}
