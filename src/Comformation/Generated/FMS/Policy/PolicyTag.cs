using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.FMS.Policy
{
    /// <summary>
    /// AWS::FMS::Policy PolicyTag
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fms-policy-policytag.html
    /// </summary>
    public class PolicyTag
    {

        /// <summary>
        /// Key
        /// Part of the key:value pair that defines a tag. You can use a tag key to describe a category of
        /// information, such as &quot;customer. &quot; Tag keys are case-sensitive.
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
        /// Part of the key:value pair that defines a tag. You can use a tag value to describe a specific value
        /// within a category, such as &quot;companyA&quot; or &quot;companyB. &quot; Tag values are case-sensitive.
        /// Required: Yes
        /// Type: String
        /// Minimum: 0
        /// Maximum: 256
        /// Pattern: ^([\p{L}\p{Z}\p{N}_. :/=+\-@]*)$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

    }
}
