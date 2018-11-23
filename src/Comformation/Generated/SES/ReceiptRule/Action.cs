using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SES.ReceiptRule
{
    /// <summary>
    /// Amazon Simple Email Service ReceiptRule Action
    /// The Action property type specifies an action for Amazon SES to take when it receives an email on behalf of one
    /// or more email addresses or domains that you own.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-action.html
    /// </summary>
    public class Action
    {

        /// <summary>
        /// BounceAction
        /// Rejects the received email by returning a bounce response to the sender and, optionally, publishes a
        /// notification to Amazon SNS.
        /// Required: No
        /// Type: BounceAction
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BounceAction")]
        public BounceAction BounceAction { get; set; }

        /// <summary>
        /// S3Action
        /// Saves the received message to an Amazon S3 bucket and, optionally, publishes a notification to
        /// Amazon SNS.
        /// Required: No
        /// Type: S3Action
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3Action")]
        public S3Action S3Action { get; set; }

        /// <summary>
        /// StopAction
        /// Terminates the evaluation of the receipt rule set and optionally publishes a notification to Amazon
        /// SNS.
        /// Required: No
        /// Type: StopAction
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StopAction")]
        public StopAction StopAction { get; set; }

        /// <summary>
        /// SNSAction
        /// Publishes the email content within a notification to Amazon SNS.
        /// Required: No
        /// Type: SNSAction
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SNSAction")]
        public SNSAction SNSAction { get; set; }

        /// <summary>
        /// WorkmailAction
        /// Calls Amazon WorkMail and, optionally, publishes a notification to Amazon SNS.
        /// Required: No
        /// Type: WorkmailAction
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("WorkmailAction")]
        public WorkmailAction WorkmailAction { get; set; }

        /// <summary>
        /// AddHeaderAction
        /// Adds a header to the received email.
        /// Required: No
        /// Type: AddHeaderAction
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AddHeaderAction")]
        public AddHeaderAction AddHeaderAction { get; set; }

        /// <summary>
        /// LambdaAction
        /// Calls an AWS Lambda function, and optionally, publishes a notification to Amazon SNS.
        /// Required: No
        /// Type: LambdaAction
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LambdaAction")]
        public LambdaAction LambdaAction { get; set; }

    }
}
