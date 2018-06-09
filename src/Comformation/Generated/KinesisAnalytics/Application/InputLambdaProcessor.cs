using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalytics.Application
{
    /// <summary>
    /// Amazon Kinesis Data Analytics Application InputLambdaProcessor
    /// The InputLambdaProcessor property type specifies the Amazon Resource Name (ARN) of a Lambda function for
    /// preprocessing records in a stream before the SQL code for an Amazon Kinesis Data Analytics application
    /// executes.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-application-inputlambdaprocessor.html
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

        /// <summary>
        /// RoleARN
        /// The ARN of the IAM role that is used to access the AWS Lambda function.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleARN")]
        public Union<string, IntrinsicFunction> RoleARN { get; set; }

    }
}
