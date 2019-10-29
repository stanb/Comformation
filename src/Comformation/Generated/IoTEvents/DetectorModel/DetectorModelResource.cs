using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTEvents.DetectorModel
{
    /// <summary>
    /// AWS::IoTEvents::DetectorModel
    /// The AWS::IoTEvents::DetectorModel resource creates a detector model. You create a detector model (a model of
    /// your equipment or process) using states. For each state, you define conditional (Boolean) logic that evaluates
    /// the incoming inputs to detect significant events. When an event is detected, it can change the state or
    /// trigger custom-built or predefined actions using other AWS services. You can define additional events that
    /// trigger actions when entering or exiting a state and, optionally, when a condition is met. For more
    /// information, see How to Use AWS IoT Events in the AWS IoT Events Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotevents-detectormodel.html
    /// </summary>
    public class DetectorModelResource : ResourceBase
    {
        public class DetectorModelProperties
        {
            /// <summary>
            /// DetectorModelDefinition
            /// Information that defines how a detector operates.
            /// Required: No
            /// Type: DetectorModelDefinition
            /// Update requires: No interruption
            /// </summary>
			public DetectorModelDefinition DetectorModelDefinition { get; set; }

            /// <summary>
            /// DetectorModelName
            /// The name of the detector model.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Pattern: ^[a-zA-Z0-9_-]+$
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DetectorModelName { get; set; }

            /// <summary>
            /// DetectorModelDescription
            /// A brief description of the detector model.
            /// Required: No
            /// Type: String
            /// Maximum: 128
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> DetectorModelDescription { get; set; }

            /// <summary>
            /// Key
            /// The input attribute key used to identify a device or system to create a detector (an instance of the
            /// detector model) and then to route each input received to the appropriate detector (instance). This
            /// parameter uses a JSON-path expression to specify the attribute-value pair in the message payload of
            /// each input that is used to identify the device associated with the input.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Pattern: ^((`[\w\- ]+`)|([\w\-]+))(\. ((`[\w- ]+`)|([\w\-]+)))*$
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Key { get; set; }

            /// <summary>
            /// RoleArn
            /// The ARN of the role that grants permission to AWS IoT Events to perform its operations.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 2048
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> RoleArn { get; set; }

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

        public string Type { get; } = "AWS::IoTEvents::DetectorModel";

        public DetectorModelProperties Properties { get; } = new DetectorModelProperties();

    }
}
