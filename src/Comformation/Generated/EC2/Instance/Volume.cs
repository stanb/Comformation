using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.Instance
{
    /// <summary>
    /// EC2 MountPoint Property Type
    /// The EC2 MountPoint property is an embedded property of the AWS::EC2::Instance type.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-mount-point.html
    /// </summary>
    public class Volume
    {

        /// <summary>
        /// Device
        /// How the device is exposed to the instance (such as /dev/sdh, or xvdh).
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Device")]
        public Union<string, IntrinsicFunction> Device { get; set; }

        /// <summary>
        /// VolumeId
        /// The ID of the Amazon EBS volume. The volume and instance must be within the same Availability Zone
        /// and the instance must be running.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("VolumeId")]
        public Union<string, IntrinsicFunction> VolumeId { get; set; }

    }
}
