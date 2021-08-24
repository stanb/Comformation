using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppIntegrations.EventIntegration
{
    /// <summary>
    /// AWS::AppIntegrations::EventIntegration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appintegrations-eventintegration.html
    /// </summary>
    public class EventIntegrationResource : ResourceBase
    {
        public class EventIntegrationProperties
        {
            /// <summary>
            /// Description
            /// The event integration description.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Name
            /// The name of the event integration.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// EventBridgeBus
            /// The Amazon EventBridge bus for the event integration.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> EventBridgeBus { get; set; }

            /// <summary>
            /// EventFilter
            /// The event integration filter.
            /// Required: Yes
            /// Type: EventFilter
            /// Update requires: Replacement
            /// </summary>
            public EventFilter EventFilter { get; set; }

            /// <summary>
            /// Tags
            /// An array of key-value pairs to apply to this resource.
            /// For more information, see Tag.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::AppIntegrations::EventIntegration";

        public EventIntegrationProperties Properties { get; } = new EventIntegrationProperties();

    }

    public static class EventIntegrationAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> EventIntegrationArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("EventIntegrationArn");
        public static readonly ResourceAttribute<List<EventIntegrationAssociation>> Associations = new ResourceAttribute<List<EventIntegrationAssociation>>("Associations");
    }
}
