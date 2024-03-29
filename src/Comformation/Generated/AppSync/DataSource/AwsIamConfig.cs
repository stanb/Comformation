using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppSync.DataSource
{
    /// <summary>
    /// AWS::AppSync::DataSource AwsIamConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-datasource-awsiamconfig.html
    /// </summary>
    public class AwsIamConfig
    {

        /// <summary>
        /// SigningRegion
        /// The signing region for AWS Identity and Access Management authorization.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SigningRegion")]
        public Union<string, IntrinsicFunction> SigningRegion { get; set; }

        /// <summary>
        /// SigningServiceName
        /// The signing service name for AWS Identity and Access Management authorization.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SigningServiceName")]
        public Union<string, IntrinsicFunction> SigningServiceName { get; set; }

    }
}
