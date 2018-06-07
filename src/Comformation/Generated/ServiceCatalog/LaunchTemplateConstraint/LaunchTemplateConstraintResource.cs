using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceCatalog.LaunchTemplateConstraint
{
    /// <summary>
    /// AWS::ServiceCatalog::LaunchTemplateConstraint
    /// Creates a template constraint for AWS Service Catalog. For more information, see CreateConstraint in the AWS
    /// Service Catalog Developer Guide.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-launchtemplateconstraint.html
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
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-launchtemplateconstraint.html#cfn-servicecatalog-launchtemplateconstraint-description
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// AcceptLanguage
            /// The language code.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-launchtemplateconstraint.html#cfn-servicecatalog-launchtemplateconstraint-acceptlanguage
            /// </summary>
			public Union<string, IntrinsicFunction> AcceptLanguage { get; set; }

            /// <summary>
            /// PortfolioId
            /// The portfolio identifier.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-launchtemplateconstraint.html#cfn-servicecatalog-launchtemplateconstraint-portfolioid
            /// </summary>
			public Union<string, IntrinsicFunction> PortfolioId { get; set; }

            /// <summary>
            /// ProductId
            /// The product identifier.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-launchtemplateconstraint.html#cfn-servicecatalog-launchtemplateconstraint-productid
            /// </summary>
			public Union<string, IntrinsicFunction> ProductId { get; set; }

            /// <summary>
            /// Rules
            /// The constraint rules.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-launchtemplateconstraint.html#cfn-servicecatalog-launchtemplateconstraint-rules
            /// </summary>
			public Union<string, IntrinsicFunction> Rules { get; set; }

        }
    
        public string Type { get; } = "AWS::ServiceCatalog::LaunchTemplateConstraint";
        
        public LaunchTemplateConstraintProperties Properties { get; } = new LaunchTemplateConstraintProperties();
    }
}
