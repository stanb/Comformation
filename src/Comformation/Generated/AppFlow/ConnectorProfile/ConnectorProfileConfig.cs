using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppFlow.ConnectorProfile
{
    /// <summary>
    /// AWS::AppFlow::ConnectorProfile ConnectorProfileConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-connectorprofileconfig.html
    /// </summary>
    public class ConnectorProfileConfig
    {

        /// <summary>
        /// ConnectorProfileProperties
        /// The connector-specific properties of the profile configuration.
        /// Required: No
        /// Type: ConnectorProfileProperties
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ConnectorProfileProperties")]
        public ConnectorProfileProperties ConnectorProfileProperties { get; set; }

        /// <summary>
        /// ConnectorProfileCredentials
        /// The connector-specific credentials required by each connector.
        /// Required: Yes
        /// Type: ConnectorProfileCredentials
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ConnectorProfileCredentials")]
        public ConnectorProfileCredentials ConnectorProfileCredentials { get; set; }

    }
}
