using Newtonsoft.Json.Linq;

namespace Comformation.IntrinsicFunctions
{
    /// <summary>
    /// To split a string into a list of string values so that you can select an element from the resulting string
    /// list, use the Fn::Split intrinsic function. Specify the location of splits with a delimiter, such as ,
    /// (a comma). After you split a string, use the Fn::Select function to pick a specific element.
    /// For example, if a comma-delimited string of subnet IDs is imported to your stack template, you can split
    /// the string at each comma. From the list of subnet IDs, use the Fn::Select intrinsic function to specify a
    /// subnet ID for a resource.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-split.html
    /// </summary>
    public class Split : IntrinsicFunction
    {
        private const string Name = "Fn::Split";

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="delimiter">A string value that determines where the source string is divided.</param>
        /// <param name="listOfValues">The string value that you want to split.</param>
        public Split(string delimiter, Union<string, Base64, FindInMap, GetAtt, GetAZs, If, Join, Select, Ref> listOfValues)
        {
            Token = new JObject(new JProperty(Name, new JArray(delimiter, listOfValues.ToJson())));
        }
    }
}
