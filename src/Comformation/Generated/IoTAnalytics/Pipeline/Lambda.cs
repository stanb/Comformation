using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Pipeline
{
    /// <summary>
    /// AWS IoT Analytics Pipeline Lambda
    /// The Lambda property type specifies a Lambda function to run to modify a message for an AWS IoT Analytics
    /// pipeline.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-pipeline-lambda.html
    /// </summary>
    public class Lambda
    {

        /// <summary>
        /// BatchSize
        /// The number of messages that should be passed to the Lambda function for processing within 5 minutes.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BatchSize")]
        public Union<int, IntrinsicFunction> BatchSize { get; set; }

        /// <summary>
        /// Next
        /// The next activity in the pipeline.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Next")]
        public Union<string, IntrinsicFunction> Next { get; set; }

        /// <summary>
        /// LambdaName
        /// The name of the Lambda function that is run on the message.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LambdaName")]
        public Union<string, IntrinsicFunction> LambdaName { get; set; }

        /// <summary>
        /// Name
        /// The name of the &#39;lambda&#39; activity.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
