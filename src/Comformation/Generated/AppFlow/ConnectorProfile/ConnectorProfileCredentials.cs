using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppFlow.ConnectorProfile
{
    /// <summary>
    /// AWS::AppFlow::ConnectorProfile ConnectorProfileCredentials
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-connectorprofilecredentials.html
    /// </summary>
    public class ConnectorProfileCredentials
    {

        /// <summary>
        /// Amplitude
        /// The connector-specific credentials required when using Amplitude.
        /// Required: No
        /// Type: AmplitudeConnectorProfileCredentials
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Amplitude")]
        public AmplitudeConnectorProfileCredentials Amplitude { get; set; }

        /// <summary>
        /// Datadog
        /// The connector-specific credentials required when using Datadog.
        /// Required: No
        /// Type: DatadogConnectorProfileCredentials
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Datadog")]
        public DatadogConnectorProfileCredentials Datadog { get; set; }

        /// <summary>
        /// Dynatrace
        /// The connector-specific credentials required when using Dynatrace.
        /// Required: No
        /// Type: DynatraceConnectorProfileCredentials
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Dynatrace")]
        public DynatraceConnectorProfileCredentials Dynatrace { get; set; }

        /// <summary>
        /// GoogleAnalytics
        /// The connector-specific credentials required when using Google Analytics.
        /// Required: No
        /// Type: GoogleAnalyticsConnectorProfileCredentials
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("GoogleAnalytics")]
        public GoogleAnalyticsConnectorProfileCredentials GoogleAnalytics { get; set; }

        /// <summary>
        /// InforNexus
        /// The connector-specific credentials required when using Infor Nexus.
        /// Required: No
        /// Type: InforNexusConnectorProfileCredentials
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InforNexus")]
        public InforNexusConnectorProfileCredentials InforNexus { get; set; }

        /// <summary>
        /// Marketo
        /// The connector-specific credentials required when using Marketo.
        /// Required: No
        /// Type: MarketoConnectorProfileCredentials
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Marketo")]
        public MarketoConnectorProfileCredentials Marketo { get; set; }

        /// <summary>
        /// Redshift
        /// The connector-specific credentials required when using Amazon Redshift.
        /// Required: No
        /// Type: RedshiftConnectorProfileCredentials
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Redshift")]
        public RedshiftConnectorProfileCredentials Redshift { get; set; }

        /// <summary>
        /// Salesforce
        /// The connector-specific credentials required when using Salesforce.
        /// Required: No
        /// Type: SalesforceConnectorProfileCredentials
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Salesforce")]
        public SalesforceConnectorProfileCredentials Salesforce { get; set; }

        /// <summary>
        /// ServiceNow
        /// The connector-specific credentials required when using ServiceNow.
        /// Required: No
        /// Type: ServiceNowConnectorProfileCredentials
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ServiceNow")]
        public ServiceNowConnectorProfileCredentials ServiceNow { get; set; }

        /// <summary>
        /// Singular
        /// The connector-specific credentials required when using Singular.
        /// Required: No
        /// Type: SingularConnectorProfileCredentials
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Singular")]
        public SingularConnectorProfileCredentials Singular { get; set; }

        /// <summary>
        /// Slack
        /// The connector-specific credentials required when using Slack.
        /// Required: No
        /// Type: SlackConnectorProfileCredentials
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Slack")]
        public SlackConnectorProfileCredentials Slack { get; set; }

        /// <summary>
        /// Snowflake
        /// The connector-specific credentials required when using Snowflake.
        /// Required: No
        /// Type: SnowflakeConnectorProfileCredentials
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Snowflake")]
        public SnowflakeConnectorProfileCredentials Snowflake { get; set; }

        /// <summary>
        /// Trendmicro
        /// The connector-specific credentials required when using Trend Micro.
        /// Required: No
        /// Type: TrendmicroConnectorProfileCredentials
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Trendmicro")]
        public TrendmicroConnectorProfileCredentials Trendmicro { get; set; }

        /// <summary>
        /// Veeva
        /// The connector-specific credentials required when using Veeva.
        /// Required: No
        /// Type: VeevaConnectorProfileCredentials
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Veeva")]
        public VeevaConnectorProfileCredentials Veeva { get; set; }

        /// <summary>
        /// Zendesk
        /// The connector-specific credentials required when using Zendesk.
        /// Required: No
        /// Type: ZendeskConnectorProfileCredentials
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Zendesk")]
        public ZendeskConnectorProfileCredentials Zendesk { get; set; }

    }
}
