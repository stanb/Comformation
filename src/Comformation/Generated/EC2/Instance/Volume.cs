using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.Instance
{
    /// <summary>
    /// AWS::EC2::Instance Volume
    /// Specifies a volume to attach to an instance.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-mount-point.html
    /// </summary>
    public class Volume
    {

        /// <summary>
        /// Device
        /// The device name (for example, /dev/sdh or xvdh).
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Device")]
        public Union<string, IntrinsicFunction> Device { get; set; }

        /// <summary>
        /// VolumeId
        /// The ID of the EBS volume. The volume and instance must be within the same Availability Zone.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VolumeId")]
        public Union<string, IntrinsicFunction> VolumeId { get; set; }

    }
}
