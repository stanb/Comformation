using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceCatalog.PortfolioPrincipalAssociation
{
    /// <summary>
    /// AWS::ServiceCatalog::PortfolioPrincipalAssociation
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
            /// Minimum: 1
            /// Maximum: 1000
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> PrincipalARN { get; set; }

            /// <summary>
            /// AcceptLanguage
            /// The language code.
            /// en - English (default) jp - Japanese zh - Chinese
            /// Required: No
            /// Type: String
            /// Maximum: 100
            /// Update requires: Replacement
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
            /// PrincipalType
            /// The principal type. The supported value is IAM.
            /// Required: Yes
            /// Type: String
            /// Allowed values: IAM
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> PrincipalType { get; set; }

        }

        public string Type { get; } = "AWS::ServiceCatalog::PortfolioPrincipalAssociation";

        public PortfolioPrincipalAssociationProperties Properties { get; } = new PortfolioPrincipalAssociationProperties();

    }
}
