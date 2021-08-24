using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.TopicRule
{
    /// <summary>
    /// AWS::IoT::TopicRule TimestreamAction
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-timestreamaction.html
    /// </summary>
    public class TimestreamAction
    {

        /// <summary>
        /// RoleArn
        /// The Amazon Resource Name (ARN) of the role that grants AWS IoT permission to write to the Timestream
        /// database table.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

        /// <summary>
        /// DatabaseName
        /// The name of an Amazon Timestream database that has the table to write records into.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DatabaseName")]
        public Union<string, IntrinsicFunction> DatabaseName { get; set; }

        /// <summary>
        /// TableName
        /// The table where the message data will be written.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TableName")]
        public Union<string, IntrinsicFunction> TableName { get; set; }

        /// <summary>
        /// Dimensions
        /// Metadata attributes of the time series that are written in each measure record.
        /// Required: Yes
        /// Type: List of TimestreamDimension
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Dimensions")]
        public List<TimestreamDimension> Dimensions { get; set; }

        /// <summary>
        /// Timestamp
        /// The value to use for the entry&#39;s timestamp. If blank, the time that the entry was processed is used.
        /// Required: No
        /// Type: TimestreamTimestamp
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Timestamp")]
        public TimestreamTimestamp Timestamp { get; set; }

        /// <summary>
        /// BatchMode
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BatchMode")]
        public Union<bool, IntrinsicFunction> BatchMode { get; set; }

    }
}
