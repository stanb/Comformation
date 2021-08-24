using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation
{
    /// <summary>
    /// Resource tag
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resource-tags.html
    /// </summary>
    public class Tag
    {

        /// <summary>
        /// Key
        /// The key name of the tag. You can specify a value that&#39;s 1 to 128 Unicode characters in length and
        /// can&#39;t be prefixed with aws:. You can use any of the following characters: the set of Unicode
        /// letters, digits, whitespace, _, . , /, =, +, and -.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

        /// <summary>
        /// Value
        /// The value for the tag. You can specify a value that&#39;s 1 to 256 characters in length.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

    }
}
