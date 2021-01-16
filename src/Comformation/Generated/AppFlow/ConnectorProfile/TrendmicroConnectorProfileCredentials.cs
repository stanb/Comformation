using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppFlow.ConnectorProfile
{
    /// <summary>
    /// AWS::AppFlow::ConnectorProfile TrendmicroConnectorProfileCredentials
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-trendmicroconnectorprofilecredentials.html
    /// </summary>
    public class TrendmicroConnectorProfileCredentials
    {

        /// <summary>
        /// ApiSecretKey
        /// The Secret Access Key portion of the credentials.
        /// Required: Yes
        /// Type: String
        /// Maximum: 256
        /// Pattern: \S+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ApiSecretKey")]
        public Union<string, IntrinsicFunction> ApiSecretKey { get; set; }

    }
}
