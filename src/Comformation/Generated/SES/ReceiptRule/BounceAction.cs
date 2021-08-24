using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SES.ReceiptRule
{
    /// <summary>
    /// AWS::SES::ReceiptRule BounceAction
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-bounceaction.html
    /// </summary>
    public class BounceAction
    {

        /// <summary>
        /// Sender
        /// The email address of the sender of the bounced email. This is the address from which the bounce
        /// message is sent.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Sender")]
        public Union<string, IntrinsicFunction> Sender { get; set; }

        /// <summary>
        /// SmtpReplyCode
        /// The SMTP reply code, as defined by RFC 5321.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SmtpReplyCode")]
        public Union<string, IntrinsicFunction> SmtpReplyCode { get; set; }

        /// <summary>
        /// Message
        /// Human-readable text to include in the bounce message.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Message")]
        public Union<string, IntrinsicFunction> Message { get; set; }

        /// <summary>
        /// TopicArn
        /// The Amazon Resource Name (ARN) of the Amazon SNS topic to notify when the bounce action is taken.
        /// You can find the ARN of a topic by using the ListTopics operation in Amazon SNS.
        /// For more information about Amazon SNS topics, see the Amazon SNS Developer Guide.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TopicArn")]
        public Union<string, IntrinsicFunction> TopicArn { get; set; }

        /// <summary>
        /// StatusCode
        /// The SMTP enhanced status code, as defined by RFC 3463.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StatusCode")]
        public Union<string, IntrinsicFunction> StatusCode { get; set; }

    }
}
