using Newtonsoft.Json.Linq;

namespace Comformation.IntrinsicFunctions
{
    /// <summary>
    /// The intrinsic function Ref returns the value of the specified parameter or resource.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-ref.html
    /// </summary>
    public class Ref : IntrinsicFunction
    {
        private const string Name = "Ref";

        public Ref(string logicalId)
        {
            Token = new JObject(new JProperty(Name, logicalId));
        }

        public Ref(PseudoParameter pseudoParameter)
        {
            Token = new JObject(new JProperty(Name, pseudoParameter.ToString()));
        }
    }
}
