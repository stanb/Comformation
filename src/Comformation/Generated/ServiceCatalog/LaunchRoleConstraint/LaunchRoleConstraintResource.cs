using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceCatalog.LaunchRoleConstraint
{
    /// <summary>
    /// AWS::ServiceCatalog::LaunchRoleConstraint
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-launchroleconstraint.html
    /// </summary>
    public class LaunchRoleConstraintResource : ResourceBase
    {
        public class LaunchRoleConstraintProperties
        {
            /// <summary>
            /// Description
            /// The description of the constraint.
            /// Required: No
            /// Type: String
            /// Maximum: 2000
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// LocalRoleName
            /// You are required to specify either the RoleArn or the LocalRoleName but can&#39;t use both.
            /// If you specify the LocalRoleName property, when an account uses the launch constraint, the IAM role
            /// with that name in the account will be used. This allows launch-role constraints to be
            /// account-agnostic so the administrator can create fewer resources per shared account.
            /// The given role name must exist in the account used to create the launch constraint and the account
            /// of the user who launches a product with this launch constraint.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> LocalRoleName { get; set; }

            /// <summary>
            /// AcceptLanguage
            /// The language code.
            /// en - English (default) jp - Japanese zh - Chinese
            /// Required: No
            /// Type: String
            /// Maximum: 100
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> AcceptLanguage { get; set; }

            /// <summary>
            /// PortfolioId
            /// The portfolio identifier.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 100
            /// Pattern: ^[a-zA-Z0-9_\-]*
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> PortfolioId { get; set; }

            /// <summary>
            /// ProductId
            /// The product identifier.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 100
            /// Pattern: ^[a-zA-Z0-9_\-]*
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ProductId { get; set; }

            /// <summary>
            /// RoleArn
            /// The ARN of the launch role.
            /// You are required to specify RoleArn or LocalRoleName but can&#39;t use both.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> RoleArn { get; set; }

        }

        public string Type { get; } = "AWS::ServiceCatalog::LaunchRoleConstraint";

        public LaunchRoleConstraintProperties Properties { get; } = new LaunchRoleConstraintProperties();

    }
}
