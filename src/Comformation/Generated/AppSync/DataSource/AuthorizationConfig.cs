using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppSync.DataSource
{
    /// <summary>
    /// AWS AppSync DataSource AuthorizationConfig
    /// The AuthorizationConfig property type specifies the authorization type and configuration for an AWS AppSync
    /// http data source.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-datasource-httpconfig-authorizationconfig.html
    /// </summary>
    public class AuthorizationConfig
    {

        /// <summary>
        /// AwsIamConfig
        /// The configuration for the Authorization.
        /// Required: No
        /// Type: AwsIamConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AwsIamConfig")]
        public AwsIamConfig AwsIamConfig { get; set; }

        /// <summary>
        /// AuthorizationType
        /// The type for the Authorization.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AuthorizationType")]
        public Union<string, IntrinsicFunction> AuthorizationType { get; set; }

    }
}
