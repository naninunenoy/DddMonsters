namespace DddMonsters.Domains {
    public class LeafRelationshipJudge : ITypeRelationshipJudge {
        public TypeRelationship Judge(Type others) {
            switch (others) {
            case Type.Fire:
                return TypeRelationship.Disadvantage;
            case Type.Water:
                return TypeRelationship.Advantage;
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
