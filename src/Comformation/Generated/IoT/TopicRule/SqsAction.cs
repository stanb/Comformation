using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.TopicRule
{
    /// <summary>
    /// AWS::IoT::TopicRule SqsAction
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-sqsaction.html
    /// </summary>
    public class SqsAction
    {

        /// <summary>
        /// RoleArn
        /// The ARN of the IAM role that grants access.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

        /// <summary>
        /// UseBase64
        /// Specifies whether to use Base64 encoding.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UseBase64")]
        public Union<bool, IntrinsicFunction> UseBase64 { get; set; }

        /// <summary>
        /// QueueUrl
        /// The URL of the Amazon SQS queue.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("QueueUrl")]
        public Union<string, IntrinsicFunction> QueueUrl { get; set; }

    }
}
