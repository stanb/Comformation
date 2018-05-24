using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IAM.User
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-user.html
    /// </summary>
    public class UserResource : ResourceBase
    {
        public class UserProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-user.html#cfn-iam-user-groups
            /// </summary>
			public Union<List<string>, IntrinsicFunction> Groups { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-user.html#cfn-iam-user-loginprofile
            /// </summary>
			public Union<LoginProfile, IntrinsicFunction> LoginProfile { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-user.html#cfn-iam-user-managepolicyarns
            /// </summary>
			public Union<List<string>, IntrinsicFunction> ManagedPolicyArns { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-user.html#cfn-iam-user-path
            /// </summary>
			public Union<string, IntrinsicFunction> Path { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-user.html#cfn-iam-user-policies
            /// </summary>
			public Union<List<Policy>, IntrinsicFunction> Policies { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-user.html#cfn-iam-user-username
            /// </summary>
			public Union<string, IntrinsicFunction> UserName { get; set; }

        }
    
        public string Type { get; } = "AWS::IAM::User";
        
        public UserProperties Properties { get; } = new UserProperties();
    }

	public static class UserAttributes
	{
        public static readonly ResourceAttribute<string> Arn = new ResourceAttribute<string>("Arn");
	}
}
