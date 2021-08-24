using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.Device
{
    /// <summary>
    /// AWS::SageMaker::Device
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-device.html
    /// </summary>
    public class DeviceResource : ResourceBase
    {
        public class DeviceProperties
        {
            /// <summary>
            /// DeviceFleetName
            /// The name of the fleet the device belongs to.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 63
            /// Pattern: ^[a-zA-Z0-9](-*[a-zA-Z0-9]){0,62}$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DeviceFleetName { get; set; }

            /// <summary>
            /// Device
            /// Edge device you want to create.
            /// Required: No
            /// Type: Device
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Device { get; set; }

            /// <summary>
            /// Tags
            /// An array of key-value pairs that contain metadata to help you categorize and organize your devices.
            /// Each tag consists of a key and a value, both of which you define.
            /// Required: No
            /// Type: List of Tag
            /// Maximum: 50
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::SageMaker::Device";

        public DeviceProperties Properties { get; } = new DeviceProperties();

    }
}
