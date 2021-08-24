using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Transfer.User
{
    /// <summary>
    /// AWS::Transfer::User
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-user.html
    /// </summary>
    public class UserResource : ResourceBase
    {
        public class UserProperties
        {
            /// <summary>
            /// Policy
            /// A session policy for your user so you can use the same IAM role across multiple users. This policy
            /// restricts user access to portions of their Amazon S3 bucket. Variables that you can use inside this
            /// policy include ${Transfer:UserName}, ${Transfer:HomeDirectory}, and ${Transfer:HomeBucket}.
            /// Note For session policies, AWS Transfer Family stores the policy as a JSON blob, instead of the
            /// Amazon Resource Name (ARN) of the policy. You save the policy as a JSON blob and pass it in the
            /// Policy argument. For an example of a session policy, see Example session policy. For more
            /// information, see AssumeRole in the AWS Security Token Service API Reference.
            /// Required: No
            /// Type: String
            /// Maximum: 2048
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Policy { get; set; }

            /// <summary>
            /// Role
            /// Specifies the Amazon Resource Name (ARN) of the IAM role that controls your users&#39; access to your
            /// Amazon S3 bucket or EFS file system. The policies attached to this role determine the level of
            /// access that you want to provide your users when transferring files into and out of your Amazon S3
            /// bucket or EFS file system. The IAM role should also contain a trust relationship that allows the
            /// server to access your resources when servicing your users&#39; transfer requests.
            /// Required: Yes
            /// Type: String
            /// Minimum: 20
            /// Maximum: 2048
            /// Pattern: arn:. *role/. *
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Role { get; set; }

            /// <summary>
            /// HomeDirectory
            /// The landing directory (folder) for a user when they log in to the server using the client.
            /// A HomeDirectory example is /bucket_name/home/mydirectory.
            /// Required: No
            /// Type: String
            /// Maximum: 1024
            /// Pattern: ^$|/. *
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> HomeDirectory { get; set; }

            /// <summary>
            /// HomeDirectoryType
            /// The type of landing directory (folder) you want your users&#39; home directory to be when they log into
            /// the server. If you set it to PATH, the user will see the absolute Amazon S3 bucket or EFS paths as
            /// is in their file transfer protocol clients. If you set it LOGICAL, you need to provide mappings in
            /// the HomeDirectoryMappings for how you want to make Amazon S3 or EFS paths visible to your users.
            /// Required: No
            /// Type: String
            /// Allowed values: LOGICAL | PATH
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> HomeDirectoryType { get; set; }

            /// <summary>
            /// ServerId
            /// A system-assigned unique identifier for a server instance. This is the specific server that you
            /// added your user to.
            /// Required: Yes
            /// Type: String
            /// Minimum: 19
            /// Maximum: 19
            /// Pattern: ^s-([0-9a-f]{17})$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ServerId { get; set; }

            /// <summary>
            /// UserName
            /// A unique string that identifies a user and is associated with a as specified by the ServerId. This
            /// user name must be a minimum of 3 and a maximum of 100 characters long. The following are valid
            /// characters: a-z, A-Z, 0-9, underscore &#39;_&#39;, hyphen &#39;-&#39;, period &#39;. &#39;, and at sign &#39;@&#39;. The user name
            /// can&#39;t start with a hyphen, period, or at sign.
            /// Required: Yes
            /// Type: String
            /// Minimum: 3
            /// Maximum: 100
            /// Pattern: ^[\w][\w@. -]{2,99}$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> UserName { get; set; }

            /// <summary>
            /// HomeDirectoryMappings
            /// Logical directory mappings that specify what Amazon S3 paths and keys should be visible to your user
            /// and how you want to make them visible. You will need to specify the &quot;Entry&quot; and &quot;Target&quot; pair, where
            /// Entry shows how the path is made visible and Target is the actual Amazon S3 path. If you only
            /// specify a target, it will be displayed as is. You will need to also make sure that your IAM role
            /// provides access to paths in Target. The following is an example.
            /// &#39;[ { &quot;Entry&quot;: &quot;/&quot;, &quot;Target&quot;: &quot;/bucket3/customized-reports/&quot; } ]&#39;
            /// In most cases, you can use this value instead of the session policy to lock your user down to the
            /// designated home directory (&quot;chroot&quot;). To do this, you can set Entry to &#39;/&#39; and set Target to the
            /// HomeDirectory parameter value.
            /// Note If the target of a logical directory entry does not exist in Amazon S3, the entry will be
            /// ignored. As a workaround, you can use the Amazon S3 API to create 0 byte objects as place holders
            /// for your directory. If using the CLI, use the s3api call instead of s3 so you can use the put-object
            /// operation. For example, you use the following: AWS s3api put-object --bucket bucketname --key
            /// path/to/folder/. Make sure that the end of the key name ends in a &#39;/&#39; for it to be considered a
            /// folder.
            /// Required: No
            /// Type: List of HomeDirectoryMapEntry
            /// Maximum: 50
            /// Update requires: No interruption
            /// </summary>
            public List<HomeDirectoryMapEntry> HomeDirectoryMappings { get; set; }

            /// <summary>
            /// PosixProfile
            /// Specifies the full POSIX identity, including user ID (Uid), group ID (Gid), and any secondary groups
            /// IDs (SecondaryGids), that controls your users&#39; access to your Amazon Elastic File System (Amazon
            /// EFS) file systems. The POSIX permissions that are set on files and directories in your file system
            /// determine the level of access your users get when transferring files into and out of your Amazon EFS
            /// file systems.
            /// Required: No
            /// Type: PosixProfile
            /// Update requires: No interruption
            /// </summary>
            public PosixProfile PosixProfile { get; set; }

            /// <summary>
            /// SshPublicKeys
            /// Specifies the public key portion of the Secure Shell (SSH) keys stored for the described user.
            /// Required: No
            /// Type: List of SshPublicKey
            /// Maximum: 5
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> SshPublicKeys { get; set; }

            /// <summary>
            /// Tags
            /// Key-value pairs that can be used to group and search for users. Tags are metadata attached to users
            /// for any purpose.
            /// Required: No
            /// Type: List of Tag
            /// Maximum: 50
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::Transfer::User";

        public UserProperties Properties { get; } = new UserProperties();

    }

    public static class UserAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ServerId = new ResourceAttribute<Union<string, IntrinsicFunction>>("ServerId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> UserName = new ResourceAttribute<Union<string, IntrinsicFunction>>("UserName");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
