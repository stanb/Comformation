using Newtonsoft.Json.Linq;

namespace Comformation.IntrinsicFunctions
{
    public abstract class ConditionFunction : IntrinsicFunction
    {
        protected abstract string Name { get; }

        protected ConditionFunction(params Union<string, FindInMap, Ref, ConditionFunction, ConditionRef> [] conditions)
        {
            Token = new JObject(
                new JProperty(Name, JArray.FromObject(conditions)));
        }
    }

    public class And : ConditionFunction
    {
        protected override string Name => "Fn::And";

        public And(params Union<string, FindInMap, Ref, ConditionFunction, ConditionRef>[] conditions) : base(conditions)
        {
        }
    }

    public class Or : ConditionFunction
    {
        protected override string Name => "Fn::Or";

        public Or(params Union<string, FindInMap, Ref, ConditionFunction, ConditionRef>[] conditions) : base(conditions)
        {
        }
    }

    public class Not : ConditionFunction
    {
        protected override string Name => "Fn::Not";

        public Not(Union<string, FindInMap, Ref, ConditionFunction, ConditionRef> condition) : base(condition)
        {
        }
    }

    public class Equals : ConditionFunction
    {
        protected override string Name => "Fn::Equals";

        public Equals(Union<object, FindInMap, Ref, ConditionFunction> value1, Union<object, FindInMap, Ref, ConditionFunction> value2)
        {
            Token = new JObject(
                new JProperty(Name,
                    new JArray(value1.ToJson(), value2.ToJson())));
        }
    }

    public class If : ConditionFunction
    {
        protected override string Name => "Fn::If";

        public If(
            string conditionName, 
            Union<object, Base64, FindInMap, GetAtt, GetAZs, If, Join, Select, Ref> valueIfTrue, 
            Union<object, Base64, FindInMap, GetAtt, GetAZs, If, Join, Select, Ref> valueIfFalse)
        {
            Token = new JObject(
                new JProperty(Name,
                    new JArray(conditionName, valueIfTrue.ToJson(), valueIfFalse.ToJson())));
        }
    }

    /// <summary>
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-conditions.html
    /// </summary>
    public class ConditionRef
    {
        public string Condition { get; set; }
    }
}
