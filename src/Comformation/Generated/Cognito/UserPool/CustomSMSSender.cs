using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPool
{
    /// <summary>
    /// AWS::Cognito::UserPool CustomSMSSender
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-customsmssender.html
    /// </summary>
    public class CustomSMSSender
    {

        /// <summary>
        /// LambdaArn
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LambdaArn")]
        public Union<string, IntrinsicFunction> LambdaArn { get; set; }

        /// <summary>
        /// LambdaVersion
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LambdaVersion")]
        public Union<string, IntrinsicFunction> LambdaVersion { get; set; }

    }
}
