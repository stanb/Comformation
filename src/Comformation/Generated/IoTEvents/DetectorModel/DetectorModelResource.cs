using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTEvents.DetectorModel
{
    /// <summary>
    /// AWS::IoTEvents::DetectorModel
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotevents-detectormodel.html
    /// </summary>
    public class DetectorModelResource : ResourceBase
    {
        public class DetectorModelProperties
        {
            /// <summary>
            /// DetectorModelDefinition
            /// Information that defines how a detector operates.
            /// Required: Yes
            /// Type: DetectorModelDefinition
            /// Update requires: No interruption
            /// </summary>
            public DetectorModelDefinition DetectorModelDefinition { get; set; }

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
            /// EvaluationMethod
            /// Information about the order in which events are evaluated and how actions are executed.
            /// Required: No
            /// Type: String
            /// Allowed values: BATCH | SERIAL
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> EvaluationMethod { get; set; }

            /// <summary>
            /// Key
            /// The value used to identify a detector instance. When a device or system sends input, a new detector
            /// instance with a unique key value is created. AWS IoT Events can continue to route input to its
            /// corresponding detector instance based on this identifying information.
            /// This parameter uses a JSON-path expression to select the attribute-value pair in the message payload
            /// that is used for identification. To route the message to the correct detector instance, the device
            /// must send a message payload that contains the same attribute-value.
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
            /// Required: Yes
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
