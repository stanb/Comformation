using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.OpsWorks.Volume
{
    /// <summary>
    /// AWS::OpsWorks::Volume
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-volume.html
    /// </summary>
    public class VolumeResource : ResourceBase
    {
        public class VolumeProperties
        {
            /// <summary>
            /// Ec2VolumeId
            /// The Amazon EC2 volume ID.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Ec2VolumeId { get; set; }

            /// <summary>
            /// MountPoint
            /// The volume mount point. For example, &quot;/mnt/disk1&quot;.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> MountPoint { get; set; }

            /// <summary>
            /// Name
            /// The volume name.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// StackId
            /// The stack ID.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> StackId { get; set; }

        }

        public string Type { get; } = "AWS::OpsWorks::Volume";

        public VolumeProperties Properties { get; } = new VolumeProperties();

    }
}
