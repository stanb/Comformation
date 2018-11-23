using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceCatalog.PortfolioShare
{
    /// <summary>
    /// AWS::ServiceCatalog::PortfolioShare
    /// Shares the specified portfolio for AWS Service Catalog with the specified account. For more information, see
    /// CreatePortfolioShare in the AWS Service Catalog Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-portfolioshare.html
    /// </summary>
    public class PortfolioShareResource : ResourceBase
    {
        public class PortfolioShareProperties
        {
            /// <summary>
            /// AccountId
            /// The AWS account ID.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> AccountId { get; set; }

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

        }

        public string Type { get; } = "AWS::ServiceCatalog::PortfolioShare";

        public PortfolioShareProperties Properties { get; } = new PortfolioShareProperties();

    }
}
