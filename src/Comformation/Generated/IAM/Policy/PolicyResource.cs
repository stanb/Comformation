using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IAM.Policy
{
    /// <summary>
    /// AWS::IAM::Policy
    /// The AWS::IAM::Policy resource associates an IAM policy with IAM users, roles, or groups. For more information
    /// about IAM policies, see Overview of IAM Policies in the IAM User Guide guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-policy.html
    /// </summary>
    public class PolicyResource : ResourceBase
    {
        public class PolicyProperties
        {
            /// <summary>
            /// Groups
            /// The names of groups to which you want to add the policy.
            /// Required: Conditional. You must specify at least one of the following properties: Groups, Roles, or
            /// Users.
            /// Type: List of String values
            /// Update requires: No interruption
            /// </summary>
			public Union<List<string>, IntrinsicFunction> Groups { get; set; }

            /// <summary>
            /// PolicyDocument
            /// A policy document that contains permissions to add to the specified users or groups.
            /// Required: Yes
            /// Type: JSON object
            /// Note AWS Identity and Access Management (IAM) requires that policies be in JSON format. However, for
            /// templates formatted in YAML, you can create an IAM policy in either JSON or YAML format. AWS
            /// CloudFormation always converts a policy to JSON format before submitting it to IAM.
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> PolicyDocument { get; set; }

            /// <summary>
            /// PolicyName
            /// The name of the policy. If you specify multiple policies for an entity, specify unique names. For
            /// example, if you specify a list of policies for an IAM role, each policy must have a unique name.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> PolicyName { get; set; }

            /// <summary>
            /// Roles
            /// The names of AWS::IAM::Roles to which this policy will be attached.
            /// Note If a policy has a Ref to a role and if a resource (such as AWS::ECS::Service) also has a Ref to
            /// the same role, add a DependsOn attribute to the resource so that the resource depends on the policy.
            /// This dependency ensures that the role's policy is available throughout the resource's lifecycle. For
            /// example, when you delete a stack with an AWS::ECS::Service resource, the DependsOn attribute ensures
            /// that the AWS::ECS::Service resource can complete its deletion before its role's policy is deleted.
            /// Required: Conditional. You must specify at least one of the following properties: Groups, Roles, or
            /// Users.
            /// Type: List of String values
            /// Update requires: No interruption
            /// </summary>
			public Union<List<string>, IntrinsicFunction> Roles { get; set; }

            /// <summary>
            /// Users
            /// The names of users for whom you want to add the policy.
            /// Required: Conditional. You must specify at least one of the following properties: Groups, Roles, or
            /// Users.
            /// Type: List of String values
            /// Update requires: No interruption
            /// </summary>
			public Union<List<string>, IntrinsicFunction> Users { get; set; }

        }
    
        public string Type { get; } = "AWS::IAM::Policy";
        
        public PolicyProperties Properties { get; } = new PolicyProperties();
    }
}
