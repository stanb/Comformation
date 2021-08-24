using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IAM.ManagedPolicy
{
    /// <summary>
    /// AWS::IAM::ManagedPolicy
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-managedpolicy.html
    /// </summary>
    public class ManagedPolicyResource : ResourceBase
    {
        public class ManagedPolicyProperties
        {
            /// <summary>
            /// Description
            /// A friendly description of the policy.
            /// Typically used to store information about the permissions defined in the policy. For example,
            /// &quot;Grants access to production DynamoDB tables. &quot;
            /// The policy description is immutable. After a value is assigned, it cannot be changed.
            /// Required: No
            /// Type: String
            /// Maximum: 1000
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Groups
            /// The name (friendly name, not ARN) of the group to attach the policy to.
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
            public List<Union<string, IntrinsicFunction>> Groups { get; set; }

            /// <summary>
            /// ManagedPolicyName
            /// The friendly name of the policy.
            /// Important If you specify a name, you cannot perform updates that require replacement of this
            /// resource. You can perform updates that require no or some interruption. If you must replace the
            /// resource, specify a new name.
            /// If you specify a name, you must specify the CAPABILITY_NAMED_IAM value to acknowledge your
            /// template&#39;s capabilities. For more information, see Acknowledging IAM Resources in AWS CloudFormation
            /// Templates.
            /// Important Naming an IAM resource can cause an unrecoverable error if you reuse the same template in
            /// multiple Regions. To prevent this, we recommend using Fn::Join and AWS::Region to create a
            /// Region-specific name, as in the following example: {&quot;Fn::Join&quot;: [&quot;&quot;, [{&quot;Ref&quot;: &quot;AWS::Region&quot;},
            /// {&quot;Ref&quot;: &quot;MyResourceName&quot;}]]}.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ManagedPolicyName { get; set; }

            /// <summary>
            /// Path
            /// The path for the policy.
            /// For more information about paths, see IAM identifiers in the IAM User Guide.
            /// This parameter is optional. If it is not included, it defaults to a slash (/).
            /// This parameter allows (through its regex pattern) a string of characters consisting of either a
            /// forward slash (/) by itself or a string that must begin and end with forward slashes. In addition,
            /// it can contain any ASCII character from the ! (\u0021) through the DEL character (\u007F), including
            /// most punctuation characters, digits, and upper and lowercased letters.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 512
            /// Pattern: ((/[A-Za-z0-9\. ,\+@=_-]+)*)/
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Path { get; set; }

            /// <summary>
            /// PolicyDocument
            /// The JSON policy document that you want to use as the content for the new policy.
            /// You must provide policies in JSON format in IAM. However, for AWS CloudFormation templates formatted
            /// in YAML, you can provide the policy in JSON or YAML format. AWS CloudFormation always converts a
            /// YAML policy to JSON format before submitting it to IAM.
            /// The maximum length of the policy document that you can pass in this operation, including whitespace,
            /// is listed below. To view the maximum character counts of a managed policy with no whitespaces, see
            /// IAM and AWS STS character quotas.
            /// To learn more about JSON policy grammar, see Grammar of the IAM JSON policy language in the IAM User
            /// Guide.
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
            /// Roles
            /// The name (friendly name, not ARN) of the role to attach the policy to.
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
            /// The name (friendly name, not ARN) of the IAM user to attach the policy to.
            /// This parameter allows (through its regex pattern) a string of characters consisting of upper and
            /// lowercase alphanumeric characters with no spaces. You can also include any of the following
            /// characters: _+=,. @-
            /// Required: No
            /// Type: List of String
            /// Minimum: 1
            /// Maximum: 64
            /// Pattern: [\w+=,. @-]+
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> Users { get; set; }

        }

        public string Type { get; } = "AWS::IAM::ManagedPolicy";

        public ManagedPolicyProperties Properties { get; } = new ManagedPolicyProperties();

    }
}
