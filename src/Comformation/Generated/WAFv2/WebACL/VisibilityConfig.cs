using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFv2.WebACL
{
    /// <summary>
    /// AWS::WAFv2::WebACL VisibilityConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-visibilityconfig.html
    /// </summary>
    public class VisibilityConfig
    {

        /// <summary>
        /// SampledRequestsEnabled
        /// A boolean indicating whether AWS WAF should store a sampling of the web requests that match the
        /// rules. You can view the sampled requests through the AWS WAF console.
        /// Required: Yes
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SampledRequestsEnabled")]
        public Union<bool, IntrinsicFunction> SampledRequestsEnabled { get; set; }

        /// <summary>
        /// CloudWatchMetricsEnabled
        /// A boolean indicating whether the associated resource sends metrics to CloudWatch. For the list of
        /// available metrics, see AWS WAF Metrics.
        /// Required: Yes
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CloudWatchMetricsEnabled")]
        public Union<bool, IntrinsicFunction> CloudWatchMetricsEnabled { get; set; }

        /// <summary>
        /// MetricName
        /// A friendly name of the CloudWatch metric. The name can contain only alphanumeric characters (A-Z,
        /// a-z, 0-9), with length from one to 128 characters. It can&#39;t contain whitespace or metric names
        /// reserved for AWS WAF, for example &quot;All&quot; and &quot;Default_Action. &quot; You can&#39;t change a MetricName after
        /// you create a VisibilityConfig.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 255
        /// Pattern: ^[\w#:\. \-/]+$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MetricName")]
        public Union<string, IntrinsicFunction> MetricName { get; set; }

    }
}
