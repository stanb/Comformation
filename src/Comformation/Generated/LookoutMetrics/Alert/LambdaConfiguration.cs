using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.LookoutMetrics.Alert
{
    /// <summary>
    /// AWS::LookoutMetrics::Alert LambdaConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lookoutmetrics-alert-lambdaconfiguration.html
    /// </summary>
    public class LambdaConfiguration
    {

        /// <summary>
        /// RoleArn
        /// The ARN of an IAM role that has permission to invoke the Lambda function.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

        /// <summary>
        /// LambdaArn
        /// The ARN of the Lambda function.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("LambdaArn")]
        public Union<string, IntrinsicFunction> LambdaArn { get; set; }

    }
}
