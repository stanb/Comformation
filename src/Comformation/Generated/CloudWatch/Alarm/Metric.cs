using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudWatch.Alarm
{
    /// <summary>
    /// AWS::CloudWatch::Alarm Metric
    /// The Metric property type represents a specific metric. Metric is a property of the 		 MetricStat property
    /// type.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alarm-metric.html
    /// </summary>
    public class Metric
    {

        /// <summary>
        /// Dimensions
        /// 		
        /// The dimensions for the metric.
        /// 	
        /// Required: No
        /// Type: List of Dimension
        /// Maximum: 10
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Dimensions")]
        public List<Dimension> Dimensions { get; set; }

        /// <summary>
        /// MetricName
        /// 		
        /// The name of the metric. This is a required field.
        /// 	
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 255
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MetricName")]
        public Union<string, IntrinsicFunction> MetricName { get; set; }

        /// <summary>
        /// Namespace
        /// 		
        /// The namespace of the metric.
        /// 	
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 255
        /// Pattern: [^:]. *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Namespace")]
        public Union<string, IntrinsicFunction> Namespace { get; set; }

    }
}
