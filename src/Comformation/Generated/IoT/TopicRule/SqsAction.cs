using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.TopicRule
{
    /// <summary>
    /// AWS IoT TopicRule SqsAction
    /// Sqs is a property of the Actions property that describes an action that publishes data to an SQS queue.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-sqsaction.html
    /// </summary>
    public class SqsAction
    {

        /// <summary>
        /// QueueUrl
        /// The URL of the Amazon Simple Queue Service (Amazon SQS) queue.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("QueueUrl")]
        public Union<string, IntrinsicFunction> QueueUrl { get; set; }

        /// <summary>
        /// RoleArn
        /// The ARN of the IAM role that grants access to Amazon SQS.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

        /// <summary>
        /// UseBase64
        /// Specifies whether Base64 encoding should be used.
        /// Required: No
        /// Type: Boolean
        /// </summary>
        [JsonProperty("UseBase64")]
        public Union<bool, IntrinsicFunction> UseBase64 { get; set; }

    }
}
