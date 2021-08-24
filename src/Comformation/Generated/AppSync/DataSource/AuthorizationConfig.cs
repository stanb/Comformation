using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppSync.DataSource
{
    /// <summary>
    /// AWS::AppSync::DataSource AuthorizationConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-datasource-authorizationconfig.html
    /// </summary>
    public class AuthorizationConfig
    {

        /// <summary>
        /// AwsIamConfig
        /// The AWS Identity and Access Management settings.
        /// Required: No
        /// Type: AwsIamConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AwsIamConfig")]
        public AwsIamConfig AwsIamConfig { get; set; }

        /// <summary>
        /// AuthorizationType
        /// The authorization type required by the HTTP endpoint.
        /// AWS_IAM: The authorization type is Sigv4.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AuthorizationType")]
        public Union<string, IntrinsicFunction> AuthorizationType { get; set; }

    }
}
