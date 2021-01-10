namespace DddMonsters.Domains {
    public readonly struct HitPoint {
        public readonly int value;

        public HitPoint(int value) {
            this.value = value;
        }

        public override string ToString() {
            return value.ToString();
        }
    }
}
