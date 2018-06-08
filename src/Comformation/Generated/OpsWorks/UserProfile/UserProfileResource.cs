using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.OpsWorks.UserProfile
{
    /// <summary>
    /// AWS::OpsWorks::UserProfile
    /// The AWS::OpsWorks::UserProfile resource configures SSH access for users who require access to instances in an
    /// AWS OpsWorks stack.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-userprofile.html
    /// </summary>
    public class UserProfileResource : ResourceBase
    {
        public class UserProfileProperties
        {
            /// <summary>
            /// AllowSelfManagement
            /// Indicates whether users can use the AWS OpsWorks My Settings page to specify their own SSH public
            /// key. For more information, see Setting an IAM User's Public SSH Key in the AWS OpsWorks User Guide.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> AllowSelfManagement { get; set; }

            /// <summary>
            /// IamUserArn
            /// The Amazon Resource Name (ARN) of the AWS Identity and Access Management (IAM) user to associate
            /// with this configuration.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> IamUserArn { get; set; }

            /// <summary>
            /// SshPublicKey
            /// The public SSH key that is associated with the IAM user. To access instances, the IAM user must have
            /// or be given the corresponding private key.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> SshPublicKey { get; set; }

            /// <summary>
            /// SshUsername
            /// The user's SSH user name.
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
        public static readonly ResourceAttribute<string> SshUsername = new ResourceAttribute<string>("SshUsername");
	}
}
