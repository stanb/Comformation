using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.XRay.SamplingRule
{
    /// <summary>
    /// AWS::XRay::SamplingRule SamplingRuleRecord
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-xray-samplingrule-samplingrulerecord.html
    /// </summary>
    public class SamplingRuleRecord
    {

        /// <summary>
        /// CreatedAt
        /// When the rule was created, in Unix time seconds.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CreatedAt")]
        public Union<string, IntrinsicFunction> CreatedAt { get; set; }

        /// <summary>
        /// ModifiedAt
        /// When the rule was last modified, in Unix time seconds.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ModifiedAt")]
        public Union<string, IntrinsicFunction> ModifiedAt { get; set; }

        /// <summary>
        /// SamplingRule
        /// The sampling rule.
        /// Required: No
        /// Type: SamplingRule
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SamplingRule")]
        public SamplingRule SamplingRule { get; set; }

    }
}
