namespace DddMonsters.Domains {
    public class MonsterProperties {
        public HitPoint Hp { set; get; }
        public MonsterProperties(HitPoint hp) {
            Hp = hp;
        }
    }
}
