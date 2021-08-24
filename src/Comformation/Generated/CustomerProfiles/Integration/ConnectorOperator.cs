using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CustomerProfiles.Integration
{
    /// <summary>
    /// AWS::CustomerProfiles::Integration ConnectorOperator
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-integration-connectoroperator.html
    /// </summary>
    public class ConnectorOperator
    {

        /// <summary>
        /// Marketo
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Marketo")]
        public Union<string, IntrinsicFunction> Marketo { get; set; }

        /// <summary>
        /// S3
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3")]
        public Union<string, IntrinsicFunction> S3 { get; set; }

        /// <summary>
        /// Salesforce
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Salesforce")]
        public Union<string, IntrinsicFunction> Salesforce { get; set; }

        /// <summary>
        /// ServiceNow
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ServiceNow")]
        public Union<string, IntrinsicFunction> ServiceNow { get; set; }

        /// <summary>
        /// Zendesk
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Zendesk")]
        public Union<string, IntrinsicFunction> Zendesk { get; set; }

    }
}
