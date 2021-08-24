using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTEvents.Input
{
    /// <summary>
    /// AWS::IoTEvents::Input
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotevents-input.html
    /// </summary>
    public class InputResource : ResourceBase
    {
        public class InputProperties
        {
            /// <summary>
            /// InputDefinition
            /// The definition of the input.
            /// Required: Yes
            /// Type: InputDefinition
            /// Update requires: No interruption
            /// </summary>
            public InputDefinition InputDefinition { get; set; }

            /// <summary>
            /// InputDescription
            /// A brief description of the input.
            /// Required: No
            /// Type: String
            /// Maximum: 128
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> InputDescription { get; set; }

            /// <summary>
            /// InputName
            /// The name of the input.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Pattern: ^[a-zA-Z][a-zA-Z0-9_]*$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> InputName { get; set; }

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

        public string Type { get; } = "AWS::IoTEvents::Input";

        public InputProperties Properties { get; } = new InputProperties();

    }
}
