namespace DddMonsters.Domains {
    public class WaterRelationshipJudge : ITypeRelationshipJudge {
        public TypeRelationship Judge(Type others) {
            switch (others) {
            case Type.Fire:
                return TypeRelationship.Advantage;
            case Type.Water:
                return TypeRelationship.Disadvantage;
            case Type.Leaf:
                return TypeRelationship.Disadvantage;
            case Type.Normal:
                return TypeRelationship.Ordinary;
            default:
                throw new System.ArgumentOutOfRangeException(nameof(others), others, null);
            }
        }
    }
}
