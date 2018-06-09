using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.TopicRule
{
    /// <summary>
    /// AWS IoT TopicRule KinesisAction
    /// Kinesis is a property of the Actions property that describes an action that writes data to an Kinesis stream.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-kinesisaction.html
    /// </summary>
    public class KinesisAction
    {

        /// <summary>
        /// PartitionKey
        /// The partition key (the grouping of data by shard within an Kinesis stream).
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("PartitionKey")]
        public Union<string, IntrinsicFunction> PartitionKey { get; set; }

        /// <summary>
        /// RoleArn
        /// The ARN of the IAM role that grants access to an Kinesis stream.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

        /// <summary>
        /// StreamName
        /// The name of the Kinesis stream.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("StreamName")]
        public Union<string, IntrinsicFunction> StreamName { get; set; }

    }
}
