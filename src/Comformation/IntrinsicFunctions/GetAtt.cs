using Newtonsoft.Json.Linq;

namespace Comformation.IntrinsicFunctions
{
    /// <summary>
    /// The Fn::GetAtt intrinsic function returns the value of an attribute from a resource in the template.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-getatt.html
    /// </summary>
    public class GetAtt : IntrinsicFunction
    {
        private const string Name = "Fn::GetAtt";

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="logicalId">The logical name (also called logical ID) of the resource that contains the attribute that you want.</param>
        /// <param name="attribute">The name of the resource-specific attribute whose value you want. See the resource's reference page for details about the attributes available for that resource type.</param>
        public GetAtt(string logicalId, ResourceAttribute attribute)
        {
            Token = new JObject(
                new JProperty(Name,
                    new JArray(logicalId, attribute.Name)));
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="logicalId">The logical name (also called logical ID) of the resource that contains the attribute that you want.</param>
        /// <param name="attribute">The name of the resource-specific attribute whose value you want. See the resource's reference page for details about the attributes available for that resource type.</param>
        public GetAtt(string logicalId, Ref attribute)
        {
            Token = new JObject(
                new JProperty(Name,
                    new JArray(logicalId, attribute.ToJson())));
        }
    }
}
