using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SES.ConfigurationSetEventDestination
{
    /// <summary>
    /// AWS::SES::ConfigurationSetEventDestination
    /// The AWS::SES::ConfigurationSetEventDestination resource specifies a configuration set event destination for
    /// Amazon SES. For more information, see CreateConfigurationSetEventDestination in the Amazon Simple Email
    /// Service API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-configurationseteventdestination.html
    /// </summary>
    public class ConfigurationSetEventDestinationResource : ResourceBase
    {
        public class ConfigurationSetEventDestinationProperties
        {
            /// <summary>
            /// ConfigurationSetName
            /// The name of the configuration set that the event destination should be associated with.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ConfigurationSetName { get; set; }

            /// <summary>
            /// EventDestination
            /// The AWS service that email sending event information will be published to.
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
