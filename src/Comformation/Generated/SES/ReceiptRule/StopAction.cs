using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SES.ReceiptRule
{
    /// <summary>
    /// AWS::SES::ReceiptRule StopAction
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-stopaction.html
    /// </summary>
    public class StopAction
    {

        /// <summary>
        /// Scope
        /// The scope of the StopAction. The only acceptable value is RuleSet.
        /// Required: Yes
        /// Type: String
        /// Allowed values: RuleSet
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Scope")]
        public Union<string, IntrinsicFunction> Scope { get; set; }

        /// <summary>
        /// TopicArn
        /// The Amazon Resource Name (ARN) of the Amazon SNS topic to notify when the stop action is taken. You
        /// can find the ARN of a topic by using the ListTopics operation in the Amazon SNS API.
        /// For more information about Amazon SNS topics, see the Amazon SNS Developer Guide.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TopicArn")]
        public Union<string, IntrinsicFunction> TopicArn { get; set; }

    }
}
