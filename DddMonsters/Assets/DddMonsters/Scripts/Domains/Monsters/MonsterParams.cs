namespace DddMonsters.Domains {
    public struct MonsterParams {
        public readonly MonsterProperties monsterProperties;
        public readonly Type monsterType;

        public MonsterParams(MonsterProperties monsterProperties, Type monsterType) {
            this.monsterProperties = monsterProperties;
            this.monsterType = monsterType;
        }
    }
}
