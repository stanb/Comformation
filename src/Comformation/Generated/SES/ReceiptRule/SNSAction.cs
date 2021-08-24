using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SES.ReceiptRule
{
    /// <summary>
    /// AWS::SES::ReceiptRule SNSAction
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-snsaction.html
    /// </summary>
    public class SNSAction
    {

        /// <summary>
        /// TopicArn
        /// The Amazon Resource Name (ARN) of the Amazon SNS topic to notify. You can find the ARN of a topic by
        /// using the ListTopics operation in Amazon SNS.
        /// For more information about Amazon SNS topics, see the Amazon SNS Developer Guide.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TopicArn")]
        public Union<string, IntrinsicFunction> TopicArn { get; set; }

        /// <summary>
        /// Encoding
        /// The encoding to use for the email within the Amazon SNS notification. UTF-8 is easier to use, but
        /// may not preserve all special characters when a message was encoded with a different encoding format.
        /// Base64 preserves all special characters. The default value is UTF-8.
        /// Required: No
        /// Type: String
        /// Allowed values: Base64 | UTF-8
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Encoding")]
        public Union<string, IntrinsicFunction> Encoding { get; set; }

    }
}
