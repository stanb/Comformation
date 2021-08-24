using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IAM.User
{
    /// <summary>
    /// AWS::IAM::User
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-user.html
    /// </summary>
    public class UserResource : ResourceBase
    {
        public class UserProperties
        {
            /// <summary>
            /// Groups
            /// A list of groups to which you want to add the user.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> Groups { get; set; }

            /// <summary>
            /// LoginProfile
            /// Creates a password for the specified IAM user. A password allows an IAM user to access AWS services
            /// through the AWS Management Console.
            /// You can use the AWS CLI, the AWS API, or the Users page in the IAM console to create a password for
            /// any IAM user. Use ChangePassword to update your own existing password in the My Security Credentials
            /// page in the AWS Management Console.
            /// For more information about managing passwords, see Managing passwords in the IAM User Guide.
            /// Required: No
            /// Type: LoginProfile
            /// Update requires: No interruption
            /// </summary>
            public LoginProfile LoginProfile { get; set; }

            /// <summary>
            /// ManagedPolicyArns
            /// A list of Amazon Resource Names (ARNs) of the IAM managed policies that you want to attach to the
            /// user.
            /// For more information about ARNs, see Amazon Resource Names (ARNs) and AWS Service Namespaces in the
            /// AWS General Reference.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> ManagedPolicyArns { get; set; }

            /// <summary>
            /// Path
            /// The path for the user name. For more information about paths, see IAM identifiers in the IAM User
            /// Guide.
            /// This parameter is optional. If it is not included, it defaults to a slash (/).
            /// This parameter allows (through its regex pattern) a string of characters consisting of either a
            /// forward slash (/) by itself or a string that must begin and end with forward slashes. In addition,
            /// it can contain any ASCII character from the ! (\u0021) through the DEL character (\u007F), including
            /// most punctuation characters, digits, and upper and lowercased letters.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 512
            /// Pattern: (\u002F)|(\u002F[\u0021-\u007F]+\u002F)
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Path { get; set; }

            /// <summary>
            /// PermissionsBoundary
            /// The ARN of the policy that is used to set the permissions boundary for the user.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> PermissionsBoundary { get; set; }

            /// <summary>
            /// Policies
            /// Adds or updates an inline policy document that is embedded in the specified IAM user. To view
            /// AWS::IAM::User snippets, see Declaring an IAM User Resource.
            /// Important The name of each policy for a role, user, or group must be unique. If you don&#39;t choose
            /// unique names, updates to the IAM identity will fail.
            /// For information about limits on the number of inline policies that you can embed in a user, see
            /// Limitations on IAM Entities in the IAM User Guide.
            /// Required: No
            /// Type: List of Policy
            /// Update requires: No interruption
            /// </summary>
            public List<Policy> Policies { get; set; }

            /// <summary>
            /// Tags
            /// A list of tags that you want to attach to the new user. Each tag consists of a key name and an
            /// associated value. For more information about tagging, see Tagging IAM resources in the IAM User
            /// Guide.
            /// Note If any one of the tags is invalid or if you exceed the allowed maximum number of tags, then the
            /// entire request fails and the resource is not created.
            /// Required: No
            /// Type: List of Tag
            /// Maximum: 50
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// UserName
            /// The name of the user to create. Do not include the path in this value.
            /// This parameter allows (per its regex pattern) a string of characters consisting of upper and
            /// lowercase alphanumeric characters with no spaces. You can also include any of the following
            /// characters: _+=,. @-. The user name must be unique within the account. User names are not
            /// distinguished by case. For example, you cannot create users named both &quot;John&quot; and &quot;john&quot;.
            /// If you don&#39;t specify a name, AWS CloudFormation generates a unique physical ID and uses that ID for
            /// the user name.
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
