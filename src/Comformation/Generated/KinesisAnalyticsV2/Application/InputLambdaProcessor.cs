using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalyticsV2.Application
{
    /// <summary>
    /// Amazon Kinesis Data Analytics Application InputLambdaProcessor
    /// The InputLambdaProcessor property type specifies the Amazon Resource Name (ARN) of the AWS Lambda function
    /// that is used to preprocess records in the stream in an SQL-based Amazon Kinesis Data Analytics application.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-inputlambdaprocessor.html
    /// </summary>
    public class InputLambdaProcessor
    {

        /// <summary>
        /// ResourceARN
        /// The ARN of the AWS Lambda function that operates on records in the stream.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ResourceARN")]
        public Union<string, IntrinsicFunction> ResourceARN { get; set; }

    }
}
