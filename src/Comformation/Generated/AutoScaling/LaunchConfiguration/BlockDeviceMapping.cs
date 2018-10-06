using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScaling.LaunchConfiguration
{
    /// <summary>
    /// Amazon EC2 Auto Scaling Block Device Mapping Property Type
    /// The AutoScaling Block Device Mapping type is an embedded property of the AWS::AutoScaling::LaunchConfiguration
    /// type.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig-blockdev-mapping.html
    /// </summary>
    public class BlockDeviceMapping
    {

        /// <summary>
        /// DeviceName
        /// The name of the device within Amazon EC2.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("DeviceName")]
        public Union<string, IntrinsicFunction> DeviceName { get; set; }

        /// <summary>
        /// Ebs
        /// The Amazon Elastic Block Store volume information.
        /// Required: Conditional You can specify either VirtualName or Ebs, but not both.
        /// Type: Amazon EC2 Auto Scaling EBS Block Device.
        /// </summary>
        [JsonProperty("Ebs")]
        public BlockDevice Ebs { get; set; }

        /// <summary>
        /// NoDevice
        /// Suppresses the device mapping. If NoDevice is set to true for the root device, the instance might
        /// fail the Amazon EC2 health check. Auto Scaling launches a replacement instance if the instance fails
        /// the health check.
        /// Required: No
        /// Type: Boolean
        /// </summary>
        [JsonProperty("NoDevice")]
        public Union<bool, IntrinsicFunction> NoDevice { get; set; }

        /// <summary>
        /// VirtualName
        /// The name of the virtual device. The name must be in the form ephemeralX where X is a number starting
        /// from zero (0), for example, ephemeral0.
        /// Required: Conditional You can specify either VirtualName or Ebs, but not both.
        /// Type: String
        /// </summary>
        [JsonProperty("VirtualName")]
        public Union<string, IntrinsicFunction> VirtualName { get; set; }

    }
}
