using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaStore.Container
{
    /// <summary>
    /// AWS::MediaStore::Container MetricPolicy
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediastore-container-metricpolicy.html
    /// </summary>
    public class MetricPolicy
    {

        /// <summary>
        /// ContainerLevelMetrics
        /// A setting to enable or disable metrics at the container level.
        /// Required: Yes
        /// Type: String
        /// Allowed values: DISABLED | ENABLED
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ContainerLevelMetrics")]
        public Union<string, IntrinsicFunction> ContainerLevelMetrics { get; set; }

        /// <summary>
        /// MetricPolicyRules
        /// A parameter that holds an array of rules that enable metrics at the object level. This parameter is
        /// optional, but if you choose to include it, you must also include at least one rule. By default, you
        /// can include up to five rules. You can also request a quota increase to allow up to 300 rules per
        /// policy.
        /// Required: No
        /// Type: List of MetricPolicyRule
        /// Maximum: 300
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MetricPolicyRules")]
        public List<MetricPolicyRule> MetricPolicyRules { get; set; }

    }
}
