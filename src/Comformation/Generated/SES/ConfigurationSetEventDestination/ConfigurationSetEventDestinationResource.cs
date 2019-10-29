using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SES.ConfigurationSetEventDestination
{
    /// <summary>
    /// AWS::SES::ConfigurationSetEventDestination
    /// Specifies a configuration set event destination. An event destination is an AWS service that Amazon SES
    /// publishes email sending events to. When you specify an event destination, you provide one, and only one,
    /// destination. You can send event data to Amazon CloudWatch or Amazon Kinesis Data Firehose. For information
    /// about using configuration sets, see the Amazon SES Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-configurationseteventdestination.html
    /// </summary>
    public class ConfigurationSetEventDestinationResource : ResourceBase
    {
        public class ConfigurationSetEventDestinationProperties
        {
            /// <summary>
            /// ConfigurationSetName
            /// The name of the configuration set that contains the event destination that you want to update.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ConfigurationSetName { get; set; }

            /// <summary>
            /// EventDestination
            /// The event destination object that you want to apply to the specified configuration set.
            /// Required: Yes
            /// Type: EventDestination
            /// Update requires: No interruption
            /// </summary>
			public EventDestination EventDestination { get; set; }

        }

        public string Type { get; } = "AWS::SES::ConfigurationSetEventDestination";

        public ConfigurationSetEventDestinationProperties Properties { get; } = new ConfigurationSetEventDestinationProperties();

    }
}
