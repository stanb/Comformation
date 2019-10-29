using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IAM.Policy
{
    /// <summary>
    /// AWS::IAM::Policy
    /// Adds or updates an inline policy document that is embedded in the specified IAM user, group, or role.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-policy.html
    /// </summary>
    public class PolicyResource : ResourceBase
    {
        public class PolicyProperties
        {
            /// <summary>
            /// Groups
            /// The name of the group to associate the policy with.
            /// This parameter allows (through its regex pattern) a string of characters consisting of upper and
            /// lowercase alphanumeric characters with no spaces. You can also include any of the following
            /// characters: _+=,. @-.
            /// Required: No
            /// Type: List of String
            /// Minimum: 1
            /// Maximum: 128
            /// Pattern: [\w+=,. @-]+
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> Groups { get; set; }

            /// <summary>
            /// PolicyDocument
            /// The policy document.
            /// You must provide policies in JSON format in IAM. However, for AWS CloudFormation templates formatted
            /// in YAML, you can provide the policy in JSON or YAML format. AWS CloudFormation always converts a
            /// YAML policy to JSON format before submitting it to IAM.
            /// The regex pattern used to validate this parameter is a string of characters consisting of the
            /// following:
            /// Any printable ASCII character ranging from the space character (\u0020) through the end of the ASCII
            /// character range The printable characters in the Basic Latin and Latin-1 Supplement character set
            /// (through \u00FF) The special characters tab (\u0009), line feed (\u000A), and carriage return
            /// (\u000D)
            /// Required: Yes
            /// Type: Json
            /// Minimum: 1
            /// Maximum: 131072
            /// Pattern: [\u0009\u000A\u000D\u0020-\u00FF]+
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> PolicyDocument { get; set; }

            /// <summary>
            /// PolicyName
            /// The name of the policy document.
            /// This parameter allows (through its regex pattern) a string of characters consisting of upper and
            /// lowercase alphanumeric characters with no spaces. You can also include any of the following
            /// characters: _+=,. @-
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Pattern: [\w+=,. @-]+
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> PolicyName { get; set; }

            /// <summary>
            /// Roles
            /// The name of the role to associate the policy with.
            /// This parameter allows (per its regex pattern) a string of characters consisting of upper and
            /// lowercase alphanumeric characters with no spaces. You can also include any of the following
            /// characters: _+=,. @-
            /// Note If an external policy (such as AWS::IAM::Policy or AWS::IAM::ManagedPolicy) has a Ref to a role
            /// and if a resource (such as AWS::ECS::Service) also has a Ref to the same role, add a DependsOn
            /// attribute to the resource to make the resource depend on the external policy. This dependency
            /// ensures that the role&#39;s policy is available throughout the resource&#39;s lifecycle. For example, when
            /// you delete a stack with an AWS::ECS::Service resource, the DependsOn attribute ensures that AWS
            /// CloudFormation deletes the AWS::ECS::Service resource before deleting its role&#39;s policy.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> Roles { get; set; }

            /// <summary>
            /// Users
            /// The name of the user to associate the policy with.
            /// This parameter allows (through its regex pattern) a string of characters consisting of upper and
            /// lowercase alphanumeric characters with no spaces. You can also include any of the following
            /// characters: _+=,. @-
            /// Required: No
            /// Type: List of String
            /// Minimum: 1
            /// Maximum: 128
            /// Pattern: [\w+=,. @-]+
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> Users { get; set; }

        }

        public string Type { get; } = "AWS::IAM::Policy";

        public PolicyProperties Properties { get; } = new PolicyProperties();

    }
}
