using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSO.PermissionSet
{
    /// <summary>
    /// AWS::SSO::PermissionSet
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sso-permissionset.html
    /// </summary>
    public class PermissionSetResource : ResourceBase
    {
        public class PermissionSetProperties
        {
            /// <summary>
            /// Name
            /// The name of the permission set.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 32
            /// Pattern: [\w+=,. @-]+
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Description
            /// The description of the AWS::SSO::PermissionSet.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 700
            /// Pattern: [\p{L}\p{M}\p{Z}\p{S}\p{N}\p{P}]*
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// InstanceArn
            /// The ARN of the SSO instance under which the operation will be executed. For more information about
            /// ARNs, see Amazon Resource Names (ARNs) and AWS Service Namespaces in the AWS General Reference.
            /// Required: Yes
            /// Type: String
            /// Minimum: 10
            /// Maximum: 1224
            /// Pattern: arn:aws:sso:::instance/(sso)?ins-[a-zA-Z0-9-. ]{16}
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> InstanceArn { get; set; }

            /// <summary>
            /// SessionDuration
            /// The length of time that the application user sessions are valid for in the ISO-8601 standard.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 100
            /// Pattern:
            /// ^(-?)P(?=\d|T\d)(?:(\d+)Y)?(?:(\d+)M)?(?:(\d+)([DW]))?(?:T(?:(\d+)H)?(?:(\d+)M)?(?:(\d+(?:\.
            /// \d+)?)S)?)?$
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> SessionDuration { get; set; }

            /// <summary>
            /// RelayStateType
            /// Used to redirect users within the application during the federation authentication process.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 240
            /// Pattern: [a-zA-Z0-9&amp;amp;$@#\\\/%?=~\-_&#39;&quot;|!:,. ;*+\[\]\ \(\)\{\}]+
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> RelayStateType { get; set; }

            /// <summary>
            /// ManagedPolicies
            /// A structure that stores the details of the IAM managed policy.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> ManagedPolicies { get; set; }

            /// <summary>
            /// InlinePolicy
            /// The IAM inline policy that is attached to the permission set.
            /// Required: No
            /// Type: Json
            /// Minimum: 1
            /// Maximum: 10240
            /// Pattern: [\u0009\u000A\u000D\u0020-\u00FF]+
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> InlinePolicy { get; set; }

            /// <summary>
            /// Tags
            /// The tags to attach to the new AWS::SSO::PermissionSet.
            /// Required: No
            /// Type: List of Tag
            /// Maximum: 50
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::SSO::PermissionSet";

        public PermissionSetProperties Properties { get; } = new PermissionSetProperties();

    }

    public static class PermissionSetAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> PermissionSetArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("PermissionSetArn");
    }
}
