using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.DataSync.LocationSMB
{
    /// <summary>
    /// AWS::DataSync::LocationSMB
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationsmb.html
    /// </summary>
    public class LocationSMBResource : ResourceBase
    {
        public class LocationSMBProperties
        {
            /// <summary>
            /// AgentArns
            /// The Amazon Resource Names (ARNs) of agents to use for a Simple Message Block (SMB) location.
            /// Required: Yes
            /// Type: List of String
            /// Maximum: 4
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> AgentArns { get; set; }

            /// <summary>
            /// Domain
            /// The name of the Windows domain that the SMB server belongs to.
            /// Required: No
            /// Type: String
            /// Maximum: 253
            /// Pattern: ^([A-Za-z0-9]+[A-Za-z0-9-. ]*)*[A-Za-z0-9-]*[A-Za-z0-9]$
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Domain { get; set; }

            /// <summary>
            /// MountOptions
            /// The mount options used by DataSync to access the SMB server.
            /// Required: No
            /// Type: MountOptions
            /// Update requires: No interruption
            /// </summary>
            public MountOptions MountOptions { get; set; }

            /// <summary>
            /// Password
            /// The password of the user who can mount the share, has the permissions to access files and folders in
            /// the SMB share.
            /// Required: No
            /// Type: String
            /// Maximum: 104
            /// Pattern: ^. {0,104}$
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Password { get; set; }

            /// <summary>
            /// ServerHostname
            /// The name of the SMB server. This value is the IP address or Domain Name Service (DNS) name of the
            /// SMB server. An agent that is installed on-premises uses this hostname to mount the SMB server in a
            /// network.
            /// Note This name must either be DNS-compliant or must be an IP version 4 (IPv4) address.
            /// Required: Yes
            /// Type: String
            /// Maximum: 255
            /// Pattern: ^(([a-zA-Z0-9\-]*[a-zA-Z0-9])\. )*([A-Za-z0-9\-]*[A-Za-z0-9])$
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ServerHostname { get; set; }

            /// <summary>
            /// Subdirectory
            /// The subdirectory in the SMB file system that is used to read data from the SMB source location or
            /// write data to the SMB destination. The SMB path should be a path that&#39;s exported by the SMB server,
            /// or a subdirectory of that path. The path should be such that it can be mounted by other SMB clients
            /// in your network.
            /// Note Subdirectory must be specified with forward slashes. For example, /path/to/folder.
            /// To transfer all the data in the folder you specified, DataSync needs to have permissions to mount
            /// the SMB share, as well as to access all the data in that share. To ensure this, either ensure that
            /// the user/password specified belongs to the user who can mount the share, and who has the appropriate
            /// permissions for all of the files and directories that you want DataSync to access, or use
            /// credentials of a member of the Backup Operators group to mount the share. Doing either enables the
            /// agent to access the data. For the agent to access directories, you must additionally enable all
            /// execute access.
            /// Required: Yes
            /// Type: String
            /// Maximum: 4096
            /// Pattern: ^[a-zA-Z0-9_\-\+\. /\(\)\$\p{Zs}]+$
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Subdirectory { get; set; }

            /// <summary>
            /// User
            /// The user who can mount the share, has the permissions to access files and folders in the SMB share.
            /// Required: Yes
            /// Type: String
            /// Maximum: 104
            /// Pattern: ^[^\x5B\x5D\\/:;|=,+*?]{1,104}$
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> User { get; set; }

            /// <summary>
            /// Tags
            /// The key-value pair that represents the tag that you want to add to the location. The value can be an
            /// empty string. We recommend using tags to name your resources.
            /// Required: No
            /// Type: List of Tag
            /// Maximum: 50
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::DataSync::LocationSMB";

        public LocationSMBProperties Properties { get; } = new LocationSMBProperties();

    }

    public static class LocationSMBAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> LocationArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("LocationArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> LocationUri = new ResourceAttribute<Union<string, IntrinsicFunction>>("LocationUri");
    }
}
