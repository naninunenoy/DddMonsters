using System.Collections.Generic;

namespace DddMonsters.Domains {
    public class Monster {
        public Type Type { get; }
        public MonsterProperties Properties { get; }
        public IList<MonsterMove> Moves { get; }
        public Monster(Type type, MonsterProperties properties, IList<MonsterMove> moves) {
            Type = type;
            Properties = properties;
            Moves = moves;
        }

        public bool IsDead() => Properties.Hp.value <= 0;
    }
}
