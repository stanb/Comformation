using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceCatalog.PortfolioProductAssociation
{
    /// <summary>
    /// AWS::ServiceCatalog::PortfolioProductAssociation
    /// Associates the specified product with the specified portfolio for AWS Service Catalog. For more information,
    /// see AssociateProductWithPortfolio in the AWS Service Catalog Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-portfolioproductassociation.html
    /// </summary>
    public class PortfolioProductAssociationResource : ResourceBase
    {
        public class PortfolioProductAssociationProperties
        {
            /// <summary>
            /// SourcePortfolioId
            /// The identifier of the source portfolio.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> SourcePortfolioId { get; set; }

            /// <summary>
            /// AcceptLanguage
            /// The language code.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> AcceptLanguage { get; set; }

            /// <summary>
            /// PortfolioId
            /// The portfolio identifier.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> PortfolioId { get; set; }

            /// <summary>
            /// ProductId
            /// The product identifier.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ProductId { get; set; }

        }

        public string Type { get; } = "AWS::ServiceCatalog::PortfolioProductAssociation";

        public PortfolioProductAssociationProperties Properties { get; } = new PortfolioProductAssociationProperties();

    }
}
