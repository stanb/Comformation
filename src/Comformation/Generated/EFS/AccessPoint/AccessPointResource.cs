using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EFS.AccessPoint
{
    /// <summary>
    /// AWS::EFS::AccessPoint
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-efs-accesspoint.html
    /// </summary>
    public class AccessPointResource : ResourceBase
    {
        public class AccessPointProperties
        {
            /// <summary>
            /// ClientToken
            /// The opaque string specified in the request to ensure idempotent creation.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 64
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ClientToken { get; set; }

            /// <summary>
            /// AccessPointTags
            /// An array of key-value pairs to apply to this resource.
            /// For more information, see Tag.
            /// Required: No
            /// Type: List of AccessPointTag
            /// Update requires: No interruption
            /// </summary>
            public List<AccessPointTag> AccessPointTags { get; set; }

            /// <summary>
            /// FileSystemId
            /// The ID of the EFS file system that the access point applies to.
            /// Required: Yes
            /// Type: String
            /// Maximum: 128
            /// Pattern:
            /// ^(arn:aws[-a-z]*:elasticfilesystem:[0-9a-z-:]+:file-system/fs-[0-9a-f]{8,40}|fs-[0-9a-f]{8,40})$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> FileSystemId { get; set; }

            /// <summary>
            /// PosixUser
            /// The full POSIX identity, including the user ID, group ID, and secondary group IDs on the access
            /// point that is used for all file operations by NFS clients using the access point.
            /// Required: No
            /// Type: PosixUser
            /// Update requires: Replacement
            /// </summary>
            public PosixUser PosixUser { get; set; }

            /// <summary>
            /// RootDirectory
            /// The directory on the Amazon EFS file system that the access point exposes as the root directory to
            /// NFS clients using the access point.
            /// Required: No
            /// Type: RootDirectory
            /// Update requires: Replacement
            /// </summary>
            public RootDirectory RootDirectory { get; set; }

        }

        public string Type { get; } = "AWS::EFS::AccessPoint";

        public AccessPointProperties Properties { get; } = new AccessPointProperties();

    }

    public static class AccessPointAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> AccessPointId = new ResourceAttribute<Union<string, IntrinsicFunction>>("AccessPointId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
