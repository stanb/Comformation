using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalytics.ApplicationOutput
{
    /// <summary>
    /// AWS::KinesisAnalytics::ApplicationOutput LambdaOutput
    /// When configuring application output, identifies an AWS Lambda function as the destination. You provide the
    /// function Amazon Resource Name (ARN) and also an IAM role ARN that Amazon Kinesis Analytics can use to write to
    /// the function on your behalf.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-applicationoutput-lambdaoutput.html
    /// </summary>
    public class LambdaOutput
    {

        /// <summary>
        /// ResourceARN
        /// Amazon Resource Name (ARN) of the destination Lambda function to write to.
        /// Note To specify an earlier version of the Lambda function than the latest, include the Lambda
        /// function version in the Lambda function ARN. For more information about Lambda ARNs, see Example
        /// ARNs: AWS Lambda
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 2048
        /// Pattern: arn:. *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ResourceARN")]
        public Union<string, IntrinsicFunction> ResourceARN { get; set; }

        /// <summary>
        /// RoleARN
        /// ARN of the IAM role that Amazon Kinesis Analytics can assume to write to the destination function on
        /// your behalf. You need to grant the necessary permissions to this role.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 2048
        /// Pattern: arn:aws:iam::\d{12}:role/?[a-zA-Z_0-9+=,. @\-_/]+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleARN")]
        public Union<string, IntrinsicFunction> RoleARN { get; set; }

    }
}
