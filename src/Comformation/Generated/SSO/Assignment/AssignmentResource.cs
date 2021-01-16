using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSO.Assignment
{
    /// <summary>
    /// AWS::SSO::Assignment
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sso-assignment.html
    /// </summary>
    public class AssignmentResource : ResourceBase
    {
        public class AssignmentProperties
        {
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
            /// TargetId
            /// TargetID is an AWS account identifier, typically a 10-12 digit string (For example, 123456789012).
            /// Required: Yes
            /// Type: String
            /// Pattern: \d{12}
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> TargetId { get; set; }

            /// <summary>
            /// TargetType
            /// The entity type for which the assignment will be created.
            /// Required: Yes
            /// Type: String
            /// Allowed values: AWS_ACCOUNT
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> TargetType { get; set; }

            /// <summary>
            /// PermissionSetArn
            /// The ARN of the permission set.
            /// Required: Yes
            /// Type: String
            /// Minimum: 10
            /// Maximum: 1224
            /// Pattern: arn:aws:sso:::permissionSet/(sso)?ins-[a-zA-Z0-9-. ]{16}/ps-[a-zA-Z0-9-. /]{16}
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> PermissionSetArn { get; set; }

            /// <summary>
            /// PrincipalType
            /// The entity type for which the assignment will be created.
            /// Required: Yes
            /// Type: String
            /// Allowed values: GROUP | USER
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> PrincipalType { get; set; }

            /// <summary>
            /// PrincipalId
            /// An identifier for an object in AWS SSO, such as a user or group. PrincipalIds are GUIDs (For
            /// example, f81d4fae-7dec-11d0-a765-00a0c91e6bf6). For more information about PrincipalIds in AWS SSO,
            /// see the AWS SSO Identity Store API Reference.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 47
            /// Pattern:
            /// ^([0-9a-f]{10}-|)[A-Fa-f0-9]{8}-[A-Fa-f0-9]{4}-[A-Fa-f0-9]{4}-[A-Fa-f0-9]{4}-[A-Fa-f0-9]{12}$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> PrincipalId { get; set; }

        }

        public string Type { get; } = "AWS::SSO::Assignment";

        public AssignmentProperties Properties { get; } = new AssignmentProperties();

    }
}
