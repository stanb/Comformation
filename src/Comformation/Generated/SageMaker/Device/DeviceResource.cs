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
            /// Not currently supported by AWS CloudFormation.
            /// Required: No
            /// Type: Device
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Device { get; set; }

            /// <summary>
            /// Tags
            /// Not currently supported by AWS CloudFormation.
            /// Required: No
            /// Type: Tag of Json
            /// Update requires: No interruption
            /// </summary>
            public Tag Tags { get; set; }

        }

        public string Type { get; } = "AWS::SageMaker::Device";

        public DeviceProperties Properties { get; } = new DeviceProperties();

    }
}
