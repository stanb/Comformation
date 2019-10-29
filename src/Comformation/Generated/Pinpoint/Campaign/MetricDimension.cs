using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Pinpoint.Campaign
{
    /// <summary>
    /// AWS::Pinpoint::Campaign MetricDimension
    /// Specifies metric-based criteria for including or excluding endpoints from a segment. These criteria derive
    /// from custom metrics that you define for endpoints.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-metricdimension.html
    /// </summary>
    public class MetricDimension
    {

        /// <summary>
        /// ComparisonOperator
        /// The operator to use when comparing metric values. Valid values are: GREATER_THAN, LESS_THAN,
        /// GREATER_THAN_OR_EQUAL, LESS_THAN_OR_EQUAL, and EQUAL.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ComparisonOperator")]
        public Union<string, IntrinsicFunction> ComparisonOperator { get; set; }

        /// <summary>
        /// Value
        /// The value to compare.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value")]
        public Union<double, IntrinsicFunction> Value { get; set; }

    }
}
