using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EKS.Nodegroup
{
    /// <summary>
    /// AWS::EKS::Nodegroup Taint
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-nodegroup-taint.html
    /// </summary>
    public class Taint
    {

        /// <summary>
        /// Value
        /// The value of the taint.
        /// Required: No
        /// Type: String
        /// Minimum: 0
        /// Maximum: 63
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

        /// <summary>
        /// Effect
        /// The effect of the taint.
        /// Required: No
        /// Type: String
        /// Allowed values: NO_EXECUTE | NO_SCHEDULE | PREFER_NO_SCHEDULE
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Effect")]
        public Union<string, IntrinsicFunction> Effect { get; set; }

        /// <summary>
        /// Key
        /// The key of the taint.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 63
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

    }
}
