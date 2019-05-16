using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceCatalog.LaunchTemplateConstraint
{
    /// <summary>
    /// AWS::ServiceCatalog::LaunchTemplateConstraint
    /// Specifies a template constraint.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-launchtemplateconstraint.html
    /// </summary>
    public class LaunchTemplateConstraintResource : ResourceBase
    {
        public class LaunchTemplateConstraintProperties
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
            /// Rules
            /// The constraint rules.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Rules { get; set; }

        }

        public string Type { get; } = "AWS::ServiceCatalog::LaunchTemplateConstraint";

        public LaunchTemplateConstraintProperties Properties { get; } = new LaunchTemplateConstraintProperties();

    }
}
