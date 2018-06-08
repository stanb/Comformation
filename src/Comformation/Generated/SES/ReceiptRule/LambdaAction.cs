using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SES.ReceiptRule
{
    /// <summary>
    /// Amazon Simple Email Service ReceiptRule LambdaAction
    /// The LambdaAction property type includes an action in an Amazon SES receipt rule that calls an AWS Lambda
    /// function and, optionally, publishes a notification to Amazon SNS.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-lambdaaction.html
    /// </summary>
    public class LambdaAction
    {

        /// <summary>
        /// FunctionArn
        /// The Amazon Resource Name (ARN) of the AWS Lambda function. An example of an AWS Lambda function ARN
        /// is arn:aws:lambda:us-west-2:account-id:function:MyFunction.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FunctionArn")]
        public Union<string, IntrinsicFunction> FunctionArn { get; set; }

        /// <summary>
        /// TopicArn
        /// The Amazon Resource Name (ARN) of the Amazon SNS topic to notify when the Lambda action is taken. An
        /// example of an Amazon SNS topic ARN is arn:aws:sns:us-west-2:123456789012:MyTopic.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TopicArn")]
        public Union<string, IntrinsicFunction> TopicArn { get; set; }

        /// <summary>
        /// InvocationType
        /// The invocation type of the AWS Lambda function. An invocation type of RequestResponse means that the
        /// execution of the function will immediately result in a response, and a value of Event means that the
        /// function will be invoked asynchronously. The default value is Event. For information about AWS
        /// Lambda invocation types, see Creating Receipt Rules for Amazon SES Email Receiving in the AWS Lambda
        /// Developer Guide.
        /// Valid values include Event and RequestResponse.
        /// Important There is a 30-second timeout on RequestResponse invocations. You should use Event
        /// invocation in most cases. Use RequestResponse only when you want to make a mail flow decision, such
        /// as whether to stop the receipt rule or the receipt rule set.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InvocationType")]
        public Union<string, IntrinsicFunction> InvocationType { get; set; }

    }
}
