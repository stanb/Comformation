using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudWatch.MetricStream
{
    /// <summary>
    /// AWS::CloudWatch::MetricStream MetricStreamFilter
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-metricstream-metricstreamfilter.html
    /// </summary>
    public class MetricStreamFilter
    {

        /// <summary>
        /// Namespace
        /// The name of the metric namespace in the filter.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Namespace")]
        public Union<string, IntrinsicFunction> Namespace { get; set; }

    }
}
