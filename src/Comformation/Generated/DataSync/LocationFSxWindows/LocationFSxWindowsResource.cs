using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.DataSync.LocationFSxWindows
{
    /// <summary>
    /// AWS::DataSync::LocationFSxWindows
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationfsxwindows.html
    /// </summary>
    public class LocationFSxWindowsResource : ResourceBase
    {
        public class LocationFSxWindowsProperties
        {
            /// <summary>
            /// Domain
            /// The name of the Windows domain that the FSx for Windows File Server belongs to.
            /// Required: No
            /// Type: String
            /// Maximum: 253
            /// Pattern: ^([A-Za-z0-9]+[A-Za-z0-9-. ]*)*[A-Za-z0-9-]*[A-Za-z0-9]$
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Domain { get; set; }

            /// <summary>
            /// FsxFilesystemArn
            /// The Amazon Resource Name (ARN) for the FSx for Windows File Server file system.
            /// Required: Yes
            /// Type: String
            /// Maximum: 128
            /// Pattern: ^arn:(aws|aws-cn|aws-us-gov|aws-iso|aws-iso-b):fsx:[a-z\-0-9]*:[0-9]{12}:file-system/fs-.
            /// *$
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> FsxFilesystemArn { get; set; }

            /// <summary>
            /// Password
            /// The password of the user who has the permissions to access files and folders in the FSx for Windows
            /// File Server file system.
            /// Required: No
            /// Type: String
            /// Maximum: 104
            /// Pattern: ^. {0,104}$
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Password { get; set; }

            /// <summary>
            /// SecurityGroupArns
            /// The Amazon Resource Names (ARNs) of the security groups that are to use to configure the FSx for
            /// Windows File Server file system.
            /// Required: Yes
            /// Type: List of String
            /// Maximum: 5
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> SecurityGroupArns { get; set; }

            /// <summary>
            /// Subdirectory
            /// A subdirectory in the location’s path. This subdirectory in the Amazon FSx for Windows File Server
            /// file system is used to read data from the Amazon FSx for Windows File Server source location or
            /// write data to the FSx for Windows File Server destination.
            /// Required: No
            /// Type: String
            /// Maximum: 4096
            /// Pattern: ^[a-zA-Z0-9_\-\+\. /\(\)\$\p{Zs}]+$
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Subdirectory { get; set; }

            /// <summary>
            /// User
            /// The user who has the permissions to access files and folders in the FSx for Windows File Server file
            /// system.
            /// Required: Yes
            /// Type: String
            /// Maximum: 104
            /// Pattern: ^[^\x5B\x5D\\/:;|=,+*?]{1,104}$
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> User { get; set; }

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

        public string Type { get; } = "AWS::DataSync::LocationFSxWindows";

        public LocationFSxWindowsProperties Properties { get; } = new LocationFSxWindowsProperties();

    }

    public static class LocationFSxWindowsAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> LocationArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("LocationArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> LocationUri = new ResourceAttribute<Union<string, IntrinsicFunction>>("LocationUri");
    }
}
