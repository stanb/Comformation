using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.OpsWorks.Layer
{
    /// <summary>
    /// AWS::OpsWorks::Layer VolumeConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-layer-volumeconfiguration.html
    /// </summary>
    public class VolumeConfiguration
    {

        /// <summary>
        /// Encrypted
        /// Specifies whether an Amazon EBS volume is encrypted. For more information, see Amazon EBS
        /// Encryption.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Encrypted")]
        public Union<bool, IntrinsicFunction> Encrypted { get; set; }

        /// <summary>
        /// Iops
        /// The number of I/O operations per second (IOPS) to provision for the volume. For PIOPS volumes, the
        /// IOPS per disk.
        /// If you specify io1 for the volume type, you must specify this property.
        /// Required: Conditional
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Iops")]
        public Union<int, IntrinsicFunction> Iops { get; set; }

        /// <summary>
        /// MountPoint
        /// The volume mount point. For example &quot;/dev/sdh&quot;.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MountPoint")]
        public Union<string, IntrinsicFunction> MountPoint { get; set; }

        /// <summary>
        /// NumberOfDisks
        /// The number of disks in the volume.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NumberOfDisks")]
        public Union<int, IntrinsicFunction> NumberOfDisks { get; set; }

        /// <summary>
        /// RaidLevel
        /// The volume RAID level.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RaidLevel")]
        public Union<int, IntrinsicFunction> RaidLevel { get; set; }

        /// <summary>
        /// Size
        /// The volume size.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Size")]
        public Union<int, IntrinsicFunction> Size { get; set; }

        /// <summary>
        /// VolumeType
        /// The volume type. For more information, see Amazon EBS Volume Types.
        /// standard - Magnetic. Magnetic volumes must have a minimum size of 1 GiB and a maximum size of 1024
        /// GiB. io1 - Provisioned IOPS (SSD). PIOPS volumes must have a minimum size of 4 GiB and a maximum
        /// size of 16384 GiB. gp2 - General Purpose (SSD). General purpose volumes must have a minimum size of
        /// 1 GiB and a maximum size of 16384 GiB. st1 - Throughput Optimized hard disk drive (HDD). Throughput
        /// optimized HDD volumes must have a minimum size of 500 GiB and a maximum size of 16384 GiB. sc1 -
        /// Cold HDD. Cold HDD volumes must have a minimum size of 500 GiB and a maximum size of 16384 GiB.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VolumeType")]
        public Union<string, IntrinsicFunction> VolumeType { get; set; }

    }
}
