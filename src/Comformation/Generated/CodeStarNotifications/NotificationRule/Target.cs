using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeStarNotifications.NotificationRule
{
    /// <summary>
    /// AWS::CodeStarNotifications::NotificationRule Target
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codestarnotifications-notificationrule-target.html
    /// </summary>
    public class Target
    {

        /// <summary>
        /// TargetType
        /// The target type. Can be an Amazon SNS topic or AWS Chatbot client.
        /// Amazon SNS topics are specified as SNS. AWS Chatbot clients are specified as AWSChatbotSlack.
        /// Required: No
        /// Type: String
        /// Pattern: ^[A-Za-z]+$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TargetType")]
        public Union<string, IntrinsicFunction> TargetType { get; set; }

        /// <summary>
        /// TargetAddress
        /// The Amazon Resource Name (ARN) of the Amazon SNS topic or AWS Chatbot client.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 320
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TargetAddress")]
        public Union<string, IntrinsicFunction> TargetAddress { get; set; }

    }
}
