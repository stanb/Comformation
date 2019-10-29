using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudWatch.AnomalyDetector
{
    /// <summary>
    /// AWS::CloudWatch::AnomalyDetector Range
    /// Each Range specifies one range of days or times to exclude from use for training or updating an anomaly
    /// detection model.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-anomalydetector-range.html
    /// </summary>
    public class Range
    {

        /// <summary>
        /// EndTime
        /// The end time of the range to exclude. The format is yyyy-MM-dd&#39;T&#39;HH:mm:ss. For example,
        /// 2019-07-01T23:59:59.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EndTime")]
        public Union<string, IntrinsicFunction> EndTime { get; set; }

        /// <summary>
        /// StartTime
        /// The start time of the range to exclude. The format is yyyy-MM-dd&#39;T&#39;HH:mm:ss. For example,
        /// 2019-07-01T23:59:59.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StartTime")]
        public Union<string, IntrinsicFunction> StartTime { get; set; }

    }
}
