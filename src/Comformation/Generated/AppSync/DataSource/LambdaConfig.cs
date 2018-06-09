using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppSync.DataSource
{
    /// <summary>
    /// AWS AppSync DataSource LambdaConfig
    /// The LambdaConfig property type specifies the Lambda function ARN for an AWS AppSync data source.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-datasource-lambdaconfig.html
    /// </summary>
    public class LambdaConfig
    {

        /// <summary>
        /// LambdaFunctionArn
        /// The ARN for the Lambda function.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LambdaFunctionArn")]
        public Union<string, IntrinsicFunction> LambdaFunctionArn { get; set; }

    }
}
