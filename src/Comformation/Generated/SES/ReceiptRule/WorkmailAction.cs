using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SES.ReceiptRule
{
    /// <summary>
    /// Amazon Simple Email Service ReceiptRule WorkmailAction
    /// The WorkmailAction property type includes an action in an Amazon SES receipt rule that calls Amazon WorkMail
    /// and, optionally, publishes a notification to Amazon SNS.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-workmailaction.html
    /// </summary>
    public class WorkmailAction
    {

        /// <summary>
        /// TopicArn
        /// The Amazon Resource Name (ARN) of the Amazon SNS topic to notify when the WorkMail action is called.
        /// An example of an Amazon SNS topic ARN is arn:aws:sns:us-west-2:123456789012:MyTopic.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TopicArn")]
        public Union<string, IntrinsicFunction> TopicArn { get; set; }

        /// <summary>
        /// OrganizationArn
        /// The ARN of the Amazon WorkMail organization. An example of an Amazon WorkMail organization ARN is
        /// arn:aws:workmail:us-west-2:123456789012:organization/m-68755160c4cb4e29a2b2f8fb58f359d7. For
        /// information about Amazon WorkMail organizations, see Working with Organizations in the Amazon
        /// WorkMail Administrator Guide.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OrganizationArn")]
        public Union<string, IntrinsicFunction> OrganizationArn { get; set; }

    }
}
