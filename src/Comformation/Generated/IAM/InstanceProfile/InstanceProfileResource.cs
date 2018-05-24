using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IAM.InstanceProfile
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-instanceprofile.html
    /// </summary>
    public class InstanceProfileResource : ResourceBase
    {
        public class InstanceProfileProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-instanceprofile.html#cfn-iam-instanceprofile-instanceprofilename
            /// </summary>
			public Union<string, IntrinsicFunction> InstanceProfileName { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-instanceprofile.html#cfn-iam-instanceprofile-path
            /// </summary>
			public Union<string, IntrinsicFunction> Path { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-instanceprofile.html#cfn-iam-instanceprofile-roles
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
