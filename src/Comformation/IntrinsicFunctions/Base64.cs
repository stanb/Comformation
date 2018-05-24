using Newtonsoft.Json.Linq;

namespace Comformation.IntrinsicFunctions
{
    /// <summary>
    /// The intrinsic function Fn::Base64 returns the Base64 representation of the input string. This function is typically used to pass encoded data to Amazon EC2 instances by way of the UserData property.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-base64.html
    /// </summary>
    public class Base64 : IntrinsicFunction
    {
        private const string Name = "Fn::Base64";

        /// <summary>
        /// Constructor 
        /// </summary>
        /// <param name="valueToEncode">The string value you want to convert to Base64.</param>
        public Base64(Union<string, IntrinsicFunction> valueToEncode)
        {
            Token = new JObject(
                new JProperty(Name, valueToEncode.ToJson()));
        }
    }
}
