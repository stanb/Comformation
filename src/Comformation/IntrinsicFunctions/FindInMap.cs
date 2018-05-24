using Newtonsoft.Json.Linq;

namespace Comformation.IntrinsicFunctions
{
    /// <summary>
    /// The intrinsic function Fn::FindInMap returns the value corresponding to keys in a two-level map that is declared in the Mappings section.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-findinmap.html
    /// </summary>
    public class FindInMap : IntrinsicFunction
    {
        private const string Name = "Fn::FindInMap";

        /// <summary>
        /// Constructor 
        /// </summary>
        /// <param name="mapName">The logical name of a mapping declared in the Mappings section that contains the keys and values.</param>
        /// <param name="topLevelKey">The top-level key name. Its value is a list of key-value pairs.</param>
        /// <param name="secondLevelKey">The second-level key name, which is set to one of the keys from the list assigned to TopLevelKey.</param>
        public FindInMap(Union<string, Ref, FindInMap> mapName, Union<string, Ref, FindInMap> topLevelKey, Union<string, Ref, FindInMap> secondLevelKey)
        {
            Token = new JObject(
                new JProperty(Name,
                    new JArray(mapName.ToJson(), topLevelKey.ToJson(), secondLevelKey.ToJson())));
        }
    }
}
