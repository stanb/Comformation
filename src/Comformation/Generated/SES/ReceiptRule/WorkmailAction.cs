using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SES.ReceiptRule
{
    /// <summary>
    /// AWS::SES::ReceiptRule WorkmailAction
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-workmailaction.html
    /// </summary>
    public class WorkmailAction
    {

        /// <summary>
        /// TopicArn
        /// The Amazon Resource Name (ARN) of the Amazon SNS topic to notify when the WorkMail action is called.
        /// You can find the ARN of a topic by using the ListTopics operation in the Amazon SNS API.
        /// For more information about Amazon SNS topics, see the Amazon SNS Developer Guide.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TopicArn")]
        public Union<string, IntrinsicFunction> TopicArn { get; set; }

        /// <summary>
        /// OrganizationArn
        /// The Amazon Resource Name (ARN) of the Amazon WorkMail organization. Amazon WorkMail ARNs use the
        /// following format:
        /// arn:aws:workmail:&amp;lt;region&amp;gt;:&amp;lt;awsAccountId&amp;gt;:organization/&amp;lt;workmailOrganizationId&amp;gt;
        /// You can find the ID of your organization by using the ListOrganizations operation in the Amazon
        /// WorkMail API. Amazon WorkMail organization IDs begin with &quot;m-&quot;, followed by a string of alphanumeric
        /// characters.
        /// For information about Amazon WorkMail organizations, see the Amazon WorkMail Administrator Guide.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OrganizationArn")]
        public Union<string, IntrinsicFunction> OrganizationArn { get; set; }

    }
}
