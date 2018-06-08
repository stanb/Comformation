using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SES.ReceiptRule
{
    /// <summary>
    /// Amazon Simple Email Service ReceiptRule SNSAction
    /// The SNSAction property type includes an action in an Amazon SES receipt rule that publishes a notification to
    /// Amazon SNS.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-snsaction.html
    /// </summary>
    public class SNSAction
    {

        /// <summary>
        /// TopicArn
        /// The Amazon Resource Name (ARN) of the Amazon SNS topic to notify. An example of an Amazon SNS topic
        /// ARN is arn:aws:sns:us-west-2:123456789012:MyTopic.
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
        /// Valid values include Base64 and UTF-8.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Encoding")]
        public Union<string, IntrinsicFunction> Encoding { get; set; }

    }
}
