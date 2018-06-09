using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IAM.ManagedPolicy
{
    /// <summary>
    /// AWS::IAM::ManagedPolicy
    /// AWS::IAM::ManagedPolicy creates an AWS Identity and Access Management (IAM) managed policy for your AWS
    /// account, which you can use to apply permissions to IAM users, groups, and roles. For more information about
    /// managed policies, see Managed Policies and Inline Policies in the IAM User Guide guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-managedpolicy.html
    /// </summary>
    public class ManagedPolicyResource : ResourceBase
    {
        public class ManagedPolicyProperties
        {
            /// <summary>
            /// Description
            /// A description of the IAM policy. For example, describe the permissions that are defined in the
            /// policy.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Groups
            /// The names of IAM groups to attach to this policy.
            /// Required: No
            /// Type: List of String values
            /// Update requires: No interruption
            /// </summary>
			public Union<List<string>, IntrinsicFunction> Groups { get; set; }

            /// <summary>
            /// ManagedPolicyName
            /// A custom, friendly name for your IAM managed policy. For valid values, see the PolicyName parameter
            /// of the CreatePolicy action in the IAM API Reference.
            /// If you don&#39;t specify a PolicyName, AWS CloudFormation generates a unique physical ID and uses that
            /// ID for the policy name. For more information, see Name Type.
            /// Important If you specify a name, you cannot perform updates that require replacement of this
            /// resource. You can perform updates that require no or some interruption. If you must replace the
            /// resource, specify a new name.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ManagedPolicyName { get; set; }

            /// <summary>
            /// Path
            /// The path for the IAM policy. By default, the path is /. For more information, see IAM Identifiers in
            /// the IAM User Guide.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Path { get; set; }

            /// <summary>
            /// PolicyDocument
            /// Policies that define the permissions for this managed policy. For more information about policy
            /// syntax, see IAM Policy Elements Reference in IAM User Guide.
            /// Required: Yes
            /// Type: JSON object
            /// Note AWS Identity and Access Management (IAM) requires that policies be in JSON format. However, for
            /// templates formatted in YAML, you can create an IAM policy in either JSON or YAML format. AWS
            /// CloudFormation always converts a policy to JSON format before submitting it to IAM.
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> PolicyDocument { get; set; }

            /// <summary>
            /// Roles
            /// The names of IAM roles to attach to this policy.
            /// Note If a policy has a Ref to a role and if a resource (such as AWS::ECS::Service) also has a Ref to
            /// the same role, add a DependsOn attribute to the resource so that the resource depends on the policy.
            /// This dependency ensures that the role&#39;s policy is available throughout the resource&#39;s lifecycle. For
            /// example, when you delete a stack with an AWS::ECS::Service resource, the DependsOn attribute ensures
            /// that the AWS::ECS::Service resource can complete its deletion before its role&#39;s policy is deleted.
            /// Required: No
            /// Type: List of String values
            /// Update requires: No interruption
            /// </summary>
			public Union<List<string>, IntrinsicFunction> Roles { get; set; }

            /// <summary>
            /// Users
            /// The names of users to attach to this policy.
            /// Required: No
            /// Type: List of String values
            /// Update requires: No interruption
            /// </summary>
			public Union<List<string>, IntrinsicFunction> Users { get; set; }

        }
    
        public string Type { get; } = "AWS::IAM::ManagedPolicy";
        
        public ManagedPolicyProperties Properties { get; } = new ManagedPolicyProperties();
    }
}
