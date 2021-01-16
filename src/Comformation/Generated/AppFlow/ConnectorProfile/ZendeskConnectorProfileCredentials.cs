using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppFlow.ConnectorProfile
{
    /// <summary>
    /// AWS::AppFlow::ConnectorProfile ZendeskConnectorProfileCredentials
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-zendeskconnectorprofilecredentials.html
    /// </summary>
    public class ZendeskConnectorProfileCredentials
    {

        /// <summary>
        /// ClientId
        /// The identifier for the desired client.
        /// Required: Yes
        /// Type: String
        /// Maximum: 512
        /// Pattern: \S+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ClientId")]
        public Union<string, IntrinsicFunction> ClientId { get; set; }

        /// <summary>
        /// ClientSecret
        /// The client secret used by the OAuth client to authenticate to the authorization server.
        /// Required: Yes
        /// Type: String
        /// Maximum: 512
        /// Pattern: \S+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ClientSecret")]
        public Union<string, IntrinsicFunction> ClientSecret { get; set; }

        /// <summary>
        /// AccessToken
        /// The credentials used to access protected Zendesk resources.
        /// Required: No
        /// Type: String
        /// Maximum: 512
        /// Pattern: \S+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AccessToken")]
        public Union<string, IntrinsicFunction> AccessToken { get; set; }

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

    }
}
