using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppFlow.ConnectorProfile
{
    /// <summary>
    /// AWS::AppFlow::ConnectorProfile SalesforceConnectorProfileProperties
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-salesforceconnectorprofileproperties.html
    /// </summary>
    public class SalesforceConnectorProfileProperties
    {

        /// <summary>
        /// InstanceUrl
        /// The location of the Salesforce resource.
        /// Required: No
        /// Type: String
        /// Maximum: 256
        /// Pattern: \S+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InstanceUrl")]
        public Union<string, IntrinsicFunction> InstanceUrl { get; set; }

        /// <summary>
        /// isSandboxEnvironment
        /// Indicates whether the connector profile applies to a sandbox or production environment.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("isSandboxEnvironment")]
        public Union<bool, IntrinsicFunction> isSandboxEnvironment { get; set; }

    }
}
