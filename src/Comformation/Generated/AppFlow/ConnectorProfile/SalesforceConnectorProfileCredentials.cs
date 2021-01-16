using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppFlow.ConnectorProfile
{
    /// <summary>
    /// AWS::AppFlow::ConnectorProfile SalesforceConnectorProfileCredentials
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-salesforceconnectorprofilecredentials.html
    /// </summary>
    public class SalesforceConnectorProfileCredentials
    {

        /// <summary>
        /// AccessToken
        /// The credentials used to access protected Salesforce resources.
        /// Required: No
        /// Type: String
        /// Maximum: 512
        /// Pattern: \S+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AccessToken")]
        public Union<string, IntrinsicFunction> AccessToken { get; set; }

        /// <summary>
        /// RefreshToken
        /// The credentials used to acquire new access tokens.
        /// Required: No
        /// Type: String
        /// Maximum: 512
        /// Pattern: \S+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RefreshToken")]
        public Union<string, IntrinsicFunction> RefreshToken { get; set; }

        /// <summary>
        /// ConnectorOAuthRequest
        /// Used by select connectors for which the OAuth workflow is supported, such as Salesforce, Google
        /// Analytics, Marketo, Zendesk, and Slack.
        /// Required: No
        /// Type: ConnectorOAuthRequest
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ConnectorOAuthRequest")]
        public ConnectorOAuthRequest ConnectorOAuthRequest { get; set; }

        /// <summary>
        /// ClientCredentialsArn
        /// The secret manager ARN, which contains the client ID and client secret of the connected app.
        /// Required: No
        /// Type: String
        /// Minimum: 20
        /// Maximum: 2048
        /// Pattern: arn:aws:secretsmanager:. *:[0-9]+:. *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ClientCredentialsArn")]
        public Union<string, IntrinsicFunction> ClientCredentialsArn { get; set; }

    }
}
