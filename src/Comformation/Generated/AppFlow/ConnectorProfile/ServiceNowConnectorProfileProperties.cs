using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppFlow.ConnectorProfile
{
    /// <summary>
    /// AWS::AppFlow::ConnectorProfile ServiceNowConnectorProfileProperties
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-servicenowconnectorprofileproperties.html
    /// </summary>
    public class ServiceNowConnectorProfileProperties
    {

        /// <summary>
        /// InstanceUrl
        /// The location of the ServiceNow resource.
        /// Required: Yes
        /// Type: String
        /// Maximum: 256
        /// Pattern: \S+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InstanceUrl")]
        public Union<string, IntrinsicFunction> InstanceUrl { get; set; }

    }
}
