using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.Instance
{
    /// <summary>
    /// AWS::EC2::Instance BlockDeviceMapping
    /// Specifies a block device mapping for an instance.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-blockdev-mapping.html
    /// </summary>
    public class BlockDeviceMapping
    {

        /// <summary>
        /// DeviceName
        /// The device name (for example, /dev/sdh or xvdh).
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DeviceName")]
        public Union<string, IntrinsicFunction> DeviceName { get; set; }

        /// <summary>
        /// Ebs
        /// 		
        /// Parameters used to automatically set up EBS volumes when the instance is 			launched.
        /// 		
        /// You can specify either VirtualName or Ebs, but 			not both.
        /// 	
        /// Required: Conditional
        /// Type: Ebs
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Ebs")]
        public Ebs Ebs { get; set; }

        /// <summary>
        /// NoDevice
        /// Suppresses the specified device included in the block device mapping of the AMI.
        /// Required: No
        /// Type: NoDevice
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NoDevice")]
        public NoDevice NoDevice { get; set; }

        /// <summary>
        /// VirtualName
        /// 		
        /// The virtual device name (ephemeralN). The name must be in the form 			ephemeralX where X 			is a
        /// number starting from zero (0). For example, an instance type with 2 available 			instance store
        /// volumes can specify mappings for ephemeral0 and 			ephemeral1. The number of available instance
        /// store volumes depends on 			the instance type. After you connect to the instance, you must mount the
        /// volume.
        /// 		
        /// NVMe instance store volumes are automatically enumerated and assigned a device name. 			Including
        /// them in your block device mapping has no effect.
        /// 		
        /// You can specify either VirtualName or Ebs, but not both.
        /// 		
        /// 			Constraints: For M3 instances, you must specify instance store volumes in the block 			device
        /// mapping for the instance. When you launch an M3 instance, we ignore any instance 			store volumes
        /// specified in the block device mapping for the AMI.
        /// 	
        /// Required: Conditional
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VirtualName")]
        public Union<string, IntrinsicFunction> VirtualName { get; set; }

    }
}
