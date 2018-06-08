using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Lambda.Function
{
    /// <summary>
    /// AWS Lambda Function DeadLetterConfig
    /// DeadLetterConfig is a property of the AWS::Lambda::Function resource that specifies a Dead Letter Queue (DLQ)
    /// that AWS Lambda (Lambda) sends events to when it can't process them. For example, you can send unprocessed
    /// events to an Amazon Simple Notification Service (Amazon SNS) topic, where you can take further action.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-function-deadletterconfig.html
    /// </summary>
    public class DeadLetterConfig
    {

        /// <summary>
        /// TargetArn
        /// The Amazon Resource Name (ARN) of a resource where Lambda delivers unprocessed events, such as an
        /// Amazon SNS topic or Amazon Simple Queue Service (Amazon SQS) queue. For the Lambda function
        /// execution role, you must explicitly provide the relevant permissions so that access to your DLQ
        /// resource is part of the execution role for your Lambda function.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("TargetArn")]
        public Union<string, IntrinsicFunction> TargetArn { get; set; }

    }
}
