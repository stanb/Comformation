using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.Cluster
{
    /// <summary>
    /// AWS::EMR::Cluster CloudWatchAlarmDefinition
    /// CloudWatchAlarmDefinition is a subproperty of the ScalingTrigger property, which determines when to trigger an
    /// automatic scaling activity. Scaling activity begins when you satisfy the defined alarm conditions.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-cloudwatchalarmdefinition.html
    /// </summary>
    public class CloudWatchAlarmDefinition
    {

        /// <summary>
        /// ComparisonOperator
        /// Determines how the metric specified by MetricName is compared to the value specified by Threshold.
        /// Required: Yes
        /// Type: String
        /// Allowed Values: GREATER_THAN | GREATER_THAN_OR_EQUAL | LESS_THAN | LESS_THAN_OR_EQUAL
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ComparisonOperator")]
        public Union<string, IntrinsicFunction> ComparisonOperator { get; set; }

        /// <summary>
        /// Dimensions
        /// A CloudWatch metric dimension.
        /// Required: No
        /// Type: List of MetricDimension
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Dimensions")]
        public List<MetricDimension> Dimensions { get; set; }

        /// <summary>
        /// EvaluationPeriods
        /// The number of periods, expressed in seconds using Period, during which the alarm condition must
        /// exist before the alarm triggers automatic scaling activity. The default value is 1.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EvaluationPeriods")]
        public Union<int, IntrinsicFunction> EvaluationPeriods { get; set; }

        /// <summary>
        /// MetricName
        /// The name of the CloudWatch metric that is watched to determine an alarm condition.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MetricName")]
        public Union<string, IntrinsicFunction> MetricName { get; set; }

        /// <summary>
        /// Namespace
        /// The namespace for the CloudWatch metric. The default is AWS/ElasticMapReduce.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Namespace")]
        public Union<string, IntrinsicFunction> Namespace { get; set; }

        /// <summary>
        /// Period
        /// The period, in seconds, over which the statistic is applied. EMR CloudWatch metrics are emitted
        /// every five minutes (300 seconds), so if an EMR CloudWatch metric is specified, specify 300.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Period")]
        public Union<int, IntrinsicFunction> Period { get; set; }

        /// <summary>
        /// Statistic
        /// The statistic to apply to the metric associated with the alarm. The default is AVERAGE.
        /// Required: No
        /// Type: String
        /// Allowed Values: AVERAGE | MAXIMUM | MINIMUM | SAMPLE_COUNT | SUM
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Statistic")]
        public Union<string, IntrinsicFunction> Statistic { get; set; }

        /// <summary>
        /// Threshold
        /// The value against which the specified statistic is compared.
        /// Required: Yes
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Threshold")]
        public Union<double, IntrinsicFunction> Threshold { get; set; }

        /// <summary>
        /// Unit
        /// The unit of measure associated with the CloudWatch metric being watched. The value specified for
        /// Unit must correspond to the units specified in the CloudWatch metric.
        /// Required: No
        /// Type: String
        /// Allowed Values: BITS | BITS_PER_SECOND | BYTES | BYTES_PER_SECOND | COUNT | COUNT_PER_SECOND |
        /// GIGA_BITS | GIGA_BITS_PER_SECOND | GIGA_BYTES | GIGA_BYTES_PER_SECOND | KILO_BITS |
        /// KILO_BITS_PER_SECOND | KILO_BYTES | KILO_BYTES_PER_SECOND | MEGA_BITS | MEGA_BITS_PER_SECOND |
        /// MEGA_BYTES | MEGA_BYTES_PER_SECOND | MICRO_SECONDS | MILLI_SECONDS | NONE | PERCENT | SECONDS |
        /// TERA_BITS | TERA_BITS_PER_SECOND | TERA_BYTES | TERA_BYTES_PER_SECOND
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Unit")]
        public Union<string, IntrinsicFunction> Unit { get; set; }

    }
}
