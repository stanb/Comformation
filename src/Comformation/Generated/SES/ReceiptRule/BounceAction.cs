using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SES.ReceiptRule
{
    /// <summary>
    /// Amazon Simple Email Service ReceiptRule BounceAction
    /// The BounceAction property type includes an action in an Amazon SES receipt rule that rejects the received
    /// email by returning a bounce response to the sender and, optionally, publishes a notification to Amazon SNS.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-bounceaction.html
    /// </summary>
    public class BounceAction
    {

        /// <summary>
        /// Sender
        /// The email address of the sender of the bounced email. This is the address from which the bounce
        /// message will be sent.
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
        /// The Amazon Resource Name (ARN) of the Amazon SNS topic to notify when the bounce action is taken. An
        /// example of an Amazon SNS topic ARN is arn:aws:sns:us-west-2:123456789012:MyTopic. For more
        /// information about Amazon SNS topics, see Create a Topic in the Amazon Simple Notification Service
        /// Developer Guide.
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
