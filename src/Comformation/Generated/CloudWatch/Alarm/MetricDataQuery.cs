using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudWatch.Alarm
{
    /// <summary>
    /// AWS::CloudWatch::Alarm MetricDataQuery
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alarm-metricdataquery.html
    /// </summary>
    public class MetricDataQuery
    {

        /// <summary>
        /// AccountId
        /// The ID of the account where the metrics are located, if this is a cross-account alarm.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AccountId")]
        public Union<string, IntrinsicFunction> AccountId { get; set; }

        /// <summary>
        /// Expression
        /// 		
        /// The math expression to be performed on the returned data, if this object is performing a math
        /// expression. This expression 			can use the Id of the other metrics to refer to those metrics, and
        /// can also use the Id of other 			expressions to use the result of those expressions. For more
        /// information about metric math expressions, see 			Metric Math Syntax and Functions in the 			Amazon
        /// CloudWatch User Guide.
        /// 		
        /// Within each MetricDataQuery object, you must specify either 			Expression or MetricStat but not
        /// both.
        /// 	
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1024
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Expression")]
        public Union<string, IntrinsicFunction> Expression { get; set; }

        /// <summary>
        /// Id
        /// 		
        /// A short name used to tie this object to the results in the response. This name must be 			unique
        /// within a single call to GetMetricData. If you are performing math 			expressions on this set of
        /// data, this name represents that data and can serve as a 			variable in the mathematical expression.
        /// The valid characters are letters, numbers, and 			underscore. The first character must be a
        /// lowercase letter.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 255
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Id")]
        public Union<string, IntrinsicFunction> Id { get; set; }

        /// <summary>
        /// Label
        /// 		
        /// A human-readable label for this metric or expression. This is especially useful if this is an
        /// expression, so that you know 			what the value represents. If the metric or expression is shown in a
        /// CloudWatch dashboard widget, the label is shown. If Label is omitted, CloudWatch 			generates a
        /// default.
        /// 	
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Label")]
        public Union<string, IntrinsicFunction> Label { get; set; }

        /// <summary>
        /// MetricStat
        /// 		
        /// The metric to be returned, along with statistics, period, and units. Use this parameter only if this
        /// object is retrieving a metric 			and not performing a math expression on returned data.
        /// 		
        /// Within one MetricDataQuery object, you must specify either 			Expression or MetricStat but not both.
        /// 	
        /// Required: No
        /// Type: MetricStat
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MetricStat")]
        public MetricStat MetricStat { get; set; }

        /// <summary>
        /// Period
        /// 		
        /// The granularity, in seconds, of the returned data points. For metrics with regular resolution, a
        /// 			period can be as short as one minute (60 seconds) and must be a multiple of 60. 			For
        /// high-resolution metrics that are collected at intervals of less than one minute, 			the period can
        /// be 1, 5, 10, 30, 60, or any multiple of 60. High-resolution metrics are those metrics 			stored by a
        /// PutMetricData operation that includes a StorageResolution of 1 second.
        /// 		 	
        /// Required: No
        /// Type: Integer
        /// Minimum: 1
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Period")]
        public Union<int, IntrinsicFunction> Period { get; set; }

        /// <summary>
        /// ReturnData
        /// 		
        /// This option indicates whether to return the 			timestamps and raw data values of this metric.
        /// When you create an alarm based on a metric math expression, specify True for this value for only the
        /// one math expression that the alarm is based on. You must specify False for ReturnData for all the
        /// other metrics and expressions used in the alarm.
        /// This field is required.
        /// 		 		 	
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ReturnData")]
        public Union<bool, IntrinsicFunction> ReturnData { get; set; }

    }
}
