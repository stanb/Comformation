using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.DataSync.LocationNFS
{
    /// <summary>
    /// AWS::DataSync::LocationNFS
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationnfs.html
    /// </summary>
    public class LocationNFSResource : ResourceBase
    {
        public class LocationNFSProperties
        {
            /// <summary>
            /// MountOptions
            /// The NFS mount options that DataSync can use to mount your NFS share.
            /// Required: No
            /// Type: MountOptions
            /// Update requires: No interruption
            /// </summary>
            public MountOptions MountOptions { get; set; }

            /// <summary>
            /// OnPremConfig
            /// Contains a list of Amazon Resource Names (ARNs) of agents that are used to connect to an NFS server.
            /// If you are copying data to or from your AWS Snowcone device, see NFS Server on AWS Snowcone for more
            /// information.
            /// Required: Yes
            /// Type: OnPremConfig
            /// Update requires: No interruption
            /// </summary>
            public OnPremConfig OnPremConfig { get; set; }

            /// <summary>
            /// ServerHostname
            /// The name of the NFS server. This value is the IP address or Domain Name Service (DNS) name of the
            /// NFS server. An agent that is installed on-premises uses this host name to mount the NFS server in a
            /// network.
            /// If you are copying data to or from your AWS Snowcone device, see NFS Server on AWS Snowcone for more
            /// information.
            /// Note This name must either be DNS-compliant or must be an IP version 4 (IPv4) address.
            /// Required: Yes
            /// Type: String
            /// Maximum: 255
            /// Pattern: ^(([a-zA-Z0-9\-]*[a-zA-Z0-9])\. )*([A-Za-z0-9\-]*[A-Za-z0-9])$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ServerHostname { get; set; }

            /// <summary>
            /// Subdirectory
            /// The subdirectory in the NFS file system that is used to read data from the NFS source location or
            /// write data to the NFS destination. The NFS path should be a path that&#39;s exported by the NFS server,
            /// or a subdirectory of that path. The path should be such that it can be mounted by other NFS clients
            /// in your network.
            /// To see all the paths exported by your NFS server, run &quot;showmount -e nfs-server-name&quot; from an NFS
            /// client that has access to your server. You can specify any directory that appears in the results,
            /// and any subdirectory of that directory. Ensure that the NFS export is accessible without Kerberos
            /// authentication.
            /// To transfer all the data in the folder you specified, DataSync needs to have permissions to read all
            /// the data. To ensure this, either configure the NFS export with no_root_squash, or ensure that the
            /// permissions for all of the files that you want DataSync allow read access for all users. Doing
            /// either enables the agent to read the files. For the agent to access directories, you must
            /// additionally enable all execute access.
            /// If you are copying data to or from your AWS Snowcone device, see NFS Server on AWS Snowcone for more
            /// information.
            /// For information about NFS export configuration, see 18. 7. The /etc/exports Configuration File in
            /// the Red Hat Enterprise Linux documentation.
            /// Required: Yes
            /// Type: String
            /// Maximum: 4096
            /// Pattern: ^[a-zA-Z0-9_\-\+\. /\(\)\p{Zs}]+$
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Subdirectory { get; set; }

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

        public string Type { get; } = "AWS::DataSync::LocationNFS";

        public LocationNFSProperties Properties { get; } = new LocationNFSProperties();

    }

    public static class LocationNFSAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> LocationArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("LocationArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> LocationUri = new ResourceAttribute<Union<string, IntrinsicFunction>>("LocationUri");
    }
}
