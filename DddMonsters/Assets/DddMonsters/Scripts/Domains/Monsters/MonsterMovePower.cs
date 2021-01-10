namespace DddMonsters.Domains {
    public readonly struct MonsterMovePower {
        public readonly int value;

        public MonsterMovePower(int value) {
            this.value = value;
        }

        public override string ToString() {
            return value.ToString();
        }
    }
}
