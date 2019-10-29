using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.PinpointEmail.ConfigurationSetEventDestination
{
    /// <summary>
    /// AWS::PinpointEmail::ConfigurationSetEventDestination
    /// Create an event destination. In Amazon Pinpoint, events include message sends, deliveries, opens, clicks,
    /// bounces, and complaints. Event destinations are places that you can send information about these events to.
    /// For example, you can send event data to Amazon SNS to receive notifications when you receive bounces or
    /// complaints, or you can use Amazon Kinesis Data Firehose to stream data to Amazon S3 for long-term storage.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpointemail-configurationseteventdestination.html
    /// </summary>
    public class ConfigurationSetEventDestinationResource : ResourceBase
    {
        public class ConfigurationSetEventDestinationProperties
        {
            /// <summary>
            /// EventDestinationName
            /// The name of the event destination that you want to modify.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> EventDestinationName { get; set; }

            /// <summary>
            /// ConfigurationSetName
            /// The name of the configuration set that contains the event destination that you want to modify.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ConfigurationSetName { get; set; }

            /// <summary>
            /// EventDestination
            /// An object that defines the event destination.
            /// Required: No
            /// Type: EventDestination
            /// Update requires: No interruption
            /// </summary>
			public EventDestination EventDestination { get; set; }

        }

        public string Type { get; } = "AWS::PinpointEmail::ConfigurationSetEventDestination";

        public ConfigurationSetEventDestinationProperties Properties { get; } = new ConfigurationSetEventDestinationProperties();

    }
}
