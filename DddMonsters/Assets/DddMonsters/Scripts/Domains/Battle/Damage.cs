namespace DddMonsters.Domains {
    public readonly struct Damage {
        public readonly int value;

        public Damage(int value) {
            this.value = value;
        }

        public override string ToString() {
            return value.ToString();
        }
    }
}
