using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppFlow.ConnectorProfile
{
    /// <summary>
    /// AWS::AppFlow::ConnectorProfile AmplitudeConnectorProfileCredentials
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-amplitudeconnectorprofilecredentials.html
    /// </summary>
    public class AmplitudeConnectorProfileCredentials
    {

        /// <summary>
        /// ApiKey
        /// A unique alphanumeric identifier used to authenticate a user, developer, or calling program to your
        /// API.
        /// Required: Yes
        /// Type: String
        /// Maximum: 256
        /// Pattern: \S+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ApiKey")]
        public Union<string, IntrinsicFunction> ApiKey { get; set; }

        /// <summary>
        /// SecretKey
        /// The Secret Access Key portion of the credentials.
        /// Required: Yes
        /// Type: String
        /// Maximum: 256
        /// Pattern: \S+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecretKey")]
        public Union<string, IntrinsicFunction> SecretKey { get; set; }

    }
}
