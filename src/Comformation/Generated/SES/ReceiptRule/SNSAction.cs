using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SES.ReceiptRule
{
    /// <summary>
    /// AWS::SES::ReceiptRule SNSAction
    /// When included in a receipt rule, this action publishes a notification to Amazon Simple Notification Service
    /// (Amazon SNS). This action includes a complete copy of the email content in the Amazon SNS notifications.
    /// Amazon SNS notifications for all other actions simply provide information about the email. They don&#39;t include
    /// the email content itself.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-snsaction.html
    /// </summary>
    public class SNSAction
    {

        /// <summary>
        /// TopicArn
        /// The Amazon Resource Name (ARN) of the Amazon SNS topic to notify. An example of an Amazon SNS topic
        /// ARN is arn:aws:sns:us-west-2:123456789012:MyTopic. For more information about Amazon SNS topics, see
        /// the Amazon SNS Developer Guide.
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
        /// Allowed Values: Base64 | UTF-8
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Encoding")]
        public Union<string, IntrinsicFunction> Encoding { get; set; }

    }
}
