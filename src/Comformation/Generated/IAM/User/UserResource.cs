using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IAM.User
{
    /// <summary>
    /// AWS::IAM::User
    /// The AWS::IAM::User type creates a user.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-user.html
    /// </summary>
    public class UserResource : ResourceBase
    {
        public class UserProperties
        {
            /// <summary>
            /// Groups
            /// A name of a group to which you want to add the user.
            /// Required: No
            /// Type: List of String values
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> Groups { get; set; }

            /// <summary>
            /// LoginProfile
            /// Creates a login profile so that the user can access the AWS Management Console.
            /// Required: No
            /// Type: IAM User LoginProfile
            /// Update requires: No interruption
            /// </summary>
			public LoginProfile LoginProfile { get; set; }

            /// <summary>
            /// ManagedPolicyArns
            /// One or more managed policy ARNs to attach to this user.
            /// Required: No
            /// Type: List of String values
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> ManagedPolicyArns { get; set; }

            /// <summary>
            /// Path
            /// The path for the user name. For more information about paths, see IAM Identifiers in the IAM User
            /// Guide.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Path { get; set; }

            /// <summary>
            /// Policies
            /// The policies to associate with this user. For information about policies, see Overview of IAM
            /// Policies in the IAM User Guide.
            /// Note If you specify multiple polices, specify unique values for the policy name. If you don&#39;t,
            /// updates to the IAM user will fail.
            /// Required: No
            /// Type: List of IAM Policies
            /// Update requires: No interruption
            /// </summary>
			public List<Policy> Policies { get; set; }

            /// <summary>
            /// UserName
            /// A name for the IAM user. For valid values, see the UserName parameter for the CreateUser action in
            /// the IAM API Reference. If you don&#39;t specify a name, AWS CloudFormation generates a unique physical
            /// ID and uses that ID for the user name.
            /// Important If you specify a name, you cannot perform updates that require replacement of this
            /// resource. You can perform updates that require no or some interruption. If you must replace the
            /// resource, specify a new name.
            /// If you specify a name, you must specify the CAPABILITY_NAMED_IAM value to acknowledge your
            /// template&#39;s capabilities. For more information, see Acknowledging IAM Resources in AWS CloudFormation
            /// Templates.
            /// Warning Naming an IAM resource can cause an unrecoverable error if you reuse the same template in
            /// multiple regions. To prevent this, we recommend using Fn::Join and AWS::Region to create a
            /// region-specific name, as in the following example: {&quot;Fn::Join&quot;: [&quot;&quot;, [{&quot;Ref&quot;: &quot;AWS::Region&quot;},
            /// {&quot;Ref&quot;: &quot;MyResourceName&quot;}]]}.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> UserName { get; set; }

        }
    
        public string Type { get; } = "AWS::IAM::User";
        
        public UserProperties Properties { get; } = new UserProperties();

    }

	public static class UserAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
	}
}
