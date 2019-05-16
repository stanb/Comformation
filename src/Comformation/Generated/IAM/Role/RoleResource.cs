using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IAM.Role
{
    /// <summary>
    /// AWS::IAM::Role
    /// Creates a new role for your AWS account. For more information about roles, go to IAM Roles. For information
    /// about limitations on role names and the number of roles you can create, go to Limitations on IAM Entities in
    /// the IAM User Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-role.html
    /// </summary>
    public class RoleResource : ResourceBase
    {
        public class RoleProperties
        {
            /// <summary>
            /// AssumeRolePolicyDocument
            /// The trust policy that is associated with this role. Trust policies define which entities can assume
            /// the role. You can associate only one trust policy with a role. For an example of a policy that can
            /// be used to assume a role, see Template Examples. For more information about the elements that you
            /// can use in an IAM policy, see IAM Policy Elements Reference in the IAM User Guide.
            /// Required: Yes
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> AssumeRolePolicyDocument { get; set; }

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
            /// MaxSessionDuration
            /// The maximum session duration (in seconds) that you want to set for the specified role. If you do not
            /// specify a value for this setting, the default maximum of one hour is applied. This setting can have
            /// a value from 1 hour to 12 hours.
            /// Anyone who assumes the role from the AWS CLI or API can use the DurationSeconds API parameter or the
            /// duration-seconds CLI parameter to request a longer session. The MaxSessionDuration setting
            /// determines the maximum duration that can be requested using the DurationSeconds parameter. If users
            /// don&#39;t specify a value for the DurationSeconds parameter, their security credentials are valid for
            /// one hour by default. This applies when you use the AssumeRole* API operations or the assume-role*
            /// CLI operations but does not apply when you use those operations to create a console URL. For more
            /// information, see Using IAM Roles in the IAM User Guide.
            /// Required: No
            /// Type: Integer
            /// Minimum: 3600
            /// Maximum: 43200
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> MaxSessionDuration { get; set; }

            /// <summary>
            /// Path
            /// The path to the role. For more information about paths, see IAM Identifiers in the IAM User Guide.
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
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Path { get; set; }

            /// <summary>
            /// PermissionsBoundary
            /// The ARN of the policy used to set the permissions boundary for the role.
            /// For more information about permissions boundaries, see Permissions Boundaries for IAM Identities in
            /// the IAM User Guide.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> PermissionsBoundary { get; set; }

            /// <summary>
            /// Policies
            /// Adds or updates an inline policy document that is embedded in the specified IAM role.
            /// When you embed an inline policy in a role, the inline policy is used as part of the role&#39;s access
            /// (permissions) policy. The role&#39;s trust policy is created at the same time as the role. You can
            /// update a role&#39;s trust policy later. For more information about IAM roles, go to Using Roles to
            /// Delegate Permissions and Federate Identities.
            /// A role can also have an attached managed policy. For information about policies, see Managed
            /// Policies and Inline Policies in the IAM User Guide.
            /// For information about limits on the number of inline policies that you can embed with a role, see
            /// Limitations on IAM Entities in the IAM User Guide.
            /// Note If an external policy (such as AWS::IAM::Policy or AWS::IAM::ManagedPolicy) has a Ref to a role
            /// and if a resource (such as AWS::ECS::Service) also has a Ref to the same role, add a DependsOn
            /// attribute to the resource to make the resource depend on the external policy. This dependency
            /// ensures that the role&#39;s policy is available throughout the resource&#39;s lifecycle. For example, when
            /// you delete a stack with an AWS::ECS::Service resource, the DependsOn attribute ensures that AWS
            /// CloudFormation deletes the AWS::ECS::Service resource before deleting its role&#39;s policy.
            /// Required: No
            /// Type: List of Policy
            /// Update requires: No interruption
            /// </summary>
			public List<Policy> Policies { get; set; }

            /// <summary>
            /// RoleName
            /// A name for the IAM role. For valid values, see the RoleName parameter for the CreateRole action in
            /// the IAM User Guide.
            /// This parameter allows (per its regex pattern) a string of characters consisting of upper and
            /// lowercase alphanumeric characters with no spaces. You can also include any of the following
            /// characters: _+=,. @-. The role name must be unique within the account. Role names are not
            /// distinguished by case. For example, you cannot create roles named both &quot;Role1&quot; and &quot;role1&quot;.
            /// If you don&#39;t specify a name, AWS CloudFormation generates a unique physical ID and uses that ID for
            /// the role name.
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
			public Union<string, IntrinsicFunction> RoleName { get; set; }

        }

        public string Type { get; } = "AWS::IAM::Role";

        public RoleProperties Properties { get; } = new RoleProperties();

    }

	public static class RoleAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> RoleId = new ResourceAttribute<Union<string, IntrinsicFunction>>("RoleId");
	}
}
