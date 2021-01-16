using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceCatalog.ResourceUpdateConstraint
{
    /// <summary>
    /// AWS::ServiceCatalog::ResourceUpdateConstraint
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-resourceupdateconstraint.html
    /// </summary>
    public class ResourceUpdateConstraintResource : ResourceBase
    {
        public class ResourceUpdateConstraintProperties
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
            /// TagUpdateOnProvisionedProduct
            /// If set to ALLOWED, lets users change tags in a CloudFormationProvisionedProduct resource.
            /// If set to NOT_ALLOWED, prevents users from changing tags in a CloudFormationProvisionedProduct
            /// resource.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> TagUpdateOnProvisionedProduct { get; set; }

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

        }

        public string Type { get; } = "AWS::ServiceCatalog::ResourceUpdateConstraint";

        public ResourceUpdateConstraintProperties Properties { get; } = new ResourceUpdateConstraintProperties();

    }
}
