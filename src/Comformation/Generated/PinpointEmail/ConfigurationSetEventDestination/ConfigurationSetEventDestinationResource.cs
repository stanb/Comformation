using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.PinpointEmail.ConfigurationSetEventDestination
{
    /// <summary>
    /// AWS::PinpointEmail::ConfigurationSetEventDestination
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
