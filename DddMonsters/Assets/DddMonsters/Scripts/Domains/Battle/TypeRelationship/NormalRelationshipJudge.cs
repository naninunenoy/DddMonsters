namespace DddMonsters.Domains {
    public class NormalRelationshipJudge : ITypeRelationshipJudge {
        public TypeRelationship Judge(Type others) {
            switch (others) {
            case Type.Fire:
                return TypeRelationship.Ordinary;
            case Type.Water:
                return TypeRelationship.Ordinary;
            case Type.Leaf:
                return TypeRelationship.Ordinary;
            case Type.Normal:
                return TypeRelationship.Ordinary;
            default:
                throw new System.ArgumentOutOfRangeException(nameof(others), others, null);
            }
        }
    }
}
