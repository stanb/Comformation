using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.PrefixList
{
    /// <summary>
    /// AWS::EC2::PrefixList Entry
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-prefixlist-entry.html
    /// </summary>
    public class Entry
    {

        /// <summary>
        /// Cidr
        /// The CIDR block.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Cidr")]
        public Union<string, IntrinsicFunction> Cidr { get; set; }

        /// <summary>
        /// Description
        /// A description for the entry.
        /// Constraints: Up to 255 characters in length.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Description")]
        public Union<string, IntrinsicFunction> Description { get; set; }

    }
}
