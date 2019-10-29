using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudWatch.Alarm
{
    /// <summary>
    /// AWS::CloudWatch::Alarm
    /// The AWS::CloudWatch::Alarm type specifies an alarm and associates it with the specified metric or metric math
    /// expression.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cw-alarm.html
    /// </summary>
    public class AlarmResource : ResourceBase
    {
        public class AlarmProperties
        {
            /// <summary>
            /// ActionsEnabled
            /// 		
            /// Indicates whether actions should be executed during any changes to the alarm state. The default is
            /// TRUE.
            /// 	
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> ActionsEnabled { get; set; }

            /// <summary>
            /// AlarmActions
            /// 		
            /// The list of actions to execute when this alarm transitions into an ALARM state from any other state.
            /// 			Specify each action as an Amazon Resource Name (ARN). For more information about creating alarms
            /// and the actions 			that you can specify, see PutMetricAlarm in the 		 Amazon CloudWatch API
            /// Reference.
            /// 	
            /// Required: No
            /// Type: List of String
            /// Maximum: 5
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> AlarmActions { get; set; }

            /// <summary>
            /// AlarmDescription
            /// 		
            /// The description of the alarm.
            /// 	
            /// Required: No
            /// Type: String
            /// Minimum: 0
            /// Maximum: 1024
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> AlarmDescription { get; set; }

            /// <summary>
            /// AlarmName
            /// The name of the alarm. If you don&#39;t specify a name, AWS CloudFormation generates a unique physical
            /// ID and uses that ID for the alarm name.
            /// Important If you specify a name, you cannot perform updates that require replacement of this
            /// resource. You can perform updates that require no or some interruption. If you must replace the
            /// resource, specify a new name.
            /// 	
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 255
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> AlarmName { get; set; }

            /// <summary>
            /// ComparisonOperator
            /// 		
            /// The arithmetic operation to use when comparing the specified 			statistic and threshold. The
            /// specified statistic value is used as the first operand.
            /// You can specify the following values: GreaterThanThreshold, GreaterThanOrEqualToThreshold,
            /// LessThanThreshold, or LessThanOrEqualToThreshold.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Allowed Values: GreaterThanOrEqualToThreshold | GreaterThanThreshold | GreaterThanUpperThreshold |
            /// LessThanLowerOrGreaterThanUpperThreshold | LessThanLowerThreshold | LessThanOrEqualToThreshold |
            /// LessThanThreshold
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ComparisonOperator { get; set; }

            /// <summary>
            /// DatapointsToAlarm
            /// 		
            /// The number of datapoints that must be breaching to trigger the alarm. 		 This is used only if you
            /// are setting an &quot;M out of N&quot; alarm. In that case, this value is the M. 		 For more information, see
            /// Evaluating 		 an Alarm in the Amazon CloudWatch User Guide.
            /// 	
            /// Required: No
            /// Type: Integer
            /// Minimum: 1
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> DatapointsToAlarm { get; set; }

            /// <summary>
            /// Dimensions
            /// The dimensions for the metric associated with the alarm. For an alarm based on a math expression,
            /// you can&#39;t specify Dimensions. Instead, you use Metrics.
            /// 	
            /// Required: No
            /// Type: List of Dimension
            /// Maximum: 10
            /// Update requires: No interruption
            /// </summary>
			public List<Dimension> Dimensions { get; set; }

            /// <summary>
            /// EvaluateLowSampleCountPercentile
            /// 		
            /// Used only for alarms based on percentiles. If ignore, the alarm state does not change 			during
            /// periods with too few data points to be statistically significant. If evaluate or this 			parameter
            /// is not used, the alarm is always evaluated and possibly changes state no matter 			how many data
            /// points are available.
            /// 	
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 255
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> EvaluateLowSampleCountPercentile { get; set; }

            /// <summary>
            /// EvaluationPeriods
            /// 		
            /// The number of periods over which data is compared to the specified threshold.
            /// 	
            /// Required: Yes
            /// Type: Integer
            /// Minimum: 1
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> EvaluationPeriods { get; set; }

            /// <summary>
            /// ExtendedStatistic
            /// 		
            /// The percentile statistic for the metric associated with the alarm. Specify a value between 			p0. 0
            /// and p100.
            /// For an alarm based on a math expression, you can&#39;t specify ExtendedStatistic. Instead, you use
            /// Metrics.
            /// 	
            /// Required: No
            /// Type: String
            /// Pattern: p(\d{1,2}(\. \d{0,2})?|100)
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ExtendedStatistic { get; set; }

            /// <summary>
            /// InsufficientDataActions
            /// 		
            /// The actions to execute when this alarm transitions to the INSUFFICIENT_DATA state 			from any other
            /// state. Each action is specified as an Amazon Resource Name (ARN).
            /// 	
            /// Required: No
            /// Type: List of String
            /// Maximum: 5
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> InsufficientDataActions { get; set; }

            /// <summary>
            /// MetricName
            /// 		
            /// The name of the metric associated with the alarm. This is required for an alarm based on a 		
            /// metric. For an alarm based on a math expression, you use Metrics instead and you can&#39;t 		 specify
            /// MetricName.
            /// 	
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 255
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> MetricName { get; set; }

            /// <summary>
            /// Metrics
            /// An array that enables you to create an alarm based on the result of a metric math expression. Each
            /// item in the array either retrieves a metric or performs a math expression.
            /// If you specify the Metrics parameter, you cannot specify MetricName, Dimensions, Period, Namespace,
            /// Statistic, or ExtendedStatistic.
            /// 	
            /// Required: No
            /// Type: List of MetricDataQuery
            /// Update requires: No interruption
            /// </summary>
			public List<MetricDataQuery> Metrics { get; set; }

            /// <summary>
            /// Namespace
            /// The namespace of the metric associated with the alarm. This is required for an alarm based on a
            /// metric. For an alarm based on a math expression, you can&#39;t specify Namespace and you use Metrics
            /// instead.
            /// 	
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 255
            /// Pattern: [^:]. *
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Namespace { get; set; }

            /// <summary>
            /// OKActions
            /// 		
            /// The actions to execute when this alarm transitions to the OK state 			from any other state. Each
            /// action is specified as an Amazon Resource Name (ARN).
            /// 	
            /// Required: No
            /// Type: List of String
            /// Maximum: 5
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> OKActions { get; set; }

            /// <summary>
            /// Period
            /// The period, in seconds, over which the statistic is applied. This is required for an alarm based on
            /// a metric. For an alarm based on a math expression, you can&#39;t specify Period, and instead you use the
            /// Metrics parameter.
            /// 	
            /// Required: No
            /// Type: Integer
            /// Minimum: 1
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> Period { get; set; }

            /// <summary>
            /// Statistic
            /// 		
            /// The statistic for the metric associated with the alarm, other than percentile. 		 For percentile
            /// statistics, use ExtendedStatistic.
            /// For an alarm based on a math expression, you can&#39;t specify Statistic. Instead, you use Metrics.
            /// 	
            /// Required: No
            /// Type: String
            /// Allowed Values: Average | Maximum | Minimum | SampleCount | Sum
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Statistic { get; set; }

            /// <summary>
            /// Threshold
            /// 		
            /// The value to compare with the specified statistic.
            /// 	
            /// Required: No
            /// Type: Double
            /// Update requires: No interruption
            /// </summary>
			public Union<double, IntrinsicFunction> Threshold { get; set; }

            /// <summary>
            /// ThresholdMetricId
            /// In an alarm based on an anomaly detection model, this is the ID of the ANOMALY_DETECTION_BAND
            /// function used as the threshold for the alarm.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 255
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ThresholdMetricId { get; set; }

            /// <summary>
            /// TreatMissingData
            /// Sets how this alarm is to handle missing data points. Valid values are breaching, notBreaching,
            /// ignore, and missing. For more information, see Configuring How CloudWatch Alarms Treat Missing Data
            /// in the Amazon CloudWatch User Guide.
            /// If you omit this parameter, the default behavior of missing is used.
            /// 	
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 255
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> TreatMissingData { get; set; }

            /// <summary>
            /// Unit
            /// 		
            /// The unit of the metric associated with the alarm. 		 You can specify the following values: Seconds,
            /// Microseconds, Milliseconds, Bytes, Kilobytes, 		 Megabytes, Gigabytes, Terabytes, Bits, Kilobits,
            /// Megabits, Gigabits, Terabits, Percent, Count, 		 Bytes/Second, Kilobytes/Second, Megabytes/Second,
            /// Gigabytes/Second, Terabytes/Second, Bits/Second, 		 Kilobits/Second, Megabits/Second,
            /// Gigabits/Second, Terabits/Second, Count/Second, or None.
            /// 	
            /// Required: No
            /// Type: String
            /// Allowed Values: Bits | Bits/Second | Bytes | Bytes/Second | Count | Count/Second | Gigabits |
            /// Gigabits/Second | Gigabytes | Gigabytes/Second | Kilobits | Kilobits/Second | Kilobytes |
            /// Kilobytes/Second | Megabits | Megabits/Second | Megabytes | Megabytes/Second | Microseconds |
            /// Milliseconds | None | Percent | Seconds | Terabits | Terabits/Second | Terabytes | Terabytes/Second
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Unit { get; set; }

        }

        public string Type { get; } = "AWS::CloudWatch::Alarm";

        public AlarmProperties Properties { get; } = new AlarmProperties();

    }

	public static class AlarmAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
	}
}
