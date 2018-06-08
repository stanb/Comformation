using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IAM.Role
{
    /// <summary>
    /// AWS::IAM::Role
    /// Creates an AWS Identity and Access Management (IAM) role. Use an IAM role to enable applications running on an
    /// EC2 instance to securely access your AWS resources.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-role.html
    /// </summary>
    public class RoleResource : ResourceBase
    {
        public class RoleProperties
        {
            /// <summary>
            /// AssumeRolePolicyDocument
            /// The trust policy that is associated with this role. You can associate only one assume role policy
            /// with a role. For an example of an assume role policy, see Template Examples. For more information
            /// about the elements that you can use in an IAM policy, see IAM Policy Elements Reference in the IAM
            /// User Guide.
            /// Required: Yes
            /// Type: A JSON policy document
            /// Note AWS Identity and Access Management (IAM) requires that policies be in JSON format. However, for
            /// templates formatted in YAML, you can create an IAM policy in either JSON or YAML format. AWS
            /// CloudFormation always converts a policy to JSON format before submitting it to IAM.
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> AssumeRolePolicyDocument { get; set; }

            /// <summary>
            /// ManagedPolicyArns
            /// One or more managed policy ARNs to attach to this role.
            /// Required: No
            /// Type: List of String values
            /// Update requires: No interruption
            /// </summary>
			public Union<List<string>, IntrinsicFunction> ManagedPolicyArns { get; set; }

            /// <summary>
            /// MaxSessionDuration
            /// The maximum session duration (in seconds) for the specified role. Anyone who uses the AWS CLI or API
            /// to assume the role can specify the duration using the optional DurationSeconds API parameter or
            /// duration-seconds CLI parameter. Minimum value of 3600. Maximum value of 43200.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> MaxSessionDuration { get; set; }

            /// <summary>
            /// Path
            /// The path associated with this role. For information about IAM paths, see Friendly Names and Paths in
            /// IAM User Guide.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Path { get; set; }

            /// <summary>
            /// Policies
            /// The policies to associate with this role. For sample templates, see Template Examples.
            /// Important The name of each policy for a role, user, or group must be unique. If you don't, updates
            /// to the IAM role will fail.
            /// Note If an external policy (such as AWS::IAM::Policy or AWS::IAM::ManagedPolicy) has a Ref to a role
            /// and if a resource (such as AWS::ECS::Service) also has a Ref to the same role, add a DependsOn
            /// attribute to the resource to make the resource depend on the external policy. This dependency
            /// ensures that the role's policy is available throughout the resource's lifecycle. For example, when
            /// you delete a stack with an AWS::ECS::Service resource, the DependsOn attribute ensures that AWS
            /// CloudFormation deletes the AWS::ECS::Service resource before deleting its role's policy.
            /// Required: No
            /// Type: List of IAM Policies
            /// Update requires: No interruption
            /// </summary>
			public Union<List<Policy>, IntrinsicFunction> Policies { get; set; }

            /// <summary>
            /// RoleName
            /// A name for the IAM role. For valid values, see the RoleName parameter for the CreateRole action in
            /// the IAM API Reference. If you don't specify a name, AWS CloudFormation generates a unique physical
            /// ID and uses that ID for the group name.
            /// Important If you specify a name, you cannot perform updates that require replacement of this
            /// resource. You can perform updates that require no or some interruption. If you must replace the
            /// resource, specify a new name.
            /// If you specify a name, you must specify the CAPABILITY_NAMED_IAM value to acknowledge your
            /// template's capabilities. For more information, see Acknowledging IAM Resources in AWS CloudFormation
            /// Templates.
            /// Warning Naming an IAM resource can cause an unrecoverable error if you reuse the same template in
            /// multiple regions. To prevent this, we recommend using Fn::Join and AWS::Region to create a
            /// region-specific name, as in the following example: {"Fn::Join": ["", [{"Ref": "AWS::Region"},
            /// {"Ref": "MyResourceName"}]]}.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> RoleName { get; set; }

        }
    
        public string Type { get; } = "AWS::IAM::Role";
        
        public RoleProperties Properties { get; } = new RoleProperties();
    }

	public static class RoleAttributes
	{
        public static readonly ResourceAttribute<string> Arn = new ResourceAttribute<string>("Arn");
        public static readonly ResourceAttribute<string> RoleId = new ResourceAttribute<string>("RoleId");
	}
}
