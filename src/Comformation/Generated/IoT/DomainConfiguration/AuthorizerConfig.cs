using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.DomainConfiguration
{
    /// <summary>
    /// AWS::IoT::DomainConfiguration AuthorizerConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-domainconfiguration-authorizerconfig.html
    /// </summary>
    public class AuthorizerConfig
    {

        /// <summary>
        /// AllowAuthorizerOverride
        /// A Boolean that specifies whether the domain configuration&#39;s authorization service can be overridden.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AllowAuthorizerOverride")]
        public Union<bool, IntrinsicFunction> AllowAuthorizerOverride { get; set; }

        /// <summary>
        /// DefaultAuthorizerName
        /// The name of the authorization service for a domain configuration.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DefaultAuthorizerName")]
        public Union<string, IntrinsicFunction> DefaultAuthorizerName { get; set; }

    }
}
