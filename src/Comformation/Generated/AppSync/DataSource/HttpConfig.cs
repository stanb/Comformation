using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppSync.DataSource
{
    /// <summary>
    /// AWS::AppSync::DataSource HttpConfig
    /// Use the HttpConfig property type to specify HttpConfig for an AWS AppSync data source.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-datasource-httpconfig.html
    /// </summary>
    public class HttpConfig
    {

        /// <summary>
        /// Endpoint
        /// The endpoint.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Endpoint")]
        public Union<string, IntrinsicFunction> Endpoint { get; set; }

        /// <summary>
        /// AuthorizationConfig
        /// The authorization configuration.
        /// Required: No
        /// Type: AuthorizationConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AuthorizationConfig")]
        public AuthorizationConfig AuthorizationConfig { get; set; }

    }
}
