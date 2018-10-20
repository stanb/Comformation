using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation
{
    /// <summary>
    /// Resource Tag
    /// You can use the Resource Tags property to apply tags to resources, which can help you identify and categorize
    /// those resources. You can tag only resources for which AWS CloudFormation supports tagging. For information
    /// about which resources you can tag with AWS CloudFormation, see the individual resources in AWS Resource Types
    /// Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resource-tags.html
    /// </summary>
    public class Tag
    {

        /// <summary>
        /// Value
        /// The value for the tag. You can specify a value that is 1 to 255 Unicode characters in length and
        /// cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode
        /// letters, digits, whitespace, _, . , /, =, +, and -.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

        /// <summary>
        /// Key
        /// The key name of the tag. You can specify a value that is 1 to 127 Unicode characters in length and
        /// cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode
        /// letters, digits, whitespace, _, . , /, =, +, and -.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

    }
}
