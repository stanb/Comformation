using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Events.EventBus
{
    /// <summary>
    /// AWS::Events::EventBus
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-events-eventbus.html
    /// </summary>
    public class EventBusResource : ResourceBase
    {
        public class EventBusProperties
        {
            /// <summary>
            /// EventSourceName
            /// If you are creating a partner event bus, this specifies the partner event source that the new event
            /// bus will be matched with.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 256
            /// Pattern: aws\. partner(/[\. \-_A-Za-z0-9]+){2,}
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> EventSourceName { get; set; }

            /// <summary>
            /// Name
            /// The name of the new event bus.
            /// Event bus names cannot contain the / character. You can&#39;t use the name default for a custom event
            /// bus, as this name is already used for your account&#39;s default event bus.
            /// If this is a partner event bus, the name must exactly match the name of the partner event source
            /// that this event bus is matched to.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 256
            /// Pattern: [/\. \-_A-Za-z0-9]+
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::Events::EventBus";

        public EventBusProperties Properties { get; } = new EventBusProperties();

    }

    public static class EventBusAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Policy = new ResourceAttribute<Union<string, IntrinsicFunction>>("Policy");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Name = new ResourceAttribute<Union<string, IntrinsicFunction>>("Name");
    }
}
