using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Comformation.IntrinsicFunctions
{
    /// <summary>
    /// The intrinsic function Fn::Join appends a set of values into a single value, separated by the specified delimiter.
    /// If a delimiter is the empty string, the set of values are concatenated with no delimiter.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-join.html
    /// </summary>
    public class Join : IntrinsicFunction
    {
        private const string Name = "Fn::Join";

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="delimeter">The value you want to occur between fragments. The delimiter will occur between fragments only. It will not terminate the final value.</param>
        /// <param name="listOfValues">The list of values you want combined.</param>
        public Join(string delimeter, IEnumerable<Union<string, IntrinsicFunction>> listOfValues)
        {
            Token = new JObject(new JProperty(Name, 
                new JArray(delimeter, JArray.FromObject(listOfValues))));
        }
    }
}
