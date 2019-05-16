using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Dataset
{
    /// <summary>
    /// AWS::IoTAnalytics::Dataset DeltaTime
    /// Used to limit data to that which has arrived since the last execution of the action.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-deltatime.html
    /// </summary>
    public class DeltaTime
    {

        /// <summary>
        /// TimeExpression
        /// An expression by which the time of the message data may be determined. This may be the name of a
        /// timestamp field, or a SQL expression which is used to derive the time the message data was
        /// generated.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TimeExpression")]
        public Union<string, IntrinsicFunction> TimeExpression { get; set; }

        /// <summary>
        /// OffsetSeconds
        /// The number of seconds of estimated &quot;in flight&quot; lag time of message data. When you create data set
        /// contents using message data from a specified time frame, some message data may still be &quot;in flight&quot;
        /// when processing begins, and so will not arrive in time to be processed. Use this field to make
        /// allowances for the &quot;in flight&quot; time of your message data, so that data not processed from a previous
        /// time frame will be included with the next time frame. Without this, missed message data would be
        /// excluded from processing during the next time frame as well, because its timestamp places it within
        /// the previous time frame.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OffsetSeconds")]
        public Union<int, IntrinsicFunction> OffsetSeconds { get; set; }

    }
}
