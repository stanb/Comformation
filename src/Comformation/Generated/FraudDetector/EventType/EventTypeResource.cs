using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.FraudDetector.EventType
{
    /// <summary>
    /// AWS::FraudDetector::EventType
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-frauddetector-eventtype.html
    /// </summary>
    public class EventTypeResource : ResourceBase
    {
        public class EventTypeProperties
        {
            /// <summary>
            /// Name
            /// The event type name.
            /// Pattern : ^[0-9a-z_-]+$
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Tags
            /// An array of key-value pairs to apply to this resource.
            /// For more information, see Tag.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// Description
            /// The event type description.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// EventVariables
            /// The event type event variables.
            /// Required: Yes
            /// Type: List of EventVariable
            /// Update requires: No interruption
            /// </summary>
            public List<EventVariable> EventVariables { get; set; }

            /// <summary>
            /// Labels
            /// The event type labels.
            /// Required: Yes
            /// Type: List of Label
            /// Update requires: No interruption
            /// </summary>
            public List<Label> Labels { get; set; }

            /// <summary>
            /// EntityTypes
            /// The event type entity types.
            /// Required: Yes
            /// Type: List of EntityType
            /// Update requires: No interruption
            /// </summary>
            public List<EntityType> EntityTypes { get; set; }

        }

        public string Type { get; } = "AWS::FraudDetector::EventType";

        public EventTypeProperties Properties { get; } = new EventTypeProperties();

    }

    public static class EventTypeAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CreatedTime = new ResourceAttribute<Union<string, IntrinsicFunction>>("CreatedTime");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> LastUpdatedTime = new ResourceAttribute<Union<string, IntrinsicFunction>>("LastUpdatedTime");
    }
}
