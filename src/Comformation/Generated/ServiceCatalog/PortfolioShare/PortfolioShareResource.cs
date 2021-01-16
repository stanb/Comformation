using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceCatalog.PortfolioShare
{
    /// <summary>
    /// AWS::ServiceCatalog::PortfolioShare
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-portfolioshare.html
    /// </summary>
    public class PortfolioShareResource : ResourceBase
    {
        public class PortfolioShareProperties
        {
            /// <summary>
            /// AccountId
            /// The AWS account ID. For example, 123456789012.
            /// Required: Yes
            /// Type: String
            /// Pattern: ^[0-9]{12}$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> AccountId { get; set; }

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
            /// ShareTagOptions
            /// </summary>
            public Union<bool, IntrinsicFunction> ShareTagOptions { get; set; }

        }

        public string Type { get; } = "AWS::ServiceCatalog::PortfolioShare";

        public PortfolioShareProperties Properties { get; } = new PortfolioShareProperties();

    }
}
