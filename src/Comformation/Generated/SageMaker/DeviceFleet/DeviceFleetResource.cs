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
            /// Not currently supported by AWS CloudFormation.
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
            /// Not currently supported by AWS CloudFormation.
            /// Required: Yes
            /// Type: EdgeOutputConfig
            /// Update requires: No interruption
            /// </summary>
            public EdgeOutputConfig OutputConfig { get; set; }

            /// <summary>
            /// RoleArn
            /// Not currently supported by AWS CloudFormation.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> RoleArn { get; set; }

            /// <summary>
            /// Tags
            /// Not currently supported by AWS CloudFormation.
            /// Required: No
            /// Type: Tag of Json
            /// Update requires: No interruption
            /// </summary>
            public Tag Tags { get; set; }

        }

        public string Type { get; } = "AWS::SageMaker::DeviceFleet";

        public DeviceFleetProperties Properties { get; } = new DeviceFleetProperties();

    }
}
