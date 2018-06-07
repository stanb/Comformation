using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IAM.InstanceProfile
{
    /// <summary>
    /// AWS::IAM::InstanceProfile
    /// The AWS::IAM::InstanceProfile resource creates an AWS Identity and Access Management (IAM) instance profile
    /// that can be used with IAM roles for EC2 instances.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-instanceprofile.html
    /// </summary>
    public class InstanceProfileResource : ResourceBase
    {
        public class InstanceProfileProperties
        {
            /// <summary>
            /// InstanceProfileName
            /// The name of the instance profile that you want to create. This parameter allows (per its regex
            /// pattern) a string consisting of upper and lowercase alphanumeric characters with no spaces. You can
            /// also include any of the following characters: = , . @ -.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-instanceprofile.html#cfn-iam-instanceprofile-instanceprofilename
            /// </summary>
			public Union<string, IntrinsicFunction> InstanceProfileName { get; set; }

            /// <summary>
            /// Path
            /// The path associated with this IAM instance profile. For information about IAM paths, see Friendly
            /// Names and Paths in the AWS Identity and Access Management User Guide.
            /// By default, AWS CloudFormation specifies / for the path.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-instanceprofile.html#cfn-iam-instanceprofile-path
            /// </summary>
			public Union<string, IntrinsicFunction> Path { get; set; }

            /// <summary>
            /// Roles
            /// The name of an existing IAM role to associate with this instance profile. Currently, you can assign
            /// a maximum of one role to an instance profile.
            /// Required: Yes
            /// Type: List of String values
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-instanceprofile.html#cfn-iam-instanceprofile-roles
            /// </summary>
			public Union<List<string>, IntrinsicFunction> Roles { get; set; }

        }
    
        public string Type { get; } = "AWS::IAM::InstanceProfile";
        
        public InstanceProfileProperties Properties { get; } = new InstanceProfileProperties();
    }

	public static class InstanceProfileAttributes
	{
        public static readonly ResourceAttribute<string> Arn = new ResourceAttribute<string>("Arn");
	}
}
