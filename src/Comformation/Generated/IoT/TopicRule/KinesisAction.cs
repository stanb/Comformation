using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.TopicRule
{
    /// <summary>
    /// AWS::IoT::TopicRule KinesisAction
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-kinesisaction.html
    /// </summary>
    public class KinesisAction
    {

        /// <summary>
        /// PartitionKey
        /// The partition key.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PartitionKey")]
        public Union<string, IntrinsicFunction> PartitionKey { get; set; }

        /// <summary>
        /// StreamName
        /// The name of the Amazon Kinesis stream.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StreamName")]
        public Union<string, IntrinsicFunction> StreamName { get; set; }

        /// <summary>
        /// RoleArn
        /// The ARN of the IAM role that grants access to the Amazon Kinesis stream.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

    }
}
