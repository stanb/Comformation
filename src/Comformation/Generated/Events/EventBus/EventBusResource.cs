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
            /// The name of the partner event source to associate with this event bus, if you are creating a partner
            /// event bus.
            /// Required: Conditional
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> EventSourceName { get; set; }

            /// <summary>
            /// Name
            /// The name of the event bus you are creating. The names of custom event buses can&#39;t contain the /
            /// character. You can&#39;t use the name default for a custom event bus.
            /// If you are creating a partner event bus, this name must exactly match the name of the partner event
            /// source that this bus is matched to.
            /// Required: Yes
            /// Type: String
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
