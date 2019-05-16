using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceCatalog.Portfolio
{
    /// <summary>
    /// AWS::ServiceCatalog::Portfolio
    /// Specifies a portfolio.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-portfolio.html
    /// </summary>
    public class PortfolioResource : ResourceBase
    {
        public class PortfolioProperties
        {
            /// <summary>
            /// ProviderName
            /// The name of the portfolio provider.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 50
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ProviderName { get; set; }

            /// <summary>
            /// Description
            /// The description of the portfolio.
            /// Required: No
            /// Type: String
            /// Maximum: 2000
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// DisplayName
            /// The name to use for display purposes.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 100
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> DisplayName { get; set; }

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
            /// Tags
            /// One or more tags.
            /// Required: No
            /// Type: List of Tag
            /// Maximum: 20
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::ServiceCatalog::Portfolio";

        public PortfolioProperties Properties { get; } = new PortfolioProperties();

    }

	public static class PortfolioAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> PortfolioName = new ResourceAttribute<Union<string, IntrinsicFunction>>("PortfolioName");
	}
}
