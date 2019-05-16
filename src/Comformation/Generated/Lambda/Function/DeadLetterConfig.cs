using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Lambda.Function
{
    /// <summary>
    /// AWS::Lambda::Function DeadLetterConfig
    /// The dead letter queue for failed asynchronous invocations.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-function-deadletterconfig.html
    /// </summary>
    public class DeadLetterConfig
    {

        /// <summary>
        /// TargetArn
        /// The Amazon Resource Name (ARN) of an Amazon SQS queue or Amazon SNS topic.
        /// Required: No
        /// Type: String
        /// Pattern: (arn:(aws[a-zA-Z-]*)?:[a-z0-9-. ]+:. *)|()
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TargetArn")]
        public Union<string, IntrinsicFunction> TargetArn { get; set; }

    }
}
