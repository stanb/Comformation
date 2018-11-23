using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.OpsWorks.Layer
{
    /// <summary>
    /// AWS OpsWorks VolumeConfiguration
    /// Describes the Amazon EBS volumes for the AWS::OpsWorks::Layer resource type.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-layer-volumeconfig.html
    /// </summary>
    public class VolumeConfiguration
    {

        /// <summary>
        /// Encrypted
        /// Specifies whether an Amazon EBS volume is encrypted.
        /// Required: No
        /// Type: Boolean
        /// </summary>
        [JsonProperty("Encrypted")]
        public Union<bool, IntrinsicFunction> Encrypted { get; set; }

        /// <summary>
        /// Iops
        /// The number of I/O operations per second (IOPS) to provision for the volume.
        /// Required: Conditional. If you specify io1 for the volume type, you must specify this property.
        /// Type: Integer
        /// </summary>
        [JsonProperty("Iops")]
        public Union<int, IntrinsicFunction> Iops { get; set; }

        /// <summary>
        /// MountPoint
        /// The volume mount point, such as /dev/sdh.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("MountPoint")]
        public Union<string, IntrinsicFunction> MountPoint { get; set; }

        /// <summary>
        /// NumberOfDisks
        /// The number of disks in the volume.
        /// Required: Yes
        /// Type: Integer
        /// </summary>
        [JsonProperty("NumberOfDisks")]
        public Union<int, IntrinsicFunction> NumberOfDisks { get; set; }

        /// <summary>
        /// RaidLevel
        /// The volume RAID level.
        /// Required: No
        /// Type: Integer
        /// </summary>
        [JsonProperty("RaidLevel")]
        public Union<int, IntrinsicFunction> RaidLevel { get; set; }

        /// <summary>
        /// Size
        /// The volume size.
        /// Required: Yes
        /// Type: Integer
        /// </summary>
        [JsonProperty("Size")]
        public Union<int, IntrinsicFunction> Size { get; set; }

        /// <summary>
        /// VolumeType
        /// The type of volume, such as magnetic or SSD. For valid values, see VolumeConfiguration in the AWS
        /// OpsWorks Stacks API Reference.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("VolumeType")]
        public Union<string, IntrinsicFunction> VolumeType { get; set; }

    }
}
