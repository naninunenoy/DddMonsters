using DddMonsters.Domains;
using NUnit.Framework;

namespace DddMonsters.Tests.EditMode {
    public class TypeRelationshipCalculatorTest {
        [Test]
        public void タイプの漏れがないかテスト() {
            foreach (Type x in System.Enum.GetValues(typeof(Type))) {
                foreach (Type y in System.Enum.GetValues(typeof(Type))) {
                    try {
                        _ = TypeRelationshipCalculator.Calculate(x, y);
                    } catch (System.ArgumentOutOfRangeException e) {
                        Assert.Fail(e.Message);
                    }
                }
            }
        }
    }
}
