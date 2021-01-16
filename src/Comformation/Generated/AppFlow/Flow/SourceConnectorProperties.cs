using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppFlow.Flow
{
    /// <summary>
    /// AWS::AppFlow::Flow SourceConnectorProperties
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sourceconnectorproperties.html
    /// </summary>
    public class SourceConnectorProperties
    {

        /// <summary>
        /// Amplitude
        /// Specifies the information that is required for querying Amplitude.
        /// Required: No
        /// Type: AmplitudeSourceProperties
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Amplitude")]
        public AmplitudeSourceProperties Amplitude { get; set; }

        /// <summary>
        /// Datadog
        /// Specifies the information that is required for querying Datadog.
        /// Required: No
        /// Type: DatadogSourceProperties
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Datadog")]
        public DatadogSourceProperties Datadog { get; set; }

        /// <summary>
        /// Dynatrace
        /// Specifies the information that is required for querying Dynatrace.
        /// Required: No
        /// Type: DynatraceSourceProperties
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Dynatrace")]
        public DynatraceSourceProperties Dynatrace { get; set; }

        /// <summary>
        /// GoogleAnalytics
        /// Specifies the information that is required for querying Google Analytics.
        /// Required: No
        /// Type: GoogleAnalyticsSourceProperties
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("GoogleAnalytics")]
        public GoogleAnalyticsSourceProperties GoogleAnalytics { get; set; }

        /// <summary>
        /// InforNexus
        /// Specifies the information that is required for querying Infor Nexus.
        /// Required: No
        /// Type: InforNexusSourceProperties
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InforNexus")]
        public InforNexusSourceProperties InforNexus { get; set; }

        /// <summary>
        /// Marketo
        /// Specifies the information that is required for querying Marketo.
        /// Required: No
        /// Type: MarketoSourceProperties
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Marketo")]
        public MarketoSourceProperties Marketo { get; set; }

        /// <summary>
        /// S3
        /// Specifies the information that is required for querying Amazon S3.
        /// Required: No
        /// Type: S3SourceProperties
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3")]
        public S3SourceProperties S3 { get; set; }

        /// <summary>
        /// Salesforce
        /// Specifies the information that is required for querying Salesforce.
        /// Required: No
        /// Type: SalesforceSourceProperties
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Salesforce")]
        public SalesforceSourceProperties Salesforce { get; set; }

        /// <summary>
        /// ServiceNow
        /// Specifies the information that is required for querying ServiceNow.
        /// Required: No
        /// Type: ServiceNowSourceProperties
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ServiceNow")]
        public ServiceNowSourceProperties ServiceNow { get; set; }

        /// <summary>
        /// Singular
        /// Specifies the information that is required for querying Singular.
        /// Required: No
        /// Type: SingularSourceProperties
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Singular")]
        public SingularSourceProperties Singular { get; set; }

        /// <summary>
        /// Slack
        /// Specifies the information that is required for querying Slack.
        /// Required: No
        /// Type: SlackSourceProperties
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Slack")]
        public SlackSourceProperties Slack { get; set; }

        /// <summary>
        /// Trendmicro
        /// Specifies the information that is required for querying Trend Micro.
        /// Required: No
        /// Type: TrendmicroSourceProperties
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Trendmicro")]
        public TrendmicroSourceProperties Trendmicro { get; set; }

        /// <summary>
        /// Veeva
        /// Specifies the information that is required for querying Veeva.
        /// Required: No
        /// Type: VeevaSourceProperties
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Veeva")]
        public VeevaSourceProperties Veeva { get; set; }

        /// <summary>
        /// Zendesk
        /// Specifies the information that is required for querying Zendesk.
        /// Required: No
        /// Type: ZendeskSourceProperties
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Zendesk")]
        public ZendeskSourceProperties Zendesk { get; set; }

    }
}
