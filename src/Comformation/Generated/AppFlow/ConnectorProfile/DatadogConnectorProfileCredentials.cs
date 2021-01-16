using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppFlow.ConnectorProfile
{
    /// <summary>
    /// AWS::AppFlow::ConnectorProfile DatadogConnectorProfileCredentials
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-datadogconnectorprofilecredentials.html
    /// </summary>
    public class DatadogConnectorProfileCredentials
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
        /// ApplicationKey
        /// Application keys, in conjunction with your API key, give you full access to Datadog’s programmatic
        /// API. Application keys are associated with the user account that created them. The application key is
        /// used to log all requests made to the API.
        /// Required: Yes
        /// Type: String
        /// Maximum: 512
        /// Pattern: \S+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ApplicationKey")]
        public Union<string, IntrinsicFunction> ApplicationKey { get; set; }

    }
}
