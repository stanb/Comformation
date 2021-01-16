using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.DataSync.LocationEFS
{
    /// <summary>
    /// AWS::DataSync::LocationEFS
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationefs.html
    /// </summary>
    public class LocationEFSResource : ResourceBase
    {
        public class LocationEFSProperties
        {
            /// <summary>
            /// Ec2Config
            /// </summary>
            public Ec2Config Ec2Config { get; set; }

            /// <summary>
            /// EfsFilesystemArn
            /// The Amazon Resource Name (ARN) for the Amazon EFS file system.
            /// Required: Yes
            /// Type: String
            /// Maximum: 128
            /// Pattern:
            /// ^arn:(aws|aws-cn|aws-us-gov|aws-iso|aws-iso-b):elasticfilesystem:[a-z\-0-9]*:[0-9]{12}:file-system/fs-.
            /// *$
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> EfsFilesystemArn { get; set; }

            /// <summary>
            /// Subdirectory
            /// A subdirectory in the location’s path. This subdirectory in the EFS file system is used to read data
            /// from the EFS source location or write data to the EFS destination. By default, AWS DataSync uses the
            /// root directory.
            /// Note Subdirectory must be specified with forward slashes. For example, /path/to/folder.
            /// Required: No
            /// Type: String
            /// Maximum: 4096
            /// Pattern: ^[a-zA-Z0-9_\-\+\. /\(\)\p{Zs}]*$
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Subdirectory { get; set; }

            /// <summary>
            /// Tags
            /// The key-value pair that represents a tag that you want to add to the resource. The value can be an
            /// empty string. This value helps you manage, filter, and search for your resources. We recommend that
            /// you create a name tag for your location.
            /// Required: No
            /// Type: List of Tag
            /// Maximum: 50
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::DataSync::LocationEFS";

        public LocationEFSProperties Properties { get; } = new LocationEFSProperties();

    }

    public static class LocationEFSAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> LocationArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("LocationArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> LocationUri = new ResourceAttribute<Union<string, IntrinsicFunction>>("LocationUri");
    }
}
