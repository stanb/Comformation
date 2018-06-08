using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.Instance
{
    /// <summary>
    /// Amazon EC2 Block Device Mapping Property
    /// The Amazon EC2 block device mapping property is an embedded property of the AWS::EC2::Instance resource. For
    /// block device mappings for an Auto Scaling launch configuration, see Amazon EC2 Auto Scaling Block Device
    /// Mapping.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-blockdev-mapping.html
    /// </summary>
    public class BlockDeviceMapping
    {

        /// <summary>
        /// DeviceName
        /// The name of the device within Amazon EC2. For more information, see Device Naming on Linux Instances
        /// in the Amazon EC2 User Guide for Linux Instances.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("DeviceName")]
        public Union<string, IntrinsicFunction> DeviceName { get; set; }

        /// <summary>
        /// Ebs
        /// Required: Conditional You can specify either VirtualName or Ebs, but not both.
        /// Type: Amazon Elastic Block Store Block Device Property.
        /// </summary>
        [JsonProperty("Ebs")]
        public Union<Ebs, IntrinsicFunction> Ebs { get; set; }

        /// <summary>
        /// NoDevice
        /// This property can be used to unmap a defined device.
        /// Required: No
        /// Type: Boolean
        /// </summary>
        [JsonProperty("NoDevice")]
        public Union<NoDevice, IntrinsicFunction> NoDevice { get; set; }

        /// <summary>
        /// VirtualName
        /// The name of the virtual device. The name must be in the form ephemeralX where X is a number starting
        /// from zero (0); for example, ephemeral0.
        /// Required: Conditional You can specify either VirtualName or Ebs, but not both.
        /// Type: String
        /// </summary>
        [JsonProperty("VirtualName")]
        public Union<string, IntrinsicFunction> VirtualName { get; set; }

    }
}
