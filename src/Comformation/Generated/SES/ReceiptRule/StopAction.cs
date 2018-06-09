using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SES.ReceiptRule
{
    /// <summary>
    /// Amazon Simple Email Service ReceiptRule StopAction
    /// The StopAction property type includes an action in an Amazon SES receipt rule that terminates the evaluation
    /// of the receipt rule set and, optionally, publishes a notification to Amazon SNS.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-stopaction.html
    /// </summary>
    public class StopAction
    {

        /// <summary>
        /// Scope
        /// The name of the RuleSet that is being stopped.
        /// Valid values include: RuleSet.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Scope")]
        public Union<string, IntrinsicFunction> Scope { get; set; }

        /// <summary>
        /// TopicArn
        /// The Amazon Resource Name (ARN) of the Amazon SNS topic to notify when the stop action is taken. An
        /// example of an Amazon SNS topic ARN is arn:aws:sns:us-west-2:123456789012:MyTopic.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TopicArn")]
        public Union<string, IntrinsicFunction> TopicArn { get; set; }

    }
}
