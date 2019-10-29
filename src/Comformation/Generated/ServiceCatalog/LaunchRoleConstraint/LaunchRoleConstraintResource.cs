using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceCatalog.LaunchRoleConstraint
{
    /// <summary>
    /// AWS::ServiceCatalog::LaunchRoleConstraint
    /// Specifies a launch constraint.
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
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> RoleArn { get; set; }

        }

        public string Type { get; } = "AWS::ServiceCatalog::LaunchRoleConstraint";

        public LaunchRoleConstraintProperties Properties { get; } = new LaunchRoleConstraintProperties();

    }
}
