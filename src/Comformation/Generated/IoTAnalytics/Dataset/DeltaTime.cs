using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Dataset
{
    /// <summary>
    /// AWS::IoTAnalytics::Dataset DeltaTime
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-deltatime.html
    /// </summary>
    public class DeltaTime
    {

        /// <summary>
        /// TimeExpression
        /// An expression by which the time of the message data might be determined. This can be the name of a
        /// timestamp field or a SQL expression that is used to derive the time the message data was generated.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TimeExpression")]
        public Union<string, IntrinsicFunction> TimeExpression { get; set; }

        /// <summary>
        /// OffsetSeconds
        /// The number of seconds of estimated in-flight lag time of message data. When you create dataset
        /// contents using message data from a specified timeframe, some message data might still be in flight
        /// when processing begins, and so do not arrive in time to be processed. Use this field to make
        /// allowances for the in flight time of your message data, so that data not processed from a previous
        /// timeframe is included with the next timeframe. Otherwise, missed message data would be excluded from
        /// processing during the next timeframe too, because its timestamp places it within the previous
        /// timeframe.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OffsetSeconds")]
        public Union<int, IntrinsicFunction> OffsetSeconds { get; set; }

    }
}
