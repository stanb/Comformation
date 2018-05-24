using Newtonsoft.Json;

namespace Comformation.IntrinsicFunctions
{
    /// <summary>
    /// Pseudo parameters are parameters that are predefined by AWS CloudFormation.
    /// You do not declare them in your template.
    /// Use them the same way as you would a parameter, as the argument for the Ref function.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/pseudo-parameter-reference.html
    /// </summary>
    [JsonConverter(typeof(ToStringJsonConverter))]
    public class PseudoParameter
    {
        public static readonly PseudoParameter AccountId = new PseudoParameter("AWS::AccountId");
        public static readonly PseudoParameter NoValue = new PseudoParameter("AWS::NoValue");
        public static readonly PseudoParameter Partition = new PseudoParameter("AWS::Partition");
        public static readonly PseudoParameter Region = new PseudoParameter("AWS::Region");
        public static readonly PseudoParameter StackId = new PseudoParameter("AWS::StackId");
        public static readonly PseudoParameter StackName = new PseudoParameter("AWS::StackName");
        public static readonly PseudoParameter UrlSuffix = new PseudoParameter("AWS::URLSuffix");
        
        private readonly string _value;

        private PseudoParameter(string value)
        {
            _value = value;
        }

        public override string ToString()
        {
            return _value;
        }
    }
}
