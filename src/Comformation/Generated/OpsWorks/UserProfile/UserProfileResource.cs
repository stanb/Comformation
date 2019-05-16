using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.OpsWorks.UserProfile
{
    /// <summary>
    /// AWS::OpsWorks::UserProfile
    /// Describes a user&#39;s SSH information.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-userprofile.html
    /// </summary>
    public class UserProfileResource : ResourceBase
    {
        public class UserProfileProperties
        {
            /// <summary>
            /// AllowSelfManagement
            /// Whether users can specify their own SSH public key through the My Settings page. For more
            /// information, see Managing User Permissions.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> AllowSelfManagement { get; set; }

            /// <summary>
            /// IamUserArn
            /// The user&#39;s IAM ARN.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> IamUserArn { get; set; }

            /// <summary>
            /// SshPublicKey
            /// The user&#39;s SSH public key.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> SshPublicKey { get; set; }

            /// <summary>
            /// SshUsername
            /// The user&#39;s SSH user name.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> SshUsername { get; set; }

        }

        public string Type { get; } = "AWS::OpsWorks::UserProfile";

        public UserProfileProperties Properties { get; } = new UserProfileProperties();

    }

	public static class UserProfileAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> SshUsername = new ResourceAttribute<Union<string, IntrinsicFunction>>("SshUsername");
	}
}
