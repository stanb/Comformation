using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScaling.LaunchConfiguration
{
    /// <summary>
    /// AWS::AutoScaling::LaunchConfiguration BlockDeviceMapping
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig-blockdev-mapping.html
    /// </summary>
    public class BlockDeviceMapping
    {

        /// <summary>
        /// DeviceName
        /// The device name exposed to the EC2 instance (for example, /dev/sdh or xvdh). For more information,
        /// see Device naming on Linux instances in the Amazon EC2 User Guide for Linux Instances.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DeviceName")]
        public Union<string, IntrinsicFunction> DeviceName { get; set; }

        /// <summary>
        /// Ebs
        /// Parameters used to automatically set up EBS volumes when an instance is launched.
        /// You can specify either VirtualName or Ebs, but not both.
        /// Required: No
        /// Type: BlockDevice
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Ebs")]
        public BlockDevice Ebs { get; set; }

        /// <summary>
        /// NoDevice
        /// Setting this value to true suppresses the specified device included in the block device mapping of
        /// the AMI.
        /// If NoDevice is true for the root device, instances might fail the EC2 health check. In that case,
        /// Amazon EC2 Auto Scaling launches replacement instances.
        /// If you specify NoDevice, you cannot specify Ebs.
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
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VirtualName")]
        public Union<string, IntrinsicFunction> VirtualName { get; set; }

    }
}
