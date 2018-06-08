using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudWatch.Alarm
{
    /// <summary>
    /// AWS::CloudWatch::Alarm
    /// The AWS::CloudWatch::Alarm type creates a CloudWatch alarm.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cw-alarm.html
    /// </summary>
    public class AlarmResource : ResourceBase
    {
        public class AlarmProperties
        {
            /// <summary>
            /// ActionsEnabled
            /// Indicates whether actions should be executed during changes to the CloudWatch alarm's state.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> ActionsEnabled { get; set; }

            /// <summary>
            /// AlarmActions
            /// The list of actions to execute when this alarm transitions into an ALARM state from any other state.
            /// Specify each action as an Amazon Resource Name (ARN). For more information about creating alarms and
            /// the actions that you can specify, see PutMetricAlarm in the Amazon CloudWatch API Reference and
            /// Creating Amazon CloudWatch Alarms in the Amazon CloudWatch User Guide.
            /// Note For Auto Scaling scaling polices, you can specify only one policy. If you associate more than
            /// one policy, Amazon CloudWatch executes only the first scaling policy.
            /// Required: No
            /// Type: List of String values
            /// Update requires: No interruption
            /// </summary>
			public Union<List<string>, IntrinsicFunction> AlarmActions { get; set; }

            /// <summary>
            /// AlarmDescription
            /// The description of the alarm.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> AlarmDescription { get; set; }

            /// <summary>
            /// AlarmName
            /// A name for the alarm. If you don't specify a name, AWS CloudFormation generates a unique physical ID
            /// and uses that ID for the alarm name. For more information, see Name Type.
            /// Important If you specify a name, you cannot perform updates that require replacement of this
            /// resource. You can perform updates that require no or some interruption. If you must replace the
            /// resource, specify a new name.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> AlarmName { get; set; }

            /// <summary>
            /// ComparisonOperator
            /// The arithmetic operation to use when comparing the specified Statistic and Threshold. AWS
            /// CloudFormation uses the value of Statistic as the first operand.
            /// You can specify the following values: GreaterThanOrEqualToThreshold , GreaterThanThreshold,
            /// LessThanThreshold, or LessThanOrEqualToThreshold.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ComparisonOperator { get; set; }

            /// <summary>
            /// Dimensions
            /// The dimensions of the metric for the alarm.
            /// Required: No
            /// Type: List of Metric Dimension
            /// Update requires: No interruption
            /// </summary>
			public Union<List<Dimension>, IntrinsicFunction> Dimensions { get; set; }

            /// <summary>
            /// EvaluateLowSampleCountPercentile
            /// Used only for alarms that are based on percentiles. Specifies whether to evaluate the data and
            /// potentially change the alarm state if there are too few data points to be statistically significant.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> EvaluateLowSampleCountPercentile { get; set; }

            /// <summary>
            /// EvaluationPeriods
            /// The number of periods over which data is compared to the specified threshold.
            /// Required: Yes
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> EvaluationPeriods { get; set; }

            /// <summary>
            /// ExtendedStatistic
            /// The percentile statistic for the metric. Specify a value between p0. 0 and p100.
            /// Required: Conditional. You must specify either the ExtendedStatistic or the Statistic property.
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ExtendedStatistic { get; set; }

            /// <summary>
            /// InsufficientDataActions
            /// The list of actions to execute when this alarm transitions into an INSUFFICIENT_DATA state. Specify
            /// each action as an Amazon Resource Number (ARN). Currently, the only action supported is publishing
            /// to an Amazon SNS topic or an Auto Scaling policy.
            /// Required: No
            /// Type: List of String values
            /// Update requires: No interruption
            /// </summary>
			public Union<List<string>, IntrinsicFunction> InsufficientDataActions { get; set; }

            /// <summary>
            /// MetricName
            /// The name of the metric associated with the alarm. For more information about the metrics that you
            /// can specify, see Amazon CloudWatch Namespaces, Dimensions, and Metrics Reference in the Amazon
            /// CloudWatch User Guide.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> MetricName { get; set; }

            /// <summary>
            /// Namespace
            /// The namespace of the metric that is associated with the alarm.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Namespace { get; set; }

            /// <summary>
            /// OKActions
            /// The list of actions to execute when this alarm transitions into an OK state. Specify each action as
            /// an Amazon Resource Number (ARN). Currently, the only action supported is publishing to an SNS topic
            /// or an Auto Scaling policy.
            /// Required: No
            /// Type: List of String values
            /// Update requires: No interruption
            /// </summary>
			public Union<List<string>, IntrinsicFunction> OKActions { get; set; }

            /// <summary>
            /// Period
            /// The time over which the specified statistic is applied. Specify time in seconds, in multiples of 60.
            /// Required: Yes
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> Period { get; set; }

            /// <summary>
            /// Statistic
            /// The statistic to apply to the alarm's associated metric.
            /// You can specify the following values: SampleCount, Average, Sum, Minimum, or Maximum.
            /// Required: Conditional. You must specify either the ExtendedStatistic or the Statistic property.
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Statistic { get; set; }

            /// <summary>
            /// Threshold
            /// The value against which the specified statistic is compared.
            /// Required: Yes
            /// Type: Double
            /// Update requires: No interruption
            /// </summary>
			public Union<double, IntrinsicFunction> Threshold { get; set; }

            /// <summary>
            /// TreatMissingData
            /// Sets how this alarm is to handle missing data points. If TreatMissingData is omitted, the default
            /// behavior of missing is used. For more information, see PutMetricAlarm in the Amazon CloudWatch API
            /// Reference and Configuring How CloudWatch Alarms Treats Missing Data in the Amazon CloudWatch User
            /// Guide.
            /// Valid values: breaching, notBreaching, ignore, missing
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> TreatMissingData { get; set; }

            /// <summary>
            /// Unit
            /// The unit for the metric that is associated with the alarm.
            /// You can specify the following values: Seconds, Microseconds, Milliseconds, Bytes, Kilobytes,
            /// Megabytes, Gigabytes , Terabytes, Bits, Kilobits, Megabits, Gigabits, Terabits,| Percent ,
            /// Count,Bytes/Second , Kilobytes/Second, Megabytes/Second, Gigabytes/Second, Terabytes/Second ,
            /// Bits/Second, Kilobits/Second , Megabits/Second , Gigabits/Second , Terabits/Second, Count/Second ,
            /// or None.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Unit { get; set; }

        }
    
        public string Type { get; } = "AWS::CloudWatch::Alarm";
        
        public AlarmProperties Properties { get; } = new AlarmProperties();
    }

	public static class AlarmAttributes
	{
        public static readonly ResourceAttribute<string> Arn = new ResourceAttribute<string>("Arn");
	}
}
