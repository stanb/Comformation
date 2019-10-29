using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceCatalog.StackSetConstraint
{
    /// <summary>
    /// AWS::ServiceCatalog::StackSetConstraint
    /// Specifies a StackSet constraint.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-stacksetconstraint.html
    /// </summary>
    public class StackSetConstraintResource : ResourceBase
    {
        public class StackSetConstraintProperties
        {
            /// <summary>
            /// Description
            /// The description of the constraint.
            /// Required: Yes
            /// Type: String
            /// Maximum: 2000
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// StackInstanceControl
            /// Permission to create, update, and delete stack instances. Choose from ALLOWED and NOT_ALLOWED.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> StackInstanceControl { get; set; }

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
            /// RegionList
            /// One or more AWS Regions where the provisioned product will be available.
            /// Applicable only to a CFN_STACKSET provisioned product type.
            /// The specified regions should be within the list of regions from the STACKSET constraint. To get the
            /// list of regions in the STACKSET constraint, use the DescribeProvisioningParameters operation.
            /// If no values are specified, the default value is all regions from the STACKSET constraint.
            /// Required: Yes
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> RegionList { get; set; }

            /// <summary>
            /// AdminRole
            /// AdminRole ARN
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> AdminRole { get; set; }

            /// <summary>
            /// AccountList
            /// One or more AWS accounts that will have access to the provisioned product.
            /// Required: Yes
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> AccountList { get; set; }

            /// <summary>
            /// ExecutionRole
            /// ExecutionRole name
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ExecutionRole { get; set; }

        }

        public string Type { get; } = "AWS::ServiceCatalog::StackSetConstraint";

        public StackSetConstraintProperties Properties { get; } = new StackSetConstraintProperties();

    }
}
