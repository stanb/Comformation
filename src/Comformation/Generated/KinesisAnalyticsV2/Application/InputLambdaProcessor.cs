using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalyticsV2.Application
{
    /// <summary>
    /// AWS::KinesisAnalyticsV2::Application InputLambdaProcessor
    /// An object that contains the Amazon Resource Name (ARN) of the AWS Lambda function that is used to preprocess
    /// records in the stream in an SQL-based Amazon Kinesis Data Analytics application.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-inputlambdaprocessor.html
    /// </summary>
    public class InputLambdaProcessor
    {

        /// <summary>
        /// ResourceARN
        /// The ARN of the AWS Lambda function that operates on records in the stream.
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

    }
}
