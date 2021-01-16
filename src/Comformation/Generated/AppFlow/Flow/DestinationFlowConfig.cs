using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppFlow.Flow
{
    /// <summary>
    /// AWS::AppFlow::Flow DestinationFlowConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-destinationflowconfig.html
    /// </summary>
    public class DestinationFlowConfig
    {

        /// <summary>
        /// ConnectorType
        /// The type of destination connector, such as Salesforce, Amazon S3, and so on.
        /// Allowed Values: EventBridge | Redshift | S3 | Salesforce | Snowflake
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ConnectorType")]
        public Union<string, IntrinsicFunction> ConnectorType { get; set; }

        /// <summary>
        /// ConnectorProfileName
        /// The name of the connector profile. This name must be unique for each connector profile in the AWS
        /// account.
        /// Required: No
        /// Type: String
        /// Maximum: 256
        /// Pattern: [\w/!@#+=. -]+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ConnectorProfileName")]
        public Union<string, IntrinsicFunction> ConnectorProfileName { get; set; }

        /// <summary>
        /// DestinationConnectorProperties
        /// This stores the information that is required to query a particular connector.
        /// Required: Yes
        /// Type: DestinationConnectorProperties
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DestinationConnectorProperties")]
        public DestinationConnectorProperties DestinationConnectorProperties { get; set; }

    }
}
