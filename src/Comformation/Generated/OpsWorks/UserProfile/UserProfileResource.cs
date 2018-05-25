using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.OpsWorks.UserProfile
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-userprofile.html
    /// </summary>
    public class UserProfileResource : ResourceBase
    {
        public class UserProfileProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-userprofile.html#cfn-opsworks-userprofile-allowselfmanagement
            /// </summary>
			public Union<bool, IntrinsicFunction> AllowSelfManagement { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-userprofile.html#cfn-opsworks-userprofile-iamuserarn
            /// </summary>
			public Union<string, IntrinsicFunction> IamUserArn { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-userprofile.html#cfn-opsworks-userprofile-sshpublickey
            /// </summary>
			public Union<string, IntrinsicFunction> SshPublicKey { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-userprofile.html#cfn-opsworks-userprofile-sshusername
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
