using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.SpotFleet
{
    /// <summary>
    /// Amazon Elastic Compute Cloud SpotFleet BlockDeviceMappings
    /// BlockDeviceMappings is a property of the Amazon Elastic Compute Cloud SpotFleet LaunchSpecifications property
    /// that defines the block devices that are mapped to an instance.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications-blockdevicemappings.html
    /// </summary>
    public class BlockDeviceMapping
    {

        /// <summary>
        /// DeviceName
        /// The name of the device within the EC2 instance, such as /dev/dsh or xvdh.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("DeviceName")]
        public Union<string, IntrinsicFunction> DeviceName { get; set; }

        /// <summary>
        /// Ebs
        /// The Amazon Elastic Block Store (Amazon EBS) volume information.
        /// Required: Conditional You can specify either the VirtualName or Ebs, but not both.
        /// Type: Amazon Elastic Compute Cloud SpotFleet Ebs
        /// </summary>
        [JsonProperty("Ebs")]
        public Union<EbsBlockDevice, IntrinsicFunction> Ebs { get; set; }

        /// <summary>
        /// NoDevice
        /// Suppresses the specified device that is included in the block device mapping of the Amazon Machine
        /// Image (AMI).
        /// Required: No
        /// Type: Boolean
        /// </summary>
        [JsonProperty("NoDevice")]
        public Union<string, IntrinsicFunction> NoDevice { get; set; }

        /// <summary>
        /// VirtualName
        /// The name of the virtual device. The name must be in the form ephemeralX where X is a number equal to
        /// or greater than zero (0), for example, ephemeral0.
        /// Required: Conditional You can specify either the VirtualName or Ebs, but not both.
        /// Type: String
        /// </summary>
        [JsonProperty("VirtualName")]
        public Union<string, IntrinsicFunction> VirtualName { get; set; }

    }
}
