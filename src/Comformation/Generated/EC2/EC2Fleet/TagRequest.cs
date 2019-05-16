using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.EC2Fleet
{
    /// <summary>
    /// AWS::EC2::EC2Fleet TagRequest
    /// Specifies the tag key and value pair to use.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-tagrequest.html
    /// </summary>
    public class TagRequest
    {

        /// <summary>
        /// Value
        /// The key of the tag.
        /// Constraints: Tag keys are case-sensitive and accept a maximum of 127 Unicode characters. May not
        /// begin with aws:.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

        /// <summary>
        /// Key
        /// The value of the tag.
        /// Constraints: Tag values are case-sensitive and accept a maximum of 255 Unicode characters.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

    }
}
