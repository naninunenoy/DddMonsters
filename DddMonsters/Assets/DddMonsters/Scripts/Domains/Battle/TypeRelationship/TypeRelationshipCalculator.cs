namespace DddMonsters.Domains {
    public static class TypeRelationshipCalculator {
        static readonly ITypeRelationshipJudge normal = new NormalRelationshipJudge();
        static readonly ITypeRelationshipJudge fire = new FireRelationshipJudge();
        static readonly ITypeRelationshipJudge water = new WaterRelationshipJudge();
        static readonly ITypeRelationshipJudge leaf = new LeafRelationshipJudge();

        public static TypeRelationship Calculate(Type attacker, Type beAttacked) {
            switch (attacker) {
            case Type.Normal:
                return normal.Judge(beAttacked);
            case Type.Fire:
                return fire.Judge(beAttacked);
            case Type.Water:
                return water.Judge(beAttacked);
            case Type.Leaf:
                return leaf.Judge(beAttacked);
            default:
                throw new System.ArgumentOutOfRangeException(nameof(attacker), attacker, null);
            }
        }
    }
}
