using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CustomerProfiles.Integration
{
    /// <summary>
    /// AWS::CustomerProfiles::Integration SourceConnectorProperties
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-integration-sourceconnectorproperties.html
    /// </summary>
    public class SourceConnectorProperties
    {

        /// <summary>
        /// Marketo
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: MarketoSourceProperties
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Marketo")]
        public MarketoSourceProperties Marketo { get; set; }

        /// <summary>
        /// S3
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: S3SourceProperties
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3")]
        public S3SourceProperties S3 { get; set; }

        /// <summary>
        /// Salesforce
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: SalesforceSourceProperties
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Salesforce")]
        public SalesforceSourceProperties Salesforce { get; set; }

        /// <summary>
        /// ServiceNow
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: ServiceNowSourceProperties
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ServiceNow")]
        public ServiceNowSourceProperties ServiceNow { get; set; }

        /// <summary>
        /// Zendesk
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: ZendeskSourceProperties
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Zendesk")]
        public ZendeskSourceProperties Zendesk { get; set; }

    }
}
