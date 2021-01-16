using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceCatalog.AcceptedPortfolioShare
{
    /// <summary>
    /// AWS::ServiceCatalog::AcceptedPortfolioShare
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-acceptedportfolioshare.html
    /// </summary>
    public class AcceptedPortfolioShareResource : ResourceBase
    {
        public class AcceptedPortfolioShareProperties
        {
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

        }

        public string Type { get; } = "AWS::ServiceCatalog::AcceptedPortfolioShare";

        public AcceptedPortfolioShareProperties Properties { get; } = new AcceptedPortfolioShareProperties();

    }
}
