using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Pipeline
{
    /// <summary>
    /// AWS::IoTAnalytics::Pipeline Lambda
    /// An activity that runs a Lambda function to modify the message.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-pipeline-lambda.html
    /// </summary>
    public class Lambda
    {

        /// <summary>
        /// BatchSize
        /// The number of messages passed to the Lambda function for processing.
        /// The AWS Lambda function must be able to process all of these messages within five minutes, which is
        /// the maximum timeout duration for Lambda functions.
        /// Required: No
        /// Type: Integer
        /// Minimum: 1
        /// Maximum: 1000
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BatchSize")]
        public Union<int, IntrinsicFunction> BatchSize { get; set; }

        /// <summary>
        /// Next
        /// The next activity in the pipeline.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 128
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Next")]
        public Union<string, IntrinsicFunction> Next { get; set; }

        /// <summary>
        /// LambdaName
        /// The name of the Lambda function that is run on the message.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 64
        /// Pattern: ^[a-zA-Z0-9_-]+$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LambdaName")]
        public Union<string, IntrinsicFunction> LambdaName { get; set; }

        /// <summary>
        /// Name
        /// The name of the &#39;lambda&#39; activity.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 128
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
