using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudWatch.Alarm
{
    /// <summary>
    /// Amazon CloudWatch Alarm MetricDataQuery
    /// The MetricDataQuery property type specifies the metric data to return, and whether this call is just
    /// retrieving a batch set of data for one metric, or is performing a math expression on metric data.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alarm-metricdataquery.html
    /// </summary>
    public class MetricDataQuery
    {

        /// <summary>
        /// Expression
        /// The math expression to be performed on the returned data, if this structure is performing a math
        /// expression. For more information about metric math expressions, see Metric Math Syntax and Functions
        /// in the Amazon CloudWatch User Guide.
        /// Within one MetricDataQuery structure, you must specify either Expression or MetricStat, but not
        /// both.
        /// Required: No
        /// Type: String
        /// Length constraints: Minimum of 1. Maximum of 1024.
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Expression")]
        public Union<string, IntrinsicFunction> Expression { get; set; }

        /// <summary>
        /// Id
        /// A short name used to tie this structure to the results in the response. This name must be unique
        /// within a single call to GetMetricData. If you are performing math expressions on this set of data,
        /// this name represents that data and can serve as a variable in the mathematical expression. The valid
        /// characters are letters, numbers, and underscore. The first character must be a lowercase letter.
        /// Required: Yes
        /// Type: String
        /// Length constraints: Minimum of 1. Maximum of 255.
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Id")]
        public Union<string, IntrinsicFunction> Id { get; set; }

        /// <summary>
        /// Label
        /// A human-readable label for this metric or expression. This is especially useful if this is an
        /// expression, so that you know what the value represents. If the metric or expression is shown in a
        /// CloudWatch dashboard widget, the label is shown. If Label is omitted, CloudWatch generates a
        /// default.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Label")]
        public Union<string, IntrinsicFunction> Label { get; set; }

        /// <summary>
        /// MetricStat
        /// The metric to be returned, along with statistics, period, and units. Use this parameter only if this
        /// structure is performing a data retrieval and not performing a math expression on the returned data.
        /// Within one MetricDataQuery structure, you must specify either Expression or MetricStat, but not
        /// both.
        /// Required: No
        /// Type: MetricStat
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MetricStat")]
        public MetricStat MetricStat { get; set; }

        /// <summary>
        /// ReturnData
        /// Indicates whether to return the time stamps and raw data values of this metric. If you are
        /// performing this call just to do math expressions and do not also need the raw data returned, you can
        /// specify False. If you omit this, the default of True is used.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ReturnData")]
        public Union<bool, IntrinsicFunction> ReturnData { get; set; }

    }
}
