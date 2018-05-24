using Newtonsoft.Json.Linq;

namespace Comformation.IntrinsicFunctions
{
    /// <summary>
    /// The intrinsic function Fn::ImportValue returns the value of an output exported by another stack. You typically use this function to create cross-stack references. In the following example template snippets, Stack A exports VPC security group values and Stack B imports them.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-importvalue.html
    /// </summary>
    public class ImportValue : IntrinsicFunction
    {
        private const string Name = "Fn::ImportValue";

        /// <summary>
        /// Constructor 
        /// </summary>
        /// <param name="sharedValueToImport">The stack output value that you want to import.</param>
        public ImportValue(Union<string, Base64, FindInMap, If, Join, Select, Split, Sub, Ref> sharedValueToImport)
        {
            Token = new JObject(new JProperty(Name, sharedValueToImport.ToJson()));
        }
    }
}
