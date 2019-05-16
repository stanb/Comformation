using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScaling.LaunchConfiguration
{
    /// <summary>
    /// AWS::AutoScaling::LaunchConfiguration BlockDeviceMapping
    /// BlockDeviceMapping is a property of LaunchConfiguration that describes a block device mapping for an Amazon
    /// EC2 Auto Scaling group.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig-blockdev-mapping.html
    /// </summary>
    public class BlockDeviceMapping
    {

        /// <summary>
        /// DeviceName
        /// The device name exposed to the EC2 instance (for example, /dev/sdh or xvdh). For more information,
        /// see Device Naming on Linux Instances in the Amazon EC2 User Guide for Linux Instances.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 255
        /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DeviceName")]
        public Union<string, IntrinsicFunction> DeviceName { get; set; }

        /// <summary>
        /// Ebs
        /// The information about the Amazon EBS volume.
        /// You can specify either VirtualName or Ebs, but not both.
        /// Required: No
        /// Type: BlockDevice
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Ebs")]
        public BlockDevice Ebs { get; set; }

        /// <summary>
        /// NoDevice
        /// Suppresses the device mapping. If this property is set to true for the root device, the instance
        /// might fail the Amazon EC2 health check. Amazon EC2 Auto Scaling launches a replacement instance if
        /// the instance fails the health check.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NoDevice")]
        public Union<bool, IntrinsicFunction> NoDevice { get; set; }

        /// <summary>
        /// VirtualName
        /// The name of the virtual device. The name must be in the form ephemeralX where X is a number starting
        /// from zero (0), for example, ephemeral0.
        /// You can specify either VirtualName or Ebs, but not both.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 255
        /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VirtualName")]
        public Union<string, IntrinsicFunction> VirtualName { get; set; }

    }
}
