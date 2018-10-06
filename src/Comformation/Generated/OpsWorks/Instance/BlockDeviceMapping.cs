using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.OpsWorks.Instance
{
    /// <summary>
    /// AWS OpsWorks Instance BlockDeviceMapping
    /// BlockDeviceMappings is a property of the AWS::OpsWorks::Instance resource that defines the block devices that
    /// are mapped to an AWS OpsWorks instance.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-instance-blockdevicemapping.html
    /// </summary>
    public class BlockDeviceMapping
    {

        /// <summary>
        /// DeviceName
        /// The name of the device that is exposed to the instance, such as /dev/dsh or xvdh. For the root
        /// device, you can use the explicit device name or you can set this parameter to ROOT_DEVICE. If you
        /// set the parameter to ROOT_DEVICE, AWS OpsWorks provides the correct device name.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("DeviceName")]
        public Union<string, IntrinsicFunction> DeviceName { get; set; }

        /// <summary>
        /// Ebs
        /// Configuration information about the Amazon Elastic Block Store (Amazon EBS) volume.
        /// Required: Conditional You can specify either the VirtualName or Ebs, but not both.
        /// Type: AWS OpsWorks Instance BlockDeviceMapping EbsBlockDevice
        /// </summary>
        [JsonProperty("Ebs")]
        public EbsBlockDevice Ebs { get; set; }

        /// <summary>
        /// NoDevice
        /// Suppresses the device that is specified in the block device mapping of the AWS OpsWorks instance
        /// Amazon Machine Image (AMI).
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("NoDevice")]
        public Union<string, IntrinsicFunction> NoDevice { get; set; }

        /// <summary>
        /// VirtualName
        /// The name of the virtual device. The name must be in the form ephemeralX, where X is a number equal
        /// to or greater than zero (0), for example, ephemeral0.
        /// Required: Conditional You can specify either the VirtualName or Ebs, but not both.
        /// Type: String
        /// </summary>
        [JsonProperty("VirtualName")]
        public Union<string, IntrinsicFunction> VirtualName { get; set; }

    }
}
