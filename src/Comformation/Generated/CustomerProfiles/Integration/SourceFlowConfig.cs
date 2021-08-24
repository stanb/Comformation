using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CustomerProfiles.Integration
{
    /// <summary>
    /// AWS::CustomerProfiles::Integration SourceFlowConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-integration-sourceflowconfig.html
    /// </summary>
    public class SourceFlowConfig
    {

        /// <summary>
        /// ConnectorType
        /// Not currently supported by AWS CloudFormation.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ConnectorType")]
        public Union<string, IntrinsicFunction> ConnectorType { get; set; }

        /// <summary>
        /// ConnectorProfileName
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ConnectorProfileName")]
        public Union<string, IntrinsicFunction> ConnectorProfileName { get; set; }

        /// <summary>
        /// IncrementalPullConfig
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: IncrementalPullConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IncrementalPullConfig")]
        public IncrementalPullConfig IncrementalPullConfig { get; set; }

        /// <summary>
        /// SourceConnectorProperties
        /// Not currently supported by AWS CloudFormation.
        /// Required: Yes
        /// Type: SourceConnectorProperties
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SourceConnectorProperties")]
        public SourceConnectorProperties SourceConnectorProperties { get; set; }

    }
}
