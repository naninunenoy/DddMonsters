namespace DddMonsters.Domains
{
    public interface ITypeRelationshipJudge {
        public TypeRelationship Judge(Type others);
    }
}
