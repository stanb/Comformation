using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IAM.Group
{
    /// <summary>
    /// AWS::IAM::Group
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-group.html
    /// </summary>
    public class GroupResource : ResourceBase
    {
        public class GroupProperties
        {
            /// <summary>
            /// GroupName
            /// The name of the group to create. Do not include the path in this value.
            /// The group name must be unique within the account. Group names are not distinguished by case. For
            /// example, you cannot create groups named both &quot;ADMINS&quot; and &quot;admins&quot;. If you don&#39;t specify a name, AWS
            /// CloudFormation generates a unique physical ID and uses that ID for the group name.
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
            public Union<string, IntrinsicFunction> GroupName { get; set; }

            /// <summary>
            /// ManagedPolicyArns
            /// The Amazon Resource Name (ARN) of the IAM policy you want to attach.
            /// For more information about ARNs, see Amazon Resource Names (ARNs) in the AWS General Reference.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> ManagedPolicyArns { get; set; }

            /// <summary>
            /// Path
            /// The path to the group. For more information about paths, see IAM identifiers in the IAM User Guide.
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
            /// Policies
            /// Adds or updates an inline policy document that is embedded in the specified IAM group. To view
            /// AWS::IAM::Group snippets, see Declaring an IAM Group Resource.
            /// Important The name of each inline policy for a role, user, or group must be unique. If you don&#39;t
            /// choose unique names, updates to the IAM identity will fail.
            /// For information about limits on the number of inline policies that you can embed in a group, see
            /// Limitations on IAM Entities in the IAM User Guide.
            /// Required: No
            /// Type: List of Policy
            /// Update requires: No interruption
            /// </summary>
            public List<Policy> Policies { get; set; }

        }

        public string Type { get; } = "AWS::IAM::Group";

        public GroupProperties Properties { get; } = new GroupProperties();

    }

    public static class GroupAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
