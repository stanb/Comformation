using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceCatalog.PortfolioPrincipalAssociation
{
    /// <summary>
    /// AWS::ServiceCatalog::PortfolioPrincipalAssociation
    /// Associates the specified principal with the specified portfolio for AWS Service Catalog. For more information,
    /// see AssociatePrincipalWithPortfolio in the AWS Service Catalog Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-portfolioprincipalassociation.html
    /// </summary>
    public class PortfolioPrincipalAssociationResource : ResourceBase
    {
        public class PortfolioPrincipalAssociationProperties
        {
            /// <summary>
            /// PrincipalARN
            /// The ARN of the principal (IAM user, role, or group).
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> PrincipalARN { get; set; }

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
            /// PrincipalType
            /// The principal type (IAM).
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> PrincipalType { get; set; }

        }

        public string Type { get; } = "AWS::ServiceCatalog::PortfolioPrincipalAssociation";

        public PortfolioPrincipalAssociationProperties Properties { get; } = new PortfolioPrincipalAssociationProperties();

    }
}
