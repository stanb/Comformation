using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.FMS.Policy
{
    /// <summary>
    /// AWS::FMS::Policy ResourceTag
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fms-policy-resourcetag.html
    /// </summary>
    public class ResourceTag
    {

        /// <summary>
        /// Key
        /// The resource tag key.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 128
        /// Pattern: ^([\p{L}\p{Z}\p{N}_. :/=+\-@]*)$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

        /// <summary>
        /// Value
        /// The resource tag value.
        /// Required: No
        /// Type: String
        /// Maximum: 256
        /// Pattern: ^([\p{L}\p{Z}\p{N}_. :/=+\-@]*)$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

    }
}
