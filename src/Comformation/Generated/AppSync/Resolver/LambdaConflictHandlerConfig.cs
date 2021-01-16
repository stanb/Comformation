using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppSync.Resolver
{
    /// <summary>
    /// AWS::AppSync::Resolver LambdaConflictHandlerConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-resolver-lambdaconflicthandlerconfig.html
    /// </summary>
    public class LambdaConflictHandlerConfig
    {

        /// <summary>
        /// LambdaConflictHandlerArn
        /// The Arn for the Lambda function to use as the Conflict Handler.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LambdaConflictHandlerArn")]
        public Union<string, IntrinsicFunction> LambdaConflictHandlerArn { get; set; }

    }
}
