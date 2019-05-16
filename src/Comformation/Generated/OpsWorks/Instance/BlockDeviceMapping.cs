using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.OpsWorks.Instance
{
    /// <summary>
    /// AWS::OpsWorks::Instance BlockDeviceMapping
    /// Describes a block device mapping. This data type maps directly to the Amazon EC2 BlockDeviceMapping data type.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-instance-blockdevicemapping.html
    /// </summary>
    public class BlockDeviceMapping
    {

        /// <summary>
        /// DeviceName
        /// The device name that is exposed to the instance, such as /dev/sdh. For the root device, you can use
        /// the explicit device name or you can set this parameter to ROOT_DEVICE and AWS OpsWorks Stacks will
        /// provide the correct device name.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DeviceName")]
        public Union<string, IntrinsicFunction> DeviceName { get; set; }

        /// <summary>
        /// Ebs
        /// An EBSBlockDevice that defines how to configure an Amazon EBS volume when the instance is launched.
        /// You can specify either the VirtualName or Ebs, but not both.
        /// Required: Conditional
        /// Type: EbsBlockDevice
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Ebs")]
        public EbsBlockDevice Ebs { get; set; }

        /// <summary>
        /// NoDevice
        /// Suppresses the specified device included in the AMI&#39;s block device mapping.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NoDevice")]
        public Union<string, IntrinsicFunction> NoDevice { get; set; }

        /// <summary>
        /// VirtualName
        /// The virtual device name. For more information, see BlockDeviceMapping. You can specify either the
        /// VirtualName or Ebs, but not both.
        /// Required: Conditional
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VirtualName")]
        public Union<string, IntrinsicFunction> VirtualName { get; set; }

    }
}
