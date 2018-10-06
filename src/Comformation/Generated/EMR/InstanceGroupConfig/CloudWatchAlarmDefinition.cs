using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.InstanceGroupConfig
{
    /// <summary>
    /// Amazon EMR InstanceGroupConfig CloudWatchAlarmDefinition
    /// The CloudWatchAlarmDefinition property specifies the conditions that trigger an automatic scaling activity.
    /// CloudWatchAlarmDefinition is a subproperty of the Amazon EMR InstanceGroupConfig ScalingTrigger property type.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancegroupconfig-cloudwatchalarmdefinition.html
    /// </summary>
    public class CloudWatchAlarmDefinition
    {

        /// <summary>
        /// ComparisonOperator
        /// Determines how the metric specified by MetricName is compared to the value specified by Threshold.
        /// Valid values: GREATER_THAN_OR_EQUAL, GREATER_THAN, LESS_THAN, or LESS_THAN_OR_EQUAL.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("ComparisonOperator")]
        public Union<string, IntrinsicFunction> ComparisonOperator { get; set; }

        /// <summary>
        /// Dimensions
        /// A list of CloudWatch metric dimensions.
        /// Required: No
        /// Type: List of Amazon EMR InstanceGroupConfig MetricDimension
        /// </summary>
        [JsonProperty("Dimensions")]
        public List<MetricDimension> Dimensions { get; set; }

        /// <summary>
        /// EvaluationPeriods
        /// The number of periods, expressed in seconds using the Period property, during which the alarm
        /// condition must exist before the alarm triggers automatic scaling activity. The default value is 1.
        /// Required: No
        /// Type: Integer
        /// </summary>
        [JsonProperty("EvaluationPeriods")]
        public Union<int, IntrinsicFunction> EvaluationPeriods { get; set; }

        /// <summary>
        /// MetricName
        /// The name of the CloudWatch metric that is watched to determine an alarm condition.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("MetricName")]
        public Union<string, IntrinsicFunction> MetricName { get; set; }

        /// <summary>
        /// Namespace
        /// The namespace for the CloudWatch metric. The default is AWS/ElasticMapReduce.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Namespace")]
        public Union<string, IntrinsicFunction> Namespace { get; set; }

        /// <summary>
        /// Period
        /// The period, in seconds, over which the statistic for applying the metric associated with the alarm
        /// is applied. You specify the statistic in the Statistic property. CloudWatch metrics for Amazon EMR
        /// are emitted every five minutes (300 seconds). If you specify a CloudWatch metric for Amazon EMR,
        /// specify 300.
        /// Required: Yes
        /// Type: Integer
        /// </summary>
        [JsonProperty("Period")]
        public Union<int, IntrinsicFunction> Period { get; set; }

        /// <summary>
        /// Statistic
        /// The statistic to apply to the metric associated with the alarm. The default is AVERAGE.
        /// Valid values: SAMPLE_COUNT, AVERAGE, SUM, MINIMUM, and MAXIMUM.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Statistic")]
        public Union<string, IntrinsicFunction> Statistic { get; set; }

        /// <summary>
        /// Threshold
        /// The value against which the specified statistic is compared.
        /// Required: Yes
        /// Type: Double
        /// </summary>
        [JsonProperty("Threshold")]
        public Union<double, IntrinsicFunction> Threshold { get; set; }

        /// <summary>
        /// Unit
        /// The unit of measure associated with the CloudWatch metric being watched. Specify the unit specified
        /// in the CloudWatch metric.
        /// For more information, see CloudWatchAlarmDefinition in the Amazon EMR API Reference.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Unit")]
        public Union<string, IntrinsicFunction> Unit { get; set; }

    }
}
