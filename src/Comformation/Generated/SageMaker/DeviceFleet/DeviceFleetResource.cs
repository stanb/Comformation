using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.DeviceFleet
{
    /// <summary>
    /// AWS::SageMaker::DeviceFleet
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-devicefleet.html
    /// </summary>
    public class DeviceFleetResource : ResourceBase
    {
        public class DeviceFleetProperties
        {
            /// <summary>
            /// Description
            /// A description of the fleet.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// DeviceFleetName
            /// Name of the device fleet.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 63
            /// Pattern: ^[a-zA-Z0-9](-*[a-zA-Z0-9]){0,62}$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DeviceFleetName { get; set; }

            /// <summary>
            /// OutputConfig
            /// The output configuration for storing sample data collected by the fleet.
            /// Required: Yes
            /// Type: EdgeOutputConfig
            /// Update requires: No interruption
            /// </summary>
            public EdgeOutputConfig OutputConfig { get; set; }

            /// <summary>
            /// RoleArn
            /// The Amazon Resource Name (ARN) that has access to AWS Internet of Things (IoT).
            /// Required: Yes
            /// Type: String
            /// Minimum: 20
            /// Maximum: 2048
            /// Pattern: ^arn:aws[a-z\-]*:iam::\d{12}:role/?[a-zA-Z_0-9+=,. @\-_/]+$
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> RoleArn { get; set; }

            /// <summary>
            /// Tags
            /// An array of key-value pairs that contain metadata to help you categorize and organize your device
            /// fleets. Each tag consists of a key and a value, both of which you define.
            /// Required: No
            /// Type: List of Tag
            /// Maximum: 50
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::SageMaker::DeviceFleet";

        public DeviceFleetProperties Properties { get; } = new DeviceFleetProperties();

    }
}
