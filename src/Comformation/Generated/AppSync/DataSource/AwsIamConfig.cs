using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppSync.DataSource
{
    /// <summary>
    /// AWS AppSync AuthorizationConfig AwsIamConfig
    /// Use the AwsIamConfig property type to specify AwsIamConfig for a AWS AppSync authorizaton.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-datasource-httpconfig-authorizationconfig-awsiamconfig.html
    /// </summary>
    public class AwsIamConfig
    {

        /// <summary>
        /// SigningRegion
        /// The region of signing.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SigningRegion")]
        public Union<string, IntrinsicFunction> SigningRegion { get; set; }

        /// <summary>
        /// SigningServiceName
        /// The service name of signing.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SigningServiceName")]
        public Union<string, IntrinsicFunction> SigningServiceName { get; set; }

    }
}
