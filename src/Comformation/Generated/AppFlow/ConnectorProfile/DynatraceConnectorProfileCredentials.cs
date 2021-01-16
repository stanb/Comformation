using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppFlow.ConnectorProfile
{
    /// <summary>
    /// AWS::AppFlow::ConnectorProfile DynatraceConnectorProfileCredentials
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-dynatraceconnectorprofilecredentials.html
    /// </summary>
    public class DynatraceConnectorProfileCredentials
    {

        /// <summary>
        /// ApiToken
        /// The API tokens used by Dynatrace API to authenticate various API calls.
        /// Required: Yes
        /// Type: String
        /// Maximum: 256
        /// Pattern: \S+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ApiToken")]
        public Union<string, IntrinsicFunction> ApiToken { get; set; }

    }
}
