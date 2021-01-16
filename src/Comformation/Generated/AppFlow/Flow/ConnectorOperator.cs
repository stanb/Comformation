using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppFlow.Flow
{
    /// <summary>
    /// AWS::AppFlow::Flow ConnectorOperator
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-connectoroperator.html
    /// </summary>
    public class ConnectorOperator
    {

        /// <summary>
        /// Amplitude
        /// The operation to be performed on the provided Amplitude source fields.
        /// Required: No
        /// Type: String
        /// Allowed values: BETWEEN
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Amplitude")]
        public Union<string, IntrinsicFunction> Amplitude { get; set; }

        /// <summary>
        /// Datadog
        /// The operation to be performed on the provided Datadog source fields.
        /// Required: No
        /// Type: String
        /// Allowed values: ADDITION | BETWEEN | DIVISION | EQUAL_TO | MASK_ALL | MASK_FIRST_N | MASK_LAST_N |
        /// MULTIPLICATION | NO_OP | PROJECTION | SUBTRACTION | VALIDATE_NON_NEGATIVE | VALIDATE_NON_NULL |
        /// VALIDATE_NON_ZERO | VALIDATE_NUMERIC
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Datadog")]
        public Union<string, IntrinsicFunction> Datadog { get; set; }

        /// <summary>
        /// Dynatrace
        /// The operation to be performed on the provided Dynatrace source fields.
        /// Required: No
        /// Type: String
        /// Allowed values: ADDITION | BETWEEN | DIVISION | EQUAL_TO | MASK_ALL | MASK_FIRST_N | MASK_LAST_N |
        /// MULTIPLICATION | NO_OP | PROJECTION | SUBTRACTION | VALIDATE_NON_NEGATIVE | VALIDATE_NON_NULL |
        /// VALIDATE_NON_ZERO | VALIDATE_NUMERIC
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Dynatrace")]
        public Union<string, IntrinsicFunction> Dynatrace { get; set; }

        /// <summary>
        /// GoogleAnalytics
        /// The operation to be performed on the provided Google Analytics source fields.
        /// Required: No
        /// Type: String
        /// Allowed values: BETWEEN | PROJECTION
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("GoogleAnalytics")]
        public Union<string, IntrinsicFunction> GoogleAnalytics { get; set; }

        /// <summary>
        /// InforNexus
        /// The operation to be performed on the provided Infor Nexus source fields.
        /// Required: No
        /// Type: String
        /// Allowed values: ADDITION | BETWEEN | DIVISION | EQUAL_TO | MASK_ALL | MASK_FIRST_N | MASK_LAST_N |
        /// MULTIPLICATION | NO_OP | PROJECTION | SUBTRACTION | VALIDATE_NON_NEGATIVE | VALIDATE_NON_NULL |
        /// VALIDATE_NON_ZERO | VALIDATE_NUMERIC
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InforNexus")]
        public Union<string, IntrinsicFunction> InforNexus { get; set; }

        /// <summary>
        /// Marketo
        /// The operation to be performed on the provided Marketo source fields.
        /// Required: No
        /// Type: String
        /// Allowed values: ADDITION | BETWEEN | DIVISION | GREATER_THAN | LESS_THAN | MASK_ALL | MASK_FIRST_N |
        /// MASK_LAST_N | MULTIPLICATION | NO_OP | PROJECTION | SUBTRACTION | VALIDATE_NON_NEGATIVE |
        /// VALIDATE_NON_NULL | VALIDATE_NON_ZERO | VALIDATE_NUMERIC
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Marketo")]
        public Union<string, IntrinsicFunction> Marketo { get; set; }

        /// <summary>
        /// S3
        /// The operation to be performed on the provided Amazon S3 source fields.
        /// Required: No
        /// Type: String
        /// Allowed values: ADDITION | BETWEEN | DIVISION | EQUAL_TO | GREATER_THAN | GREATER_THAN_OR_EQUAL_TO |
        /// LESS_THAN | LESS_THAN_OR_EQUAL_TO | MASK_ALL | MASK_FIRST_N | MASK_LAST_N | MULTIPLICATION | NO_OP |
        /// NOT_EQUAL_TO | PROJECTION | SUBTRACTION | VALIDATE_NON_NEGATIVE | VALIDATE_NON_NULL |
        /// VALIDATE_NON_ZERO | VALIDATE_NUMERIC
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3")]
        public Union<string, IntrinsicFunction> S3 { get; set; }

        /// <summary>
        /// Salesforce
        /// The operation to be performed on the provided Salesforce source fields.
        /// Required: No
        /// Type: String
        /// Allowed values: ADDITION | BETWEEN | CONTAINS | DIVISION | EQUAL_TO | GREATER_THAN |
        /// GREATER_THAN_OR_EQUAL_TO | LESS_THAN | LESS_THAN_OR_EQUAL_TO | MASK_ALL | MASK_FIRST_N | MASK_LAST_N
        /// | MULTIPLICATION | NO_OP | NOT_EQUAL_TO | PROJECTION | SUBTRACTION | VALIDATE_NON_NEGATIVE |
        /// VALIDATE_NON_NULL | VALIDATE_NON_ZERO | VALIDATE_NUMERIC
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Salesforce")]
        public Union<string, IntrinsicFunction> Salesforce { get; set; }

        /// <summary>
        /// ServiceNow
        /// The operation to be performed on the provided ServiceNow source fields.
        /// Required: No
        /// Type: String
        /// Allowed values: ADDITION | BETWEEN | CONTAINS | DIVISION | EQUAL_TO | GREATER_THAN |
        /// GREATER_THAN_OR_EQUAL_TO | LESS_THAN | LESS_THAN_OR_EQUAL_TO | MASK_ALL | MASK_FIRST_N | MASK_LAST_N
        /// | MULTIPLICATION | NO_OP | NOT_EQUAL_TO | PROJECTION | SUBTRACTION | VALIDATE_NON_NEGATIVE |
        /// VALIDATE_NON_NULL | VALIDATE_NON_ZERO | VALIDATE_NUMERIC
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ServiceNow")]
        public Union<string, IntrinsicFunction> ServiceNow { get; set; }

        /// <summary>
        /// Singular
        /// The operation to be performed on the provided Singular source fields.
        /// Required: No
        /// Type: String
        /// Allowed values: ADDITION | DIVISION | EQUAL_TO | MASK_ALL | MASK_FIRST_N | MASK_LAST_N |
        /// MULTIPLICATION | NO_OP | PROJECTION | SUBTRACTION | VALIDATE_NON_NEGATIVE | VALIDATE_NON_NULL |
        /// VALIDATE_NON_ZERO | VALIDATE_NUMERIC
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Singular")]
        public Union<string, IntrinsicFunction> Singular { get; set; }

        /// <summary>
        /// Slack
        /// The operation to be performed on the provided Slack source fields.
        /// Required: No
        /// Type: String
        /// Allowed values: ADDITION | BETWEEN | DIVISION | EQUAL_TO | GREATER_THAN | GREATER_THAN_OR_EQUAL_TO |
        /// LESS_THAN | LESS_THAN_OR_EQUAL_TO | MASK_ALL | MASK_FIRST_N | MASK_LAST_N | MULTIPLICATION | NO_OP |
        /// PROJECTION | SUBTRACTION | VALIDATE_NON_NEGATIVE | VALIDATE_NON_NULL | VALIDATE_NON_ZERO |
        /// VALIDATE_NUMERIC
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Slack")]
        public Union<string, IntrinsicFunction> Slack { get; set; }

        /// <summary>
        /// Trendmicro
        /// The operation to be performed on the provided Trend Micro source fields.
        /// Required: No
        /// Type: String
        /// Allowed values: ADDITION | DIVISION | EQUAL_TO | MASK_ALL | MASK_FIRST_N | MASK_LAST_N |
        /// MULTIPLICATION | NO_OP | PROJECTION | SUBTRACTION | VALIDATE_NON_NEGATIVE | VALIDATE_NON_NULL |
        /// VALIDATE_NON_ZERO | VALIDATE_NUMERIC
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Trendmicro")]
        public Union<string, IntrinsicFunction> Trendmicro { get; set; }

        /// <summary>
        /// Veeva
        /// The operation to be performed on the provided Veeva source fields.
        /// Required: No
        /// Type: String
        /// Allowed values: ADDITION | BETWEEN | CONTAINS | DIVISION | EQUAL_TO | GREATER_THAN |
        /// GREATER_THAN_OR_EQUAL_TO | LESS_THAN | LESS_THAN_OR_EQUAL_TO | MASK_ALL | MASK_FIRST_N | MASK_LAST_N
        /// | MULTIPLICATION | NO_OP | NOT_EQUAL_TO | PROJECTION | SUBTRACTION | VALIDATE_NON_NEGATIVE |
        /// VALIDATE_NON_NULL | VALIDATE_NON_ZERO | VALIDATE_NUMERIC
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Veeva")]
        public Union<string, IntrinsicFunction> Veeva { get; set; }

        /// <summary>
        /// Zendesk
        /// The operation to be performed on the provided Zendesk source fields.
        /// Required: No
        /// Type: String
        /// Allowed values: ADDITION | DIVISION | GREATER_THAN | MASK_ALL | MASK_FIRST_N | MASK_LAST_N |
        /// MULTIPLICATION | NO_OP | PROJECTION | SUBTRACTION | VALIDATE_NON_NEGATIVE | VALIDATE_NON_NULL |
        /// VALIDATE_NON_ZERO | VALIDATE_NUMERIC
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Zendesk")]
        public Union<string, IntrinsicFunction> Zendesk { get; set; }

    }
}
