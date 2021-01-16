using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppFlow.Flow
{
    /// <summary>
    /// AWS::AppFlow::Flow SourceFlowConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sourceflowconfig.html
    /// </summary>
    public class SourceFlowConfig
    {

        /// <summary>
        /// ConnectorType
        /// The type of source connector, such as Salesforce, Amplitude, and so on.
        /// Allowed Values: S3 | Amplitude | Datadog | Dynatrace | Googleanalytics | Infornexus | Salesforce |
        /// Servicenow | Singular | Slack | Trendmicro | Veeva | Zendesk
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
        /// SourceConnectorProperties
        /// Specifies the information that is required to query a particular source connector.
        /// Required: Yes
        /// Type: SourceConnectorProperties
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SourceConnectorProperties")]
        public SourceConnectorProperties SourceConnectorProperties { get; set; }

        /// <summary>
        /// IncrementalPullConfig
        /// Defines the configuration for a scheduled incremental data pull. If a valid configuration is
        /// provided, the fields specified in the configuration are used when querying for the incremental data
        /// pull.
        /// Required: No
        /// Type: IncrementalPullConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IncrementalPullConfig")]
        public IncrementalPullConfig IncrementalPullConfig { get; set; }

    }
}
