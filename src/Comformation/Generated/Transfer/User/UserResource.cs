using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Transfer.User
{
    /// <summary>
    /// AWS::Transfer::User
    /// Creates a user and associates them with an existing Secure File Transfer Protocol (SFTP) server. You can only
    /// create and associate users with SFTP servers that have the IdentityProviderType set to SERVICE_MANAGED. Using
    /// parameters for CreateUser, you can specify the user name, set the home directory, store the user&#39;s public key,
    /// and assign the user&#39;s AWS Identity and Access Management (IAM) role. You can also optionally add a scope-down
    /// policy, and assign metadata with tags that can be used to group and search for users.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-user.html
    /// </summary>
    public class UserResource : ResourceBase
    {
        public class UserProperties
        {
            /// <summary>
            /// Policy
            /// A scope-down policy for your user so you can use the same IAM role across multiple users. This
            /// policy scopes down user access to portions of their Amazon S3 bucket. Variables that you can use
            /// inside this policy include ${Transfer:UserName}, ${Transfer:HomeDirectory}, and
            /// ${Transfer:HomeBucket}.
            /// Note For scope-down policies, AWS Transfer for SFTP stores the policy as a JSON blob, instead of the
            /// Amazon Resource Name (ARN) of the policy. You save the policy as a JSON blob and pass it in the
            /// Policy argument. For an example of a scope-down policy, see Creating a Scope-Down Policy. For more
            /// information, see AssumeRole in the AWS Security Token Service API Reference.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Policy { get; set; }

            /// <summary>
            /// Role
            /// The IAM role that controls your user&#39;s access to your Amazon S3 bucket. The policies attached to
            /// this role will determine the level of access you want to provide your users when transferring files
            /// into and out of your Amazon S3 bucket or buckets. The IAM role should also contain a trust
            /// relationship that allows the SFTP server to access your resources when servicing your SFTP user&#39;s
            /// transfer requests.
            /// Required: Yes
            /// Type: String
            /// Pattern: arn:. *role/. *
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Role { get; set; }

            /// <summary>
            /// HomeDirectory
            /// The landing directory (folder) for a user when they log in to the server using their SFTP client. An
            /// example is /home/username .
            /// Required: No
            /// Type: String
            /// Maximum: 1024
            /// Pattern: ^$|/. *
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> HomeDirectory { get; set; }

            /// <summary>
            /// ServerId
            /// A system-assigned unique identifier for an SFTP server instance. This is the specific SFTP server
            /// that you added your user to.
            /// Required: Yes
            /// Type: String
            /// Pattern: ^s-([0-9a-f]{17})$
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ServerId { get; set; }

            /// <summary>
            /// UserName
            /// A unique string that identifies a user and is associated with a server as specified by the ServerId.
            /// This user name must be a minimum of 3 and a maximum of 32 characters long. The following are valid
            /// characters: a-z, A-Z, 0-9, underscore, and hyphen. The user name can&#39;t start with a hyphen.
            /// Required: Yes
            /// Type: String
            /// Pattern: ^[a-zA-Z0-9_][a-zA-Z0-9_-]{2,31}$
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> UserName { get; set; }

            /// <summary>
            /// SshPublicKeys
            /// This property contains the public key portion of the Secure Shell (SSH) keys stored for the
            /// described user.
            /// Required: No
            /// Type: List of SshPublicKey
            /// Maximum: 5
            /// Update requires: No interruption
            /// </summary>
			public List<SshPublicKey> SshPublicKeys { get; set; }

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
