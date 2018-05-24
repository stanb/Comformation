using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Comformation.IntrinsicFunctions
{
    /// <summary>
    /// The intrinsic function Fn::Select returns a single object from a list of objects by index.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-select.html
    /// </summary>
    /// <remarks>
    /// Fn::Select does not check for null values or if the index is out of bounds of the array.
    /// Both conditions will result in a stack error, so you should be certain that the index you choose is valid,
    /// and that the list contains non-null values.
    /// </remarks>
    public class Select : IntrinsicFunction
    {
        private const string Name = "Fn::Select";
        
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="index">The index of the object to retrieve. This must be a value from zero to N-1, where N represents the number of elements in the array.</param>
        /// <param name="listOfObjects">The list of objects to select from. This list must not be null, nor can it have null entries.</param>
        public Select(
            Union<string, Ref, FindInMap> index,
            Union<string, IEnumerable<string>, FindInMap, GetAtt, GetAZs, If, Split, Ref> listOfObjects)
        {
            Token = new JObject(
                new JProperty(Name,
                    new JArray(index.ToJson(), listOfObjects.ToJson())));
        }
    }
}
