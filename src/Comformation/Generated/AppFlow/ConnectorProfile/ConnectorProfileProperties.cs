using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppFlow.ConnectorProfile
{
    /// <summary>
    /// AWS::AppFlow::ConnectorProfile ConnectorProfileProperties
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-connectorprofileproperties.html
    /// </summary>
    public class ConnectorProfileProperties
    {

        /// <summary>
        /// Datadog
        /// The connector-specific properties required by Datadog.
        /// Required: No
        /// Type: DatadogConnectorProfileProperties
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Datadog")]
        public DatadogConnectorProfileProperties Datadog { get; set; }

        /// <summary>
        /// Dynatrace
        /// The connector-specific properties required by Dynatrace.
        /// Required: No
        /// Type: DynatraceConnectorProfileProperties
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Dynatrace")]
        public DynatraceConnectorProfileProperties Dynatrace { get; set; }

        /// <summary>
        /// InforNexus
        /// The connector-specific properties required by Infor Nexus.
        /// Required: No
        /// Type: InforNexusConnectorProfileProperties
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InforNexus")]
        public InforNexusConnectorProfileProperties InforNexus { get; set; }

        /// <summary>
        /// Marketo
        /// The connector-specific properties required by Marketo.
        /// Required: No
        /// Type: MarketoConnectorProfileProperties
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Marketo")]
        public MarketoConnectorProfileProperties Marketo { get; set; }

        /// <summary>
        /// Redshift
        /// The connector-specific properties required by Amazon Redshift.
        /// Required: No
        /// Type: RedshiftConnectorProfileProperties
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Redshift")]
        public RedshiftConnectorProfileProperties Redshift { get; set; }

        /// <summary>
        /// Salesforce
        /// The connector-specific properties required by Salesforce.
        /// Required: No
        /// Type: SalesforceConnectorProfileProperties
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Salesforce")]
        public SalesforceConnectorProfileProperties Salesforce { get; set; }

        /// <summary>
        /// ServiceNow
        /// The connector-specific properties required by serviceNow.
        /// Required: No
        /// Type: ServiceNowConnectorProfileProperties
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ServiceNow")]
        public ServiceNowConnectorProfileProperties ServiceNow { get; set; }

        /// <summary>
        /// Slack
        /// The connector-specific properties required by Slack.
        /// Required: No
        /// Type: SlackConnectorProfileProperties
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Slack")]
        public SlackConnectorProfileProperties Slack { get; set; }

        /// <summary>
        /// Snowflake
        /// The connector-specific properties required by Snowflake.
        /// Required: No
        /// Type: SnowflakeConnectorProfileProperties
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Snowflake")]
        public SnowflakeConnectorProfileProperties Snowflake { get; set; }

        /// <summary>
        /// Veeva
        /// The connector-specific properties required by Veeva.
        /// Required: No
        /// Type: VeevaConnectorProfileProperties
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Veeva")]
        public VeevaConnectorProfileProperties Veeva { get; set; }

        /// <summary>
        /// Zendesk
        /// The connector-specific properties required by Zendesk.
        /// Required: No
        /// Type: ZendeskConnectorProfileProperties
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Zendesk")]
        public ZendeskConnectorProfileProperties Zendesk { get; set; }

    }
}
