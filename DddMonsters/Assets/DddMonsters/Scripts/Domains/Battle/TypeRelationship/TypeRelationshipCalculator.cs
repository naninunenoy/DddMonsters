namespace DddMonsters.Domains {
    public static class TypeRelationshipCalculator {
        static readonly ITypeRelationshipJudge normal = new NormalRelationshipJudge();
        static readonly ITypeRelationshipJudge fire = new FireRelationshipJudge();
        static readonly ITypeRelationshipJudge water = new WaterRelationshipJudge();
        static readonly ITypeRelationshipJudge leaf = new LeafRelationshipJudge();

        public static TypeRelationship Calculate(Type mine, Type others) {
            switch (mine) {
            case Type.Normal:
                return normal.Judge(others);
            case Type.Fire:
                return fire.Judge(others);
            case Type.Water:
                return water.Judge(others);
            case Type.Leaf:
                return leaf.Judge(others);
            default:
                throw new System.ArgumentOutOfRangeException(nameof(mine), mine, null);
            }
        }
    }
}
