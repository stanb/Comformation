using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppIntegrations.EventIntegration
{
    /// <summary>
    /// AWS::AppIntegrations::EventIntegration EventIntegrationAssociation
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appintegrations-eventintegration-eventintegrationassociation.html
    /// </summary>
    public class EventIntegrationAssociation
    {

        /// <summary>
        /// ClientAssociationMetadata
        /// The metadata associated with the client.
        /// Required: No
        /// Type: List of Metadata
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ClientAssociationMetadata")]
        public List<Metadata> ClientAssociationMetadata { get; set; }

        /// <summary>
        /// ClientId
        /// The identifier for the client that is associated with the event integration.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ClientId")]
        public Union<string, IntrinsicFunction> ClientId { get; set; }

        /// <summary>
        /// EventBridgeRuleName
        /// The name of the EventBridge rule.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EventBridgeRuleName")]
        public Union<string, IntrinsicFunction> EventBridgeRuleName { get; set; }

        /// <summary>
        /// EventIntegrationAssociationArn
        /// The Amazon Resource Name (ARN) for the event integration association.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EventIntegrationAssociationArn")]
        public Union<string, IntrinsicFunction> EventIntegrationAssociationArn { get; set; }

        /// <summary>
        /// EventIntegrationAssociationId
        /// The identifier for the event integration association.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EventIntegrationAssociationId")]
        public Union<string, IntrinsicFunction> EventIntegrationAssociationId { get; set; }

    }
}
