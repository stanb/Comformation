using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudWatch.Alarm
{
    /// <summary>
    /// AWS::CloudWatch::Alarm Metric
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alarm-metric.html
    /// </summary>
    public class Metric
    {

        /// <summary>
        /// Dimensions
        /// 		
        /// The metric dimensions that you want to be used for the metric that 		 the alarm will watch. .
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
        /// The name of the metric that you want the alarm to watch. This is a required field.
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
        /// The namespace of the metric that the alarm will watch.
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
